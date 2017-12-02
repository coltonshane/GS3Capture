Texture2D <float> w8Texture : register(t0);
Texture2D <uint3> w12Texture : register(t1);
Texture2D <float> xTexture : register(t2);
Texture2D <float4> yTexture : register(t3);
Texture2D <float4> zTexture : register(t4);
sampler TextureSampler : register(s0);

cbuffer ConstBuffer : register(c0)
{
	float2 resolution;				// 8
	float black_level;				// 4
	float gamma;					// 4
	float brightness;				// 4
	float contrast;					// 4
	float rwmix;					// 4
	float gwmix;					// 4
	float bwmix;					// 4
	float rbmix;					// 4
	float gbmix;					// 4
	float bbmix;					// 4
	float saturation;				// 4
	float hue_shift;				// 4
	
	float conv11;					// 4
	float conv12;					// 4
	float conv13;					// 4
	float conv14;					// 4
	float conv15;					// 4
	
	float conv21;					// 4
	float conv22;					// 4
	float conv23;					// 4
	float conv24;					// 4
	float conv25;					// 4
	
	float conv31;					// 4
	float conv32;					// 4
	float conv33;					// 4
	float conv34;					// 4
	float conv35;					// 4
	
	float conv41;					// 4
	float conv42;					// 4
	float conv43;					// 4
	float conv44;					// 4
	float conv45;					// 4
	
	float conv51;					// 4
	float conv52;					// 4
	float conv53;					// 4
	float conv54;					// 4
	float conv55;					// 4
	
	uint showclipped;			    // 4	
	
									// 160 Total
}

struct VS_IN
{
	float4 pos : POSITION;
	float2 cords :textcoord;
};

struct PS_IN
{
	float4 pos : SV_POSITION;
	float2 cords :textcoord;
};

PS_IN vs_main(VS_IN input) 
{
	PS_IN output = (PS_IN)0;
	output.pos = input.pos;
    output.cords = input.cords;
	return output;
}

float ps_8toFloat(PS_IN input) : SV_Target
{
	// convert 8-bit unsigned raw pixel data to float raw pixel data
	float outputcolor;
	float2 pxcoord;
	uint2 pxcoord_int;

	pxcoord = float2(input.cords[0], input.cords[1]);
	pxcoord_int.x = floor(pxcoord.x*resolution.x);
	pxcoord_int.y = floor(pxcoord.y*resolution.y);

	outputcolor = w8Texture.Sample(TextureSampler, pxcoord);

	outputcolor = outputcolor - black_level / 4095.0f;

	return outputcolor;
}

float ps_12toFloat(PS_IN input) : SV_Target
{
	// convert 12-bit unsigned raw pixel data to float raw pixel data
	// through R32G32B32 unsigned intermediate

	uint outputcolor_12bit = 0;
	float outputcolor = 0.0f;
	float2 pxcoord;
	uint2 pxcoord_int;
	uint2 pxcoord12_int;

	uint px12 = 0;
	uint px34 = 0;
	uint px56 = 0;
	uint px78 = 0;

	uint3 rawsample;

	uint rem = 0;
	
	pxcoord = float2(input.cords[0], input.cords[1]);
	pxcoord_int.x = floor(pxcoord.x * resolution.x);
	pxcoord_int.y = floor(pxcoord.y * resolution.y);
	
	// pixel coordinates for [12-12-12-12-12-12-12-12] pixels
	pxcoord12_int.x = floor(pxcoord.x * resolution.x / 8.0f);
	pxcoord12_int.y = floor(pxcoord.y * resolution.y / 1.0f);

	int3 loadcoord = { pxcoord12_int.x, pxcoord12_int.y, 0 };

	rawsample = w12Texture.Load(loadcoord);

	// split into four groups of two 12-bit pixels;
	
	px12 = ((rawsample.r >> 0) & 0xFF) << 16;
	px12 += ((rawsample.r >> 8) & 0xFF) << 8;
	px12 += ((rawsample.r >> 16) & 0xFF) << 0;

	px34 = ((rawsample.r >> 24) & 0xFF) << 16;
	px34 += ((rawsample.g >> 0) & 0xFF) << 8;
	px34 += ((rawsample.g >> 8) & 0xFF) << 0;

	px56 = ((rawsample.g >> 16) & 0xFF) << 16;
	px56 += ((rawsample.g >> 24) & 0xFF) << 8;
	px56 += ((rawsample.b >> 0) & 0xFF) << 0;

	px78 = ((rawsample.b >> 8) & 0xFF) << 16;
	px78 += ((rawsample.b >> 16) & 0xFF) << 8;
	px78 += ((rawsample.b >> 24) & 0xFF) << 0;
	
	// select the output corresponding to the exact pixel position
	rem = pxcoord_int.x % 8;
	switch (rem)
	{
	case 0:
		outputcolor_12bit = (((px12 >> 16) & 0xFF) << 4) + ((px12 >> 8) & 0x0F);
		break;
	case 1:
		outputcolor_12bit = (((px12 >> 0) & 0xFF) << 4) + ((px12 >> 12) & 0x0F);
		break;
	case 2:
		outputcolor_12bit = (((px34 >> 16) & 0xFF) << 4) + ((px34 >> 8) & 0x0F);
		break;
	case 3:
		outputcolor_12bit = (((px34 >> 0) & 0xFF) << 4) + ((px34 >> 12) & 0x0F);
		break;
	case 4:
		outputcolor_12bit = (((px56 >> 16) & 0xFF) << 4) + ((px56 >> 8) & 0x0F);
		break;
	case 5:
		outputcolor_12bit = (((px56 >> 0) & 0xFF) << 4) + ((px56 >> 12) & 0x0F);
		break;
	case 6:
		outputcolor_12bit = (((px78 >> 16) & 0xFF) << 4) + ((px78 >> 8) & 0x0F);
		break;
	case 7:
		outputcolor_12bit = (((px78 >> 0) & 0xFF) << 4) + ((px78 >> 12) & 0x0F);
		break;
	default:
		break;
	}

	outputcolor = (float)((int)outputcolor_12bit - (int)black_level) / (4095.0f - black_level);

	return outputcolor;
}

float4 ps_debayer(PS_IN input) : SV_Target
{
	float4 outputcolor;
	float4 tempcolor;
	float4 tempcolor2;
	float4 sample;	
	float2 pxcoord;
	uint2 pxcoord_int;
	float2 samplecoord;
	float2 dxy;
	float c_alpha;
	float c_beta;
	float c_gamma;
	float c_hue;
	float c_sat;
	uint bayer_pattern;
	
	// Choose bayer pattern based on horizontal resolution (IMX174 vs. IMX255).
	if (resolution.x > 2000.0f)
	{
		bayer_pattern = 1;
	}
	else
	{
		bayer_pattern = 0;
	}

	dxy = float2(1.0f / resolution.x, 1.0f / resolution.y);
	pxcoord = float2(input.cords[0], input.cords[1]);
	pxcoord_int.x = floor(pxcoord.x*resolution.x);
	pxcoord_int.y = floor(pxcoord.y*resolution.y);
	sample = xTexture.Sample(TextureSampler, pxcoord);
	
	// start at black
	tempcolor.r = 0.0f;
	tempcolor.g = 0.0f;
	tempcolor.b = 0.0f;
	
	if(pxcoord_int.y % 2 == bayer_pattern)
	{
		if(pxcoord_int.x % 2 == 0)
		{
			tempcolor.r = sample;
			
			// === GREEN AT RED OR BLUE LOCATION === //
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));
			
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));
			
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.g += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));
			
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));
			
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.g /= 16.0f;
			// === GREEN AT RED LOCATION or GREEN AT BLUE LOCATION === //
			
			// === RED AT BLUE LOCATION or BLUE AT RED LOCATION //
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.b += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			tempcolor.b += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			tempcolor.b += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));

			tempcolor.b += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.b += 12.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.b += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			tempcolor.b += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			tempcolor.b += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.b += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.b /= 16.0f;
			// === RED AT BLUE LOCATION or BLUE AT RED LOCATION //
		}
		else
		{
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));

			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			tempcolor.r += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.r += 10.f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			tempcolor.r += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.r /= 16.0f;
			
			tempcolor.g = sample;
			
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			tempcolor.b += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));

			tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.b += 10.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			tempcolor.b += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.b /= 16.0f;
		}
	}
	else
	{
		if(pxcoord_int.x % 2 == 0)
		{
			
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			tempcolor.r += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));

			tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.r += 10.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			tempcolor.r += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.r += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.r /= 16.0f;
			
			tempcolor.g = sample;
			
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));

			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			tempcolor.b += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.b += 10.f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			tempcolor.b += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			tempcolor.b += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.b += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.b /= 16.0f;
		}
		else
		{
			// === RED AT BLUE LOCATION or BLUE AT RED LOCATION //
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.r += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			tempcolor.r += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			tempcolor.r += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));

			tempcolor.r += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.r += 12.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.r += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			tempcolor.r += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			tempcolor.r += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.r += -3.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.r += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.r /= 16.0f;
			// === RED AT BLUE LOCATION or BLUE AT RED LOCATION //
			
			// === GREEN AT RED OR BLUE LOCATION === //
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));
			
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));
			
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
			tempcolor.g += 8.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f));
			
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
			tempcolor.g += 4.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));
			
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
			tempcolor.g += -2.0f * xTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
			// tempcolor.g += xTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
			
			tempcolor.g /= 16.0f;
			// === GREEN AT RED OR BLUE LOCATION === //
			
			tempcolor.b = sample;
		}
	}

	// Gamma
	tempcolor.r = pow(tempcolor.r, 1.0f / gamma);
	tempcolor.g = pow(tempcolor.g, 1.0f / gamma);
	tempcolor.b = pow(tempcolor.b, 1.0f / gamma);
	
	// Brightness and Color Correct --> Constrast
	tempcolor.r = (tempcolor.r - 0.5f * (2.0f - brightness)) * contrast + 0.5f;
	tempcolor.g = (tempcolor.g - 0.5f * (2.0f - brightness)) * contrast + 0.5f;
	tempcolor.b = (tempcolor.b - 0.5f * (2.0f - brightness)) * contrast + 0.5f;
	
	// Clarke Transform Color Processing:
	c_gamma = 0.3333f * tempcolor.r + 0.3333f * tempcolor.g + 0.3333f * tempcolor.b;
	
	tempcolor.r = tempcolor.r + rwmix * c_gamma + rbmix * (1.0 - c_gamma);
	tempcolor.g = tempcolor.g + gwmix * c_gamma + gbmix * (1.0 - c_gamma);
	tempcolor.b = tempcolor.b + bwmix * c_gamma + bbmix * (1.0 - c_gamma);
	
	c_alpha = 0.6667f * tempcolor.r - 0.3333f * tempcolor.g - 0.3333f * tempcolor.b;
	c_beta = 0.5774f * tempcolor.g - 0.5774f * tempcolor.b;
	
	c_hue = atan2(c_beta, c_alpha);
	c_sat = sqrt(pow(abs(c_alpha), 2) + pow(abs(c_beta), 2));
	c_sat *= saturation;
	c_hue += hue_shift;
	c_alpha = c_sat * cos(c_hue + hue_shift);
	c_beta = c_sat * sin(c_hue);
	
	tempcolor.r = c_alpha + c_gamma;
	tempcolor.g = -0.5f * c_alpha + 0.8660f * c_beta + c_gamma;
	tempcolor.b = -0.5f * c_alpha - 0.8660f * c_beta + c_gamma;
	
	// Detect Clipping
	if(showclipped == 1)
	{
		if ((tempcolor.r >= 1.0f) || (tempcolor.g >= 1.0f) || (tempcolor.b >= 1.0f))
		{
			tempcolor.r = 1.0f - tempcolor.r;
			tempcolor.g = 1.0f - tempcolor.g;
			tempcolor.b = 1.0f - tempcolor.b;
		}
		else if ((tempcolor.r <= 0.0f) || (tempcolor.g <= 0.0f) || (tempcolor.b <= 0.0f))
		{
			tempcolor.r = 1.0f - tempcolor.r;
			tempcolor.g = 1.0f - tempcolor.g;
			tempcolor.b = 1.0f - tempcolor.b;
		}
	}
	
	outputcolor.r = tempcolor.r;
	outputcolor.g = tempcolor.g;
	outputcolor.b = tempcolor.b;
	outputcolor.a = 1.0f;
	
	return   outputcolor;
}

float4 ps_convolve(PS_IN input) : SV_Target
{
	float4 outputcolor;
	float4 tempcolor;
	float2 pxcoord;
	float2 dxy; 
	
	pxcoord = float2(input.cords[0],input.cords[1]);

	dxy = float2(1.0f / resolution.x, 1.0f / resolution.y);

	// start at black
	tempcolor.r = 0.0f;
	tempcolor.g = 0.0f;
	tempcolor.b = 0.0f;
	
	// 5x5 convolution matrix
	// limited to 3x3 matrix here for speed
	/*
	tempcolor += conv11 * yTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -2.0f * dxy.y));
	tempcolor += conv12 * yTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -2.0f * dxy.y));
	tempcolor += conv13 * yTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -2.0f * dxy.y));
	tempcolor += conv14 * yTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -2.0f * dxy.y));
	tempcolor += conv15 * yTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -2.0f * dxy.y));
	*/
	
	// tempcolor += conv21 * yTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, -dxy.y));
	tempcolor += conv22 * yTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, -dxy.y));
	tempcolor += conv23 * yTexture.Sample(TextureSampler, pxcoord + float2(0.0f, -dxy.y));
	tempcolor += conv24 * yTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, -dxy.y));
	// tempcolor += conv25 * yTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, -dxy.y));
	
	// tempcolor += conv31 * yTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 0.0f));
	tempcolor += conv32 * yTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 0.0f));
	tempcolor += conv33 * yTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 0.0f));
	tempcolor += conv34 * yTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 0.0f));
	// tempcolor += conv35 * yTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 0.0f)); 
	
	// tempcolor += conv41 * yTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, dxy.y));
	tempcolor += conv42 * yTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, dxy.y));
	tempcolor += conv43 * yTexture.Sample(TextureSampler, pxcoord + float2(0.0f, dxy.y));
	tempcolor += conv44 * yTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, dxy.y));
	// tempcolor += conv45 * yTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, dxy.y));

	/*		
	tempcolor += conv51 * yTexture.Sample(TextureSampler, pxcoord + float2(-2.0f * dxy.x, 2.0f * dxy.y));
	tempcolor += conv52 * yTexture.Sample(TextureSampler, pxcoord + float2(-dxy.x, 2.0f * dxy.y));
	tempcolor += conv53 * yTexture.Sample(TextureSampler, pxcoord + float2(0.0f, 2.0f * dxy.y));
	tempcolor += conv54 * yTexture.Sample(TextureSampler, pxcoord + float2(dxy.x, 2.0f * dxy.y));
	tempcolor += conv55 * yTexture.Sample(TextureSampler, pxcoord + float2(2.0f * dxy.x, 2.0f * dxy.y));
	*/

	outputcolor = tempcolor;

	outputcolor.a = 1.0f;
	
	return outputcolor;
}

float4 ps_draw(PS_IN input) : SV_Target
{
	float4 outputcolor;
	float4 tempcolor;
	float2 pxcoord;
	float2 dxy;

	pxcoord = float2(input.cords[0],input.cords[1]);

	outputcolor = zTexture.Sample(TextureSampler, pxcoord);

	outputcolor.a = 1.0f;

	return outputcolor;
}

