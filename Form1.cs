//=============================================================================
// Copyright © 2010 Point Grey Research, Inc. All Rights Reserved.
//
// This software is the confidential and proprietary information of Point
// Grey Research, Inc. ("Confidential Information").  You shall not
// disclose such Confidential Information and shall use it only in
// accordance with the terms of the license agreement you entered into
// with PGR.
//
// PGR MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY OF THE
// SOFTWARE, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE, OR NON-INFRINGEMENT. PGR SHALL NOT BE LIABLE FOR ANY DAMAGES
// SUFFERED BY LICENSEE AS A RESULT OF USING, MODIFYING OR DISTRIBUTING
// THIS SOFTWARE OR ITS DERIVATIVES.
//=============================================================================
//=============================================================================
// $Id: Form1.cs,v 1.4 2011-02-03 23:34:52 soowei Exp $
//=============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Diagnostics;

using FlyCapture2Managed;
using FlyCapture2Managed.Gui;

using SlimDX;

namespace FlyCapture2SimpleGUI_CSharp
{
    public partial class Form1 : Form
    {
        private FlyCapture2Managed.Gui.CameraControlDialog m_camCtlDlg;
        private ManagedCameraBase m_camera = null;
        private ManagedImage m_rawImage;
        private ManagedImage m_processedImage;
        private ManagedImage m_histImage;
        private ManagedImageStatistics m_histImageStats;
        private bool m_grabImages;
        private AutoResetEvent m_grabThreadExited;
        private AutoResetEvent m_saveThreadExited;
        private BackgroundWorker m_grabThread;
        private BackgroundWorker m_saveThread;

        // I added this to get an idea of frame processing speed:
        int framectr = 0;
        int framectr_old = 0;
        int framerate_proc = 0;
        uint seconds_old = 0;
        int frame_mod = 5;

        // Image Buffer
        ManagedImage[] framebuffer = new ManagedImage[5000];
        int buffersize = 1000;
        int buffer_in_framectr = 0;
        int buffer_out_framectr = 0;
        int diff = 0;
        bool recording_buffer = false;
        bool saving_buffer = false;
        bool first_time = true;
        bool new_clip = true;

        long tstamp2 = 0;

        // Buffering Modes
        const int ONESHOT = 0;
        const int CONTINUOUS = 1;
        int buffermode = ONESHOT;

        // Saving Modes
        ManagedImage m_saveImageCont;
        int fdelay = 3;
        int frame_div = 1;
        int frame_div_ctr = 0;

        // Recording Parameters
        const uint max_recx = 4096;
        const uint max_recy = 2160;
        uint recx = 3840; // 1920;
        uint recy = 2160; // 1200;
        PixelFormat recformat = PixelFormat.PixelFormatRaw8;

        // Camera Control Variables
        float bus_percent = 95.0F;
        float gain = 12.0F;
        const uint SHUTTER_ANGLE = 0;
        const uint SHUTTER_TIME = 1;
        uint shutter_mode = SHUTTER_ANGLE;
        float shutter_div = 2.0F;
        uint wb_red = 512;
        uint wb_blue = 700;

        // DirectX Variables, Raw Debayer and Color Processing:
        SlimDX.DXGI.SwapChainDescription description;
        SlimDX.Direct3D11.Device device;
        SlimDX.DXGI.SwapChain swapChain;
        SlimDX.Direct3D11.DeviceContext context;
        SlimDX.DXGI.Factory factory;
        SlimDX.Direct3D11.Viewport viewport;
        SlimDX.Direct3D11.RenderTargetView renderTarget;
        SlimDX.Direct3D11.Resource resource;
        SlimDX.Direct3D11.ShaderResourceViewDescription resourceViewDesc;
        SlimDX.Direct3D11.ShaderResourceView resourceView;
        SlimDX.DataStream vertices;
        SlimDX.Direct3D11.Buffer vertexBuffer;
        SlimDX.D3DCompiler.ShaderBytecode vsbytecode;
        SlimDX.D3DCompiler.ShaderBytecode psbytecode;
        SlimDX.Direct3D11.PixelShader pixelShader0x8;           // 8-bit uint to float raw conversion
        SlimDX.Direct3D11.PixelShader pixelShader0x12;          // 12-bit packed uint to float raw conversion
        SlimDX.Direct3D11.PixelShader pixelShader1;             // debayer and color correct
        SlimDX.Direct3D11.PixelShader pixelShader2;             // convolve
        SlimDX.Direct3D11.VertexShader vertexShader;
        SlimDX.Direct3D11.SamplerDescription samplerDescription;
        SlimDX.Direct3D11.SamplerState samplerState;
        SlimDX.Direct3D11.Texture2D tex8;
        SlimDX.Direct3D11.Texture2D tex12;
        SlimDX.Direct3D11.Texture2D tex;
        SlimDX.Direct3D11.Texture2D tex_convolve;
        SlimDX.Direct3D11.Texture2D tex_dummy;                  // unused texture to bind to for unbinding others
        SlimDX.Direct3D11.InputElement[] elements = new SlimDX.Direct3D11.InputElement[2];
        SlimDX.Direct3D11.InputLayout layout1;

        // Display Settings:
        bool bigPreview = true;
        bool bigPreviewToggle = false;
        float[,] conv = new float[5,5];
        int viewport_w = (int) max_recx;
        int viewport_h = (int) max_recy;
        bool renderBusy = false;

        // Thread Timing Diagnostics
        Stopwatch swDiagnostic = new Stopwatch();
        TimeSpan UIStart;
        TimeSpan UILast;
        TimeSpan UIEnd;
        float UITime;
        float UIPeriod;
        TimeSpan GrabStart;
        TimeSpan GrabLast;
        TimeSpan GrabEnd;
        float GrabTime;
        float GrabPeriod;
        TimeSpan SaveStart;
        TimeSpan SaveLast;
        TimeSpan SaveEnd;
        float SaveTime;
        float SavePeriod;

        // Globals to avoid unnecessary reinit:
        byte[] lumbyte = new byte[max_recx * max_recy * 3 / 2];
        DataStream bufferdata = new DataStream(160, true, true);
        SlimDX.Direct3D11.Buffer constantBuffer;
        DataBox constantBufferData;

        public Form1()
        {
            InitializeComponent();

            m_rawImage = new ManagedImage();
            m_processedImage = new ManagedImage();
            m_histImage = new ManagedImage();
            m_histImageStats = new ManagedImageStatistics();
            m_camCtlDlg = new CameraControlDialog();

            m_grabThreadExited = new AutoResetEvent(false);
            m_saveThreadExited = new AutoResetEvent(false);
        }

        private void UpdateUI(object sender, ProgressChangedEventArgs e)
        {
            int x1 = 0;
            Graphics buffergfx;
            Graphics histgfx;
            int hx = 0;

            int[] hist = new int[256];
            int hist_max = 0;

            string threadtiming = "";

            UILast = UIStart;
            UIStart = swDiagnostic.Elapsed;
            UIPeriod = (float)(UIStart - UILast).TotalMilliseconds;

            Application.DoEvents();

            // buffergfx = picBuffer.CreateGraphics();
            // buffergfx.Clear(Color.DimGray);

            UpdateStatusBar();

            lblRawSize.Text = String.Format("Raw Image Size: {0}", m_processedImage.receivedDataSize);

            lblBufferSeconds.Text = String.Format("{0:F2}  seconds", (float)buffersize / m_camera.GetProperty(PropertyType.FrameRate).absValue);
            lblBufferGB.Text = String.Format("{0:F2}  GB", (float)m_rawImage.receivedDataSize * buffersize / Math.Pow(2.0, 30));
            lblFramesBuffered.Text = String.Format("Frame In: {0}\r\nFrame Out: {1}\r\nFrame Diff: {2}", buffer_in_framectr, buffer_out_framectr, diff);

            // buffergfx.Dispose();

            if (chkAuto30Hz.Checked == true)
            {
                frame_mod = (int)(m_camera.GetProperty(PropertyType.FrameRate).absValue / 30.0);
                if (frame_mod == 0)
                {
                    frame_mod = 1;
                }
                nudDD.Value = frame_mod;
                nudDD.Enabled = false;
            }
            else
            {
                nudDD.Enabled = true;
                frame_mod = (int) nudDD.Value;
            }

            // Update recording UI based on recording status:
            if (recording_buffer == false)
            {
                btnStart.Text = "START";
                btnClear.Enabled = true;
            }

            // GDI-based preview image. Disabled in favor of DirectX-rendered preview.
            // pictureBox1.Image = m_processedImage.bitmap;
            // pictureBox1.Invalidate();

            renderRaw();

            // Generate histogram from processed image.
            if (chkHistOn.Checked == true)
            {
                // Create a color-processed histogram image. This is slow, only do it when necessary.
                m_processedImage.Convert(PixelFormat.PixelFormatBgr, m_histImage);

                m_histImageStats.EnableAll();
                m_histImage.CalculateStatistics(m_histImageStats);
                m_histImageStats.GetHistogram(StatisticsChannel.Lightness, hist);

                histgfx = picHist.CreateGraphics();
                histgfx.Clear(Color.Black);


                for(hx = 0; hx <= 255; hx++)
                {
                    if(hist[hx] > hist_max)
                    {
                        hist_max = hist[hx];
                    }
                }
                for(hx = 0; hx <= 255; hx++)
                {
                    
                    histgfx.DrawLine(Pens.White, hx, 99, hx, 99 - (hist[hx] * 99 / hist_max));
                }

                chkHistOn.Checked = false;
                histgfx.Dispose();
            }

            UIEnd = swDiagnostic.Elapsed;
            UITime = (float)(UIEnd - UIStart).TotalMilliseconds;

            // Update thread timing diagnostics.
            threadtiming = String.Format("Capture Period: {0:F3}, Time: {1:F3}\r\n", GrabPeriod, GrabTime);
            threadtiming += String.Format("Save Period: {0:F3}, Time: {1:F3}\r\n", SavePeriod, SaveTime);
            threadtiming += String.Format("UI Period: {0:F3}, Time: {1:F3}", UIPeriod, UITime);
            txtDiag.Text = threadtiming;

        }

        private void UpdateStatusBar()
        {

            String statusString;
            uint frame_count;

            statusString = String.Format(
                "Image size: {0} x {1}",
                m_processedImage.cols,
                m_processedImage.rows);

            toolStripStatusLabelImageSize.Text = statusString;

            try
            {
                statusString = String.Format(
                "Requested frame rate: {0}Hz",
                m_camera.GetProperty(PropertyType.FrameRate).absValue);
            }
            catch (FC2Exception ex)
            {
                statusString = "Requested frame rate: 0.00Hz";
            }

            statusString += String.Format("  Proc'd frame rate: {0}Hz", framerate_proc);

            toolStripStatusLabelFrameRate.Text = statusString;

            TimeStamp timestamp;

            timestamp = m_processedImage.timeStamp;
            frame_count = m_processedImage.imageMetadata.embeddedFrameCounter - (uint) framectr;



            statusString = String.Format(
                "Timestamp: {0:000}.{1:0000}.{2:0000} | Framecount Offset: {3:0000}",
                timestamp.cycleSeconds,
                timestamp.cycleCount,
                timestamp.cycleOffset,
                frame_count); 

            toolStripStatusLabelTimestamp.Text = statusString;

            // statusStrip1.Refresh();      // Too slow!
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();

            CameraSelectionDialog camSlnDlg = new CameraSelectionDialog();
            bool retVal = camSlnDlg.ShowModal();
            if (retVal)
            {
                try
                {
                    ManagedPGRGuid[] selectedGuids = camSlnDlg.GetSelectedCameraGuids();
                    ManagedPGRGuid guidToUse = selectedGuids[0];

                    ManagedBusManager busMgr = new ManagedBusManager();
                    InterfaceType ifType = busMgr.GetInterfaceTypeFromGuid(guidToUse);

                    if (ifType == InterfaceType.GigE)
                    {
                        m_camera = new ManagedGigECamera();
                    }
                    else
                    {
                        m_camera = new ManagedCamera();
                    }

                    // Connect to the first selected GUID
                    m_camera.Connect(guidToUse);

                    m_camCtlDlg.Connect(m_camera);

                    CameraInfo camInfo = m_camera.GetCameraInfo();
                    UpdateFormCaption(camInfo);

                    // Set embedded timestamp to on
                    EmbeddedImageInfo embeddedInfo = m_camera.GetEmbeddedImageInfo();
                    embeddedInfo.timestamp.onOff = true;
                    embeddedInfo.frameCounter.onOff = true;
                    m_camera.SetEmbeddedImageInfo(embeddedInfo);

                    Thread.Sleep(250);

                    // FC2 built-in buffering. (Not the on-camera buffer and not the custom large RAM buffer.)
                    FC2Config m_camera_config = new FC2Config();
                    m_camera_config.numBuffers = 10;
                    m_camera_config.grabMode = GrabMode.BufferFrames;
                    m_camera.SetConfiguration(m_camera_config);

                    m_camera.StartCapture();

                    m_grabImages = true;

                    configRawInDevice();        // Set up the DirectX rendering device.
                    swDiagnostic.Start();

                    StartGrabLoop();
                    StartSaveLoop();

                    Thread.Sleep(250);
                    /*
                    setWB();
                    setFrameRate(150.0F);       // also sets shutter to 180deg.
                    setGain(12.0F);
                    */
                    setWB();
                    setFrameRate(30.0F);       // also sets shutter to 180deg.
                    setGain(6.0F);

                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("Failed to load form successfully: " + ex.Message);
                    Environment.ExitCode = -1;
                    Application.Exit();
                    return;
                }

                toolStripButtonStart.Enabled = false;
                toolStripButtonStop.Enabled = true;
            }
            else
            {
                Environment.ExitCode = -1;
                Application.Exit();
                return;
            }
        }

        private void UpdateFormCaption(CameraInfo camInfo)
        {
            String captionString = String.Format(
                "FlyCapture2SimpleGUI_CSharp - {0} {1} ({2})",
                camInfo.vendorName,
                camInfo.modelName,
                camInfo.serialNumber);

            this.Text = captionString;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Camera shutdown:
                toolStripButtonStop_Click(sender, e);
                m_camera.Disconnect();

                // DirectX Cleanup:
                factory.Dispose();
                context.Dispose();
                renderTarget.Dispose();
                swapChain.Dispose();
                device.Dispose();
                resource.Dispose();
                vertices.Close();
                vertexBuffer.Dispose();
                layout1.Dispose();
                vertexShader.Dispose();
                pixelShader1.Dispose();
                pixelShader2.Dispose();

                constantBuffer.Dispose();
                constantBufferData.Data.Dispose();

            }
            catch (FC2Exception ex)
            {
                // Nothing to do here
            }
            catch (NullReferenceException ex)
            {
                // Nothing to do here
            }
        }

        private void StartGrabLoop()
        {
            m_grabThread = new BackgroundWorker();
            m_grabThread.ProgressChanged += new ProgressChangedEventHandler(UpdateUI);
            m_grabThread.DoWork += new DoWorkEventHandler(GrabLoop);
            m_grabThread.WorkerReportsProgress = true;
            m_grabThread.RunWorkerAsync();
        }

        private void StartSaveLoop()
        {
            m_saveThread = new BackgroundWorker();
            m_saveThread.DoWork += new DoWorkEventHandler(SaveLoop);
            m_saveThread.WorkerReportsProgress = false;
            m_saveThread.RunWorkerAsync();
        }

        private void GrabLoop(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (m_grabImages)
            {
                try
                {
                    m_camera.RetrieveBuffer(m_rawImage);
                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("Error: " + ex.Message);
                    continue;
                }

                GrabLast = GrabStart;
                GrabStart = swDiagnostic.Elapsed;
                GrabPeriod = (float)(GrabStart - GrabLast).TotalMilliseconds;
                
                // I added this to keep track of frame processing speed.
                framectr++;
                TimeStamp timestamp;

                // Buffer Images
                if (recording_buffer)
                {
                    if (first_time == true)
                    {
                        framebuffer[buffer_in_framectr % buffersize] = new ManagedImage(m_rawImage);
                    }
                    else
                    {
                        m_rawImage.Convert(m_rawImage.pixelFormat, framebuffer[buffer_in_framectr % buffersize]);
                    }
                    buffer_in_framectr++;
                    if (buffer_in_framectr == buffersize)
                    {
                      /*  if (rdoCont.Checked == false)
                        {
                             recording_buffer = false;
                        }
                        else
                        {
                            // buffer_in_framectr = 0;
                            // continue counting up, but use already-allocated memory
                            first_time = false;
                        }*/
                    }
                }

                lock (this)
                {
                    timestamp = m_rawImage.timeStamp;
                }

                if (timestamp.cycleSeconds != seconds_old)
                {
                    // one second has ellapsed, update the processed frame rate
                    lock (this)
                    {
                        framerate_proc = framectr - framectr_old;
                        framectr_old = framectr;
                    }
                    seconds_old = timestamp.cycleSeconds;
                }

                // Call the UI update at a fraction of the frame rate.
                if (framectr % frame_mod == 0)
                {
                    
                    lock (this)
                    {
                        // Make a preview image including pixel format conversion (slow software debayer).
                        // m_rawImage.Convert(PixelFormat.PixelFormatBgr, m_processedImage);

                        // Make a preview image that's just a snapshot copy of the raw image.
                        m_rawImage.Convert(m_rawImage.pixelFormat, m_processedImage);
                    }

                    GrabEnd = swDiagnostic.Elapsed;
                    GrabTime = (float)(GrabEnd - GrabStart).TotalMilliseconds;
                    
                    worker.ReportProgress(0);
                }

                Thread.Sleep(0);
            }

            m_grabThreadExited.Set();
        }

        private void SaveLoop(object sender, DoWorkEventArgs e)
        {
            // Thread for saving images out of the RAM buffer as fast as possible.

            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (chkContSave.Checked)
                {
                    diff = buffer_in_framectr - buffer_out_framectr;

                    // don't allow the out buffer index to wrap around
                    if(diff >= buffersize)
                    {
                        diff = buffersize - 1;
                        buffer_out_framectr = buffer_in_framectr - diff;
                        // should probably flag some kind of warning here
                    }
                    
                    if (diff > fdelay)
                    {
                        saving_buffer = true;

                        if ((frame_div_ctr % frame_div) == 0)
                        {
                            SaveLast = SaveStart;
                            SaveStart = swDiagnostic.Elapsed;
                            SavePeriod = (float)(SaveStart - SaveLast).TotalMilliseconds;

                            // RAW Saving: Fast, no color processing.
                            framebuffer[buffer_out_framectr % buffersize].Convert(m_saveImageCont.pixelFormat, m_saveImageCont);
                            m_saveImageCont.Save(String.Format("c:\\tmp\\clip{0}\\img{1:D5}.raw", tstamp2, buffer_out_framectr), ImageFileFormat.Raw);

                            SaveEnd = swDiagnostic.Elapsed;
                            SaveTime = (float)(SaveEnd - SaveStart).TotalMilliseconds;
                        }
                        
                        buffer_out_framectr++;
                        frame_div_ctr++;
                    }
                    else
                    {
                        saving_buffer = false;
                        // Not saving, give the other threads some time back.
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    // wait a bit before checking again to see if saving is on
                    Thread.Sleep(10);
                }
            }

            m_saveThreadExited.Set();
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            m_camera.StartCapture();

            m_grabImages = true;

            StartGrabLoop();

            toolStripButtonStart.Enabled = false;
            toolStripButtonStop.Enabled = true;
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            m_grabImages = false;

            try
            {
                m_camera.StopCapture();
            }
            catch (FC2Exception ex)
            {
                Debug.WriteLine("Failed to stop camera: " + ex.Message);
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("Camera is null");
            }

            toolStripButtonStart.Enabled = true;
            toolStripButtonStop.Enabled = false;
        }

        private void toolStripButtonCameraControl_Click(object sender, EventArgs e)
        {
            if (m_camCtlDlg.IsVisible())
            {
                m_camCtlDlg.Hide();
                toolStripButtonCameraControl.Checked = false;
            }
            else
            {
                m_camCtlDlg.Show();
                toolStripButtonCameraControl.Checked = true;
            }
        }

        private void OnNewCameraClick(object sender, EventArgs e)
        {
            if (m_grabImages == true)
            {
                toolStripButtonStop_Click(sender, e);
                m_camCtlDlg.Hide();
                m_camCtlDlg.Disconnect();
                m_camera.Disconnect();
            }
            
            Form1_Load(sender, e);
        }

        private void nudBufferFrames_ValueChanged(object sender, EventArgs e)
        {
            buffersize = (int) nudBufferFrames.Value;
            // nudDelay.Maximum = (int) buffersize * 2 / 3;
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            if (recording_buffer == false)
            {
                if (new_clip)
                {
                    nudBufferFrames.Enabled = false;        // lock buffer size
                    buffer_in_framectr = 0;                 // this should already be true
                    buffer_out_framectr = 0;                // this should already be true

                    // create new clip directory
                    tstamp2 = System.DateTime.Now.Ticks;
                    System.IO.Directory.CreateDirectory(String.Format("c:\\tmp\\clip{0}", tstamp2));

                    // create placeholder image for saving
                    recx = m_rawImage.rows;
                    recy = m_rawImage.cols;
                    recformat = m_rawImage.pixelFormat;
                    m_saveImageCont = new ManagedImage(recx, recy, recformat);

                    new_clip = false;
                }
                btnClear.Enabled = false;
                recording_buffer = true;
                btnStart.Text = "STOP";
            }
            else
            {
                recording_buffer = false;
                btnStart.Text = "START";
                btnClear.Enabled = true;
            }
        }

        // Deprecated save function. Use the SaveLoop thread instead!
        /* 
        private void btnSave_Click(object sender, EventArgs e)
        {
            int save_framectr = 0;
            int offset_framectr = 0;
            ManagedImage m_save_image;

            long tstamp = System.DateTime.Now.Ticks;

            System.IO.Directory.CreateDirectory(String.Format("c:\\tmp\\clip{0}", tstamp));

            switch (cmbFormat.SelectedIndex)
            {
                case 0:
                    ManagedImage.defaultColorProcessingAlgorithm = ColorProcessingAlgorithm.IPP;

                    m_save_image = new ManagedImage(recx, recy, PixelFormat.PixelFormatBgr);

                    for (save_framectr = 0; save_framectr < buffersize; save_framectr++)
                    {
                        // Calculate the offset frame counter based on the current position in the circular buffer.
                        offset_framectr = (save_framectr + buffer_in_framectr) % buffersize;
                        
                        framebuffer[offset_framectr].Convert(PixelFormat.PixelFormatBgr, m_save_image);
                        m_save_image.Save(String.Format("c:\\tmp\\clip{0}\\img{1:D4}.jpg", tstamp, save_framectr), ImageFileFormat.Jpeg);
                        framebuffer[offset_framectr].ReleaseBuffer();
                    }

                    ManagedImage.defaultColorProcessingAlgorithm = ColorProcessingAlgorithm.NearestNeighbor;
                    break;
                case 1:
                    ManagedImage.defaultColorProcessingAlgorithm = ColorProcessingAlgorithm.IPP;

                    m_save_image = new ManagedImage(recx, recy, PixelFormat.PixelFormatBgr);

                    for (save_framectr = 0; save_framectr < buffersize; save_framectr++)
                    {
                        // Calculate the offset frame counter based on the current position in the circular buffer.
                        offset_framectr = (save_framectr + buffer_in_framectr) % buffersize;

                        framebuffer[offset_framectr].Convert(PixelFormat.PixelFormatBgr, m_save_image);
                        m_save_image.Save(String.Format("c:\\tmp\\clip{0}\\img{1:D4}.bmp", tstamp, save_framectr), ImageFileFormat.Bmp);
                        framebuffer[offset_framectr].ReleaseBuffer();
                    }

                    ManagedImage.defaultColorProcessingAlgorithm = ColorProcessingAlgorithm.NearestNeighbor;
                    break;
                case 2:
                    for (save_framectr = 0; save_framectr < buffersize; save_framectr++)
                    {
                        // Calculate the offset frame counter based on the current position in the circular buffer.
                        offset_framectr = (save_framectr + buffer_in_framectr) % buffersize;

                        framebuffer[offset_framectr].Save(String.Format("c:\\tmp\\clip{0}\\img{1:D4}.raw", tstamp, save_framectr), ImageFileFormat.Raw);
                        framebuffer[offset_framectr].ReleaseBuffer();
                    }
                    break;
                default:
                    break;
            }
            
        }
        */

        private void rdoCont_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoOneShot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if((recording_buffer) || (saving_buffer))
            {
                MessageBox.Show("Buffer operation in progress!");
                return;
            }

            // Clear the frame buffer to free up its memory. Is this okay?
            // framebuffer = null;
            // first_time = true;

            // Reset both the input and the output buffer indices to zero.
            buffer_in_framectr = 0;
            buffer_out_framectr = 0;

            // Enable one-shot mode.
            nudBufferFrames.Enabled = true;
            frame_div_ctr = 0;
            new_clip = true;
            
        }

        private void chkContSave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nudDiv_ValueChanged(object sender, EventArgs e)
        {
            swapChain.SetFullScreenState(true, null);
        }

        private void btn150fps_Click(object sender, EventArgs e)
        {
            setFrameRate(150.0F);
        }

        private void btn144fps_Click(object sender, EventArgs e)
        {
            setFrameRate(144.0F);   
        }

        private void setFrameRate(float fr)
        {
            // Update frame rate.
            CameraProperty cpFrameRate;
            cpFrameRate = m_camera.GetProperty(PropertyType.FrameRate);
            cpFrameRate.absControl = true;
            cpFrameRate.autoManualMode = false;
            cpFrameRate.absValue = fr;
            m_camera.SetProperty(cpFrameRate);

            // Validate and display frame rate.
            cpFrameRate = m_camera.GetProperty(PropertyType.FrameRate);
            lblFPSd.Text = String.Format("{0:D}FPS", (uint)cpFrameRate.absValue);

            // Set shutter.
            setShutter(shutter_div);

        }

        private void setGain(float gain)
        {
            // Update gain.
            CameraProperty cpGain;
            cpGain = m_camera.GetProperty(PropertyType.Gain);
            cpGain.absControl = true;
            cpGain.autoManualMode = false;
            cpGain.absValue = gain;
            m_camera.SetProperty(cpGain);

            // Validate and display gain.
            cpGain= m_camera.GetProperty(PropertyType.Gain);
            lblGaind.Text = String.Format("+{0:F0}dB", cpGain.absValue);

            // Fire histogram.
            chkHistOn.Checked = true;
        }

        private void setShutter(float shutter_div)
        {
            // Update shutter.
            CameraProperty cpShutter;
            CameraProperty cpFrameRate;
            cpShutter = m_camera.GetProperty(PropertyType.Shutter);
            cpFrameRate = m_camera.GetProperty(PropertyType.FrameRate);
            cpShutter.absControl = true;
            cpShutter.autoManualMode = false;
            cpShutter.absValue = 1000.0F / (shutter_div * cpFrameRate.absValue);
            m_camera.SetProperty(cpShutter);

            // Validate and display shutter.
            cpShutter = m_camera.GetProperty(PropertyType.Shutter);
            cpFrameRate = m_camera.GetProperty(PropertyType.FrameRate);
            if (shutter_mode == SHUTTER_ANGLE)
            {
                lblShutterd.Text = String.Format("{0:F1}º", cpShutter.absValue * cpFrameRate.absValue * 0.3600F);
            }
            else if (shutter_mode == SHUTTER_TIME)
            {
                lblShutterd.Text = String.Format("1/{0:F0}s", cpFrameRate.absValue * shutter_div);
            }

            // Fire histogram.
            chkHistOn.Checked = true;
        }

        private void setWB()
        {
            // Update white balance.
            CameraProperty cpWhiteBalance;
            cpWhiteBalance = m_camera.GetProperty(PropertyType.WhiteBalance);
            cpWhiteBalance.autoManualMode = false;
            cpWhiteBalance.valueA = wb_red;
            cpWhiteBalance.valueB = wb_blue;
            m_camera.SetProperty(cpWhiteBalance);

            // Validate and display gain.
            cpWhiteBalance = m_camera.GetProperty(PropertyType.WhiteBalance);
            lblRedd.Text = String.Format("R {0:F1}%", ((float) cpWhiteBalance.valueA - 512.0F) / 5.120F);
            lblBlued.Text = String.Format("B {0:F1}%", ((float) cpWhiteBalance.valueB - 512.0F) / 5.120F);

            // Fire histogram.
            chkHistOn.Checked = true;
        }

        private void btn120fps_Click(object sender, EventArgs e)
        {
            setFrameRate(120.0F); 
        }

        private void btn96fps_Click(object sender, EventArgs e)
        {
            setFrameRate(96.0F); 
        }

        private void btn90fps_Click(object sender, EventArgs e)
        {
            setFrameRate(90.0F); 
        }

        private void btn72fps_Click(object sender, EventArgs e)
        {
            setFrameRate(72.0F);
        }

        private void btn60fps_Click(object sender, EventArgs e)
        {
            setFrameRate(60.0F);
        }

        private void btn48fps_Click(object sender, EventArgs e)
        {
            setFrameRate(48.0F);
        }

        private void btn30fps_Click(object sender, EventArgs e)
        {
            setFrameRate(30.0F);
        }

        private void btn24fps_Click(object sender, EventArgs e)
        {
            setFrameRate(24.0F);
        }

        private void btn240fps_Click(object sender, EventArgs e)
        {
            setFrameRate(240.0F);
        }

        private void btn8bit_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera) m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.mode = Mode.Mode0;
            f7Settings.pixelFormat = PixelFormat.PixelFormatRaw8;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        private void btn12bit_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.mode = Mode.Mode7;
            f7Settings.pixelFormat = PixelFormat.PixelFormatRaw12;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        // GS3-U3-89S6C-C 4K
        private void btn3840x2160_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.width = 3840;
            f7Settings.height = 2160;
            f7Settings.offsetX = 128;
            f7Settings.offsetY = 0;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        private void btn1920x1200_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.width = 1920;
            f7Settings.height = 1200;
            f7Settings.offsetX = 0;
            f7Settings.offsetY = 0;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        private void btn1920x1080_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.width = 1920;
            f7Settings.height = 1080;
            f7Settings.offsetX = 0;
            f7Settings.offsetY = 60;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        private void btn1280x720_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.width = 1280;
            f7Settings.height = 720;
            f7Settings.offsetX = 320;
            f7Settings.offsetY = 240;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        private void btn854x480_Click(object sender, EventArgs e)
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);
            f7Settings.width = 864;
            f7Settings.height = 480;
            f7Settings.offsetX = 528;
            f7Settings.offsetY = 360;
            local_m_camera.SetFormat7Configuration(f7Settings, bus_percent);
            displayF7Settings();
        }

        private void btn360fps_Click(object sender, EventArgs e)
        {
            setFrameRate(360.0F);
        }

        private void displayF7Settings()
        {
            ManagedCamera local_m_camera = (ManagedCamera)m_camera;
            Format7ImageSettings f7Settings;
            f7Settings = new Format7ImageSettings();
            uint packetsize = 0;
            float speed = 0.0F;
            local_m_camera.GetFormat7Configuration(f7Settings, ref packetsize, ref speed);

            lblPXd.Text = String.Format("{0:D}x{1:D}", f7Settings.width, f7Settings.height);
            if (f7Settings.pixelFormat == PixelFormat.PixelFormatRaw8)
            {
                lblBITd.Text = "8-bit";
            }
            else if (f7Settings.pixelFormat == PixelFormat.PixelFormatRaw12)
            {
                lblBITd.Text = "12-bit";
            }
            else
            {
                lblBITd.Text = "ERROR";
            }
        }

        private void btnBusUp_Click(object sender, EventArgs e)
        {
            if (bus_percent < 99.0F)
            {
                bus_percent += 1.0F;
            }
            else
            {
                bus_percent = 100.0F;
            }
            lblBusd.Text = String.Format("{0:F0}% bus", bus_percent);
        }

        private void btnBusDown_Click(object sender, EventArgs e)
        {
            if (bus_percent > 1.0F)
            {
                bus_percent -= 1.0F;
            }
            else
            {
                bus_percent = 0.0F;
            }
            lblBusd.Text = String.Format("{0:F0}% Bus", bus_percent);
        }

        private void btnGainUp_Click(object sender, EventArgs e)
        {
            if (gain < 23.0F)
            {
                gain += 1.0F;
            }
            else
            {
                gain = 24.0F;
            }
            setGain(gain);
        }

        private void btnGainDown_Click(object sender, EventArgs e)
        {
            if (gain > 1.0F)
            {
                gain -= 1.0F;
            }
            else
            {
                gain = 0.0F;
            }
            setGain(gain);
        }

        private void btnShutterUp_Click(object sender, EventArgs e)
        {
            if (shutter_div > 2.0F)
            {
                shutter_div -= 1.0F;
            }
            else
            {
                shutter_div = 1.0F;
            }
            setShutter(shutter_div);
        }

        private void btnShutterDown_Click(object sender, EventArgs e)
        {
            if (shutter_div < 99.0F)
            {
                shutter_div += 1.0F;
            }
            else
            {
                shutter_div = 100.0F;
            }
            setShutter(shutter_div);
        }

        private void rdoShutterTime_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoShutterTime.Checked == true)
            {
                shutter_mode = SHUTTER_TIME;
            }
            setShutter(shutter_div);
        }

        private void rdoShutterAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoShutterAngle.Checked == true)
            {
                shutter_mode = SHUTTER_ANGLE;
            }
            setShutter(shutter_div);
        }

        private void btnBlueUp_Click(object sender, EventArgs e)
        {
            if (wb_blue < 1022)
            {
                wb_blue += 1;
            }
            setWB();
        }

        private void btnBlueDown_Click(object sender, EventArgs e)
        {
            if (wb_blue > 0)
            {
                wb_blue -= 1;
            }
            setWB();
        }

        private void btnRedDown_Click(object sender, EventArgs e)
        {
            if (wb_red > 0)
            {
                wb_red -= 1;
            }
            setWB();
        }

        private void btnRedUp_Click(object sender, EventArgs e)
        {
            if (wb_red < 1022)
            {
                wb_red += 1;
            }
            setWB();
        }

        private void btnBlueDownDown_Click(object sender, EventArgs e)
        {
            if (wb_blue > 10)
            {
                wb_blue -= 10;
            }
            else
            {
                wb_blue = 0;
            }
            setWB();
        }

        private void btnBlueUpUp_Click(object sender, EventArgs e)
        {
            if (wb_blue < 1013)
            {
                wb_blue += 10;
            }
            else
            {
                wb_blue = 1023;
            }
            setWB();
        }

        private void btnRedDownDown_Click(object sender, EventArgs e)
        {
            if (wb_red > 10)
            {
                wb_red -= 10;
            }
            else
            {
                wb_red = 0;
            }
            setWB();
        }

        private void btnRedUpUp_Click(object sender, EventArgs e)
        {
            if (wb_red < 1013)
            {
                wb_red += 10;
            }
            else
            {
                wb_red = 1023;
            }
            setWB();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            // White balance or zoom in.
            if ((bigPreview == false) && (chkWBSpot.Checked == true))
            {

                int red_error = 0;
                int blue_error = 0;
                int green_error = 0;

                float wb_redf = (float) wb_red;
                float wb_bluef = (float) wb_blue;

                SlimDX.Direct3D11.Texture2D texWB;
                System.IO.MemoryStream streamWB = new System.IO.MemoryStream();
                Bitmap bmpWB;

                texWB = SlimDX.Direct3D11.Resource.FromSwapChain<SlimDX.Direct3D11.Texture2D>(swapChain, 0);
                SlimDX.Direct3D11.Texture2D.ToStream(context, texWB, SlimDX.Direct3D11.ImageFileFormat.Bmp, streamWB);
                bmpWB = (Bitmap) Bitmap.FromStream(streamWB);    

                red_error = 255 - bmpWB.GetPixel(e.X*3/2, e.Y*3/2).R;
                green_error = 255 - bmpWB.GetPixel(e.X*3/2, e.Y*3/2).G;
                blue_error = 255 - bmpWB.GetPixel(e.X*3/2, e.Y*3/2).B;

                streamWB.Dispose();
                texWB.Dispose();
                bmpWB.Dispose();

                wb_bluef += 2.0F * ((float)blue_error - 1.0F * (float)green_error);
                wb_redf += 2.0F * ((float)red_error - 1.0F * (float)green_error);

                if (wb_bluef > 1023.0F) { wb_bluef = 1023.0F; }
                else if (wb_bluef < 0.0F) { wb_bluef = 0.0F; }

                if (wb_redf > 1023.0F) { wb_redf = 1023.0F; }
                else if (wb_redf < 0.0F) { wb_redf = 0.0F; }

                wb_blue = (uint)wb_bluef;
                wb_red = (uint)wb_redf;

                setWB();
            }
            else
            {
                // Request a switch between big and little preview mode on the next renderRaw().
                bigPreviewToggle = true;
            }
            
        }

        private void configRawInDevice()
        {
            // Set up the DirectX rendering device for hardware-accelerated image preview.

            // Set the default input image size.
            viewport_w = pictureBox1.Width;
            viewport_h = pictureBox1.Height;

            // Create a device, swapchain, and viewport for pbRawIn
            description = new SlimDX.DXGI.SwapChainDescription();
            description.BufferCount = 1;
            description.Usage = SlimDX.DXGI.Usage.RenderTargetOutput;
            description.OutputHandle = pictureBox1.Handle;
            description.IsWindowed = true;
            description.ModeDescription = new SlimDX.DXGI.ModeDescription(0, 0, new SlimDX.Rational(60, 1), SlimDX.DXGI.Format.R8G8B8A8_UNorm);
            description.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            description.Flags = SlimDX.DXGI.SwapChainFlags.AllowModeSwitch;
            description.SwapEffect = SlimDX.DXGI.SwapEffect.Discard;

            SlimDX.Direct3D11.Device.CreateWithSwapChain(SlimDX.Direct3D11.DriverType.Hardware, SlimDX.Direct3D11.DeviceCreationFlags.None, description, out device, out swapChain);
            context = device.ImmediateContext;
            factory = swapChain.GetParent<SlimDX.DXGI.Factory>();
            factory.SetWindowAssociation(this.Handle, SlimDX.DXGI.WindowAssociationFlags.IgnoreAltEnter);

            // Create textures to use for the color processing pipeline:
            SlimDX.Direct3D11.Texture2DDescription texDesc;

            // tex8: Texture for raw 8-bit values from the sensor. Stored in a normal 8 bit per pixel format.
            texDesc = new SlimDX.Direct3D11.Texture2DDescription();
            texDesc.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            texDesc.Width = (int) max_recx;
            texDesc.Height = (int) max_recy;
            texDesc.MipLevels = 1;
            texDesc.ArraySize = 1;
            texDesc.Format = SlimDX.DXGI.Format.R8_UNorm;
            texDesc.Usage = SlimDX.Direct3D11.ResourceUsage.Dynamic;
            texDesc.BindFlags = SlimDX.Direct3D11.BindFlags.ShaderResource;
            texDesc.CpuAccessFlags = SlimDX.Direct3D11.CpuAccessFlags.Write;
            tex8 = new SlimDX.Direct3D11.Texture2D(device, texDesc);

            // tex12: Texture for raw 12-bit values from the sensor. Stored in 8-pixel chunks to be sorted out by the shader.
            texDesc = new SlimDX.Direct3D11.Texture2DDescription();
            texDesc.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            texDesc.Width = (int) (max_recx / 8);
            texDesc.Height = (int) max_recy;
            texDesc.MipLevels = 1;
            texDesc.ArraySize = 1;
            texDesc.Format = SlimDX.DXGI.Format.R32G32B32_UInt;
            texDesc.Usage = SlimDX.Direct3D11.ResourceUsage.Dynamic;
            texDesc.BindFlags = SlimDX.Direct3D11.BindFlags.ShaderResource;
            texDesc.CpuAccessFlags = SlimDX.Direct3D11.CpuAccessFlags.Write;
            tex12 = new SlimDX.Direct3D11.Texture2D(device, texDesc);

            // tex: The input texture, into which raw (Bayer-masked) luminance values are loaded.
            texDesc = new SlimDX.Direct3D11.Texture2DDescription();
            texDesc.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            texDesc.Width = (int) max_recx;
            texDesc.Height = (int) max_recy;
            texDesc.MipLevels = 1;
            texDesc.ArraySize = 1;
            texDesc.Format = SlimDX.DXGI.Format.R16_UNorm;
            texDesc.Usage = SlimDX.Direct3D11.ResourceUsage.Default;
            texDesc.BindFlags = SlimDX.Direct3D11.BindFlags.RenderTarget | SlimDX.Direct3D11.BindFlags.ShaderResource;
            texDesc.CpuAccessFlags = SlimDX.Direct3D11.CpuAccessFlags.None;
            tex = new SlimDX.Direct3D11.Texture2D(device, texDesc);

            // tex: The input texture, into which raw (Bayer-masked) luminance values are loaded.
            texDesc = new SlimDX.Direct3D11.Texture2DDescription();
            texDesc.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            texDesc.Width = (int)max_recx;
            texDesc.Height = (int)max_recy;
            texDesc.MipLevels = 1;
            texDesc.ArraySize = 1;
            texDesc.Format = SlimDX.DXGI.Format.R16_UNorm;
            texDesc.Usage = SlimDX.Direct3D11.ResourceUsage.Default;
            texDesc.BindFlags = SlimDX.Direct3D11.BindFlags.RenderTarget | SlimDX.Direct3D11.BindFlags.ShaderResource;
            texDesc.CpuAccessFlags = SlimDX.Direct3D11.CpuAccessFlags.None;
            tex = new SlimDX.Direct3D11.Texture2D(device, texDesc);

            // tex_convolve: The second-pass input texture, which gets a copy of tex_debayered.
            texDesc = new SlimDX.Direct3D11.Texture2DDescription();
            texDesc.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            texDesc.Width = (int) max_recx;
            texDesc.Height = (int) max_recy;
            texDesc.MipLevels = 1;
            texDesc.ArraySize = 1;
            texDesc.Format = SlimDX.DXGI.Format.R32G32B32A32_Float;
            texDesc.Usage = SlimDX.Direct3D11.ResourceUsage.Default;
            texDesc.BindFlags = SlimDX.Direct3D11.BindFlags.RenderTarget | SlimDX.Direct3D11.BindFlags.ShaderResource;
            texDesc.CpuAccessFlags = SlimDX.Direct3D11.CpuAccessFlags.None;
            tex_convolve = new SlimDX.Direct3D11.Texture2D(device, texDesc);

            // tex_dummy: A dummy texture used to unbind other textures.
            texDesc = new SlimDX.Direct3D11.Texture2DDescription();
            texDesc.SampleDescription = new SlimDX.DXGI.SampleDescription(1, 0);
            texDesc.Width = (int)max_recx;
            texDesc.Height = (int)max_recy;
            texDesc.MipLevels = 1;
            texDesc.ArraySize = 1;
            texDesc.Format = SlimDX.DXGI.Format.R32G32B32A32_Float;
            texDesc.Usage = SlimDX.Direct3D11.ResourceUsage.Default;
            texDesc.BindFlags = SlimDX.Direct3D11.BindFlags.RenderTarget | SlimDX.Direct3D11.BindFlags.ShaderResource;
            texDesc.CpuAccessFlags = SlimDX.Direct3D11.CpuAccessFlags.None;
            tex_dummy = new SlimDX.Direct3D11.Texture2D(device, texDesc);

            // Create a DirectX viewport and a quad to texture:
            vertices = new SlimDX.DataStream(20 * 4, true, true);
            vertices.Write(new SlimDX.Vector3(-1.0f, -1.0f, 0.5f));
            vertices.Write(new SlimDX.Vector2(0.0f, 1.0f));
            vertices.Write(new SlimDX.Vector3(-1.0f, 1.0f, 0.5f));
            vertices.Write(new SlimDX.Vector2(0.0f, 0.0f));
            vertices.Write(new SlimDX.Vector3(1.0f, -1.0f, 0.5f));
            vertices.Write(new SlimDX.Vector2(1.0f, 1.0f));
            vertices.Write(new SlimDX.Vector3(1.0f, 1.0f, 0.5f));
            vertices.Write(new SlimDX.Vector2(1.0f, 0.0f));
            vertices.Position = 0;

            vertexBuffer = new SlimDX.Direct3D11.Buffer(device, vertices, 20 * 4, SlimDX.Direct3D11.ResourceUsage.Default, SlimDX.Direct3D11.BindFlags.VertexBuffer, SlimDX.Direct3D11.CpuAccessFlags.None, SlimDX.Direct3D11.ResourceOptionFlags.None, 0);

            // effectbytecode = SlimDX.D3DCompiler.ShaderBytecode.CompileFromFile("debayercolor.fx", "Render", "fx_5_0", SlimDX.D3DCompiler.ShaderFlags.None, SlimDX.D3DCompiler.EffectFlags.None);
            // effect = new SlimDX.Direct3D11.Effect(device, effectbytecode);

            samplerDescription = new SlimDX.Direct3D11.SamplerDescription();
            samplerDescription.AddressU = SlimDX.Direct3D11.TextureAddressMode.Mirror;
            samplerDescription.AddressV = SlimDX.Direct3D11.TextureAddressMode.Mirror;
            samplerDescription.AddressW = SlimDX.Direct3D11.TextureAddressMode.Mirror;
            samplerDescription.Filter = SlimDX.Direct3D11.Filter.MinMagMipPoint;

            samplerState = SlimDX.Direct3D11.SamplerState.FromDescription(device, samplerDescription);

            vsbytecode = SlimDX.D3DCompiler.ShaderBytecode.CompileFromFile("debayercolor.fx", "vs_main", "vs_4_0", SlimDX.D3DCompiler.ShaderFlags.None, SlimDX.D3DCompiler.EffectFlags.None);
            vertexShader = new SlimDX.Direct3D11.VertexShader(device, vsbytecode);

            psbytecode = SlimDX.D3DCompiler.ShaderBytecode.CompileFromFile("debayercolor.fx", "ps_8toFloat", "ps_4_0", SlimDX.D3DCompiler.ShaderFlags.None, SlimDX.D3DCompiler.EffectFlags.None);
            pixelShader0x8 = new SlimDX.Direct3D11.PixelShader(device, psbytecode);

            psbytecode = SlimDX.D3DCompiler.ShaderBytecode.CompileFromFile("debayercolor.fx", "ps_12toFloat", "ps_4_0", SlimDX.D3DCompiler.ShaderFlags.None, SlimDX.D3DCompiler.EffectFlags.None);
            pixelShader0x12 = new SlimDX.Direct3D11.PixelShader(device, psbytecode);

            psbytecode = SlimDX.D3DCompiler.ShaderBytecode.CompileFromFile("debayercolor.fx", "ps_debayer", "ps_4_0", SlimDX.D3DCompiler.ShaderFlags.None, SlimDX.D3DCompiler.EffectFlags.None);
            pixelShader1 = new SlimDX.Direct3D11.PixelShader(device, psbytecode);

            psbytecode = SlimDX.D3DCompiler.ShaderBytecode.CompileFromFile("debayercolor.fx", "ps_convolve", "ps_4_0", SlimDX.D3DCompiler.ShaderFlags.None, SlimDX.D3DCompiler.EffectFlags.None);
            pixelShader2 = new SlimDX.Direct3D11.PixelShader(device, psbytecode);

            elements[0] = new SlimDX.Direct3D11.InputElement("POSITION", 0, SlimDX.DXGI.Format.R32G32B32_Float, 0);
            elements[1] = new SlimDX.Direct3D11.InputElement("textcoord", 0, SlimDX.DXGI.Format.R32G32_Float, 12, 0);
            layout1 = new SlimDX.Direct3D11.InputLayout(device, SlimDX.D3DCompiler.ShaderSignature.GetInputSignature(vsbytecode), elements);

            context.InputAssembler.InputLayout = layout1;
            context.InputAssembler.PrimitiveTopology = SlimDX.Direct3D11.PrimitiveTopology.TriangleStrip;
            context.InputAssembler.SetVertexBuffers(0, new SlimDX.Direct3D11.VertexBufferBinding(vertexBuffer, 20, 0));

            context.VertexShader.Set(vertexShader);
            context.PixelShader.Set(pixelShader1);

            // Set up the (empty) constant buffer structure the first time through.
            bufferdata.Position = 0;
            constantBuffer = new SlimDX.Direct3D11.Buffer(device, bufferdata, 160, SlimDX.Direct3D11.ResourceUsage.Dynamic, SlimDX.Direct3D11.BindFlags.ConstantBuffer, SlimDX.Direct3D11.CpuAccessFlags.Write, SlimDX.Direct3D11.ResourceOptionFlags.None, 4);
            context.PixelShader.SetConstantBuffer(constantBuffer, 0);

            // Bind textures to their slots. Only need to do this once. Updates down with CopyResource() or MapSubresource().
            resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex8);
            context.PixelShader.SetShaderResource(resourceView, 0);

            resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex12);
            context.PixelShader.SetShaderResource(resourceView, 1);

            // Don't bind the texture SRVs to their PS yet, so they can be used as RTs first.

            // resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex);
            // context.PixelShader.SetShaderResource(resourceView, 2);

            // resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex_convolve);
            // context.PixelShader.SetShaderResource(resourceView, 3);

            resourceView.Dispose();

        }

        unsafe private void renderRaw()
        {
            // Direct accelerated preview of raw image from the camera.
            IntPtr ptrRawData;
            DataBox texData;

            int x = 0;
            int y = 0;

            UInt32 px12;
            UInt32 px1;
            UInt32 px2;

            int prevx = (int)m_processedImage.cols;
            int prevy = (int)m_processedImage.rows;

            int convx;
            int convy;

            // Don't allow nested calls to renderRaw()
            if (renderBusy == true)
            {
                return;
            }

            // Block calls to renderRaw and clear the renderRaw flag.
            renderBusy = true;

            constantBufferData = context.MapSubresource(constantBuffer, SlimDX.Direct3D11.MapMode.WriteDiscard, SlimDX.Direct3D11.MapFlags.None);
            constantBufferData.Data.Write(new Vector2(max_recx, max_recy));

            float k_sharp = 0.0f;

            if (chkRaw.Checked == true)
            {
                constantBufferData.Data.Write<float>(1.0f);                          // Gamma
                constantBufferData.Data.Write<float>(1.0f);                          // Brightness
                constantBufferData.Data.Write<float>(1.0f);                          // Contrast
                constantBufferData.Data.Write<float>(0.0f);                          // Red White Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Green White Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Blue White Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Red Black Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Green Black Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Blue Black Adjust
                constantBufferData.Data.Write<float>(1.0f);                          // Saturation Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Hue Adjust
            }
            else
            {
                constantBufferData.Data.Write<float>((float)nudGamma.Value);         // Gamma
                constantBufferData.Data.Write<float>((float)nudBrightness.Value);    // Brightness
                constantBufferData.Data.Write<float>((float)nudContrast.Value);      // Contrast
                constantBufferData.Data.Write<float>(0.0f);                          // Red White Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Green White Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Blue White Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Red Black Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Green Black Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Blue Black Adjust
                constantBufferData.Data.Write<float>((float)nudSaturation.Value);    // Saturation Adjust
                constantBufferData.Data.Write<float>(0.0f);                          // Hue Adjust

                k_sharp = (float)nudSharpness.Value - 1.0f;
            }

            // Set default convolution matrix to a 3x3 sharpen kernel:
            conv[0, 0] = k_sharp * 0.0f;
            conv[0, 1] = k_sharp * 0.0f;
            conv[0, 2] = k_sharp * 0.0f;
            conv[0, 3] = k_sharp * 0.0f;
            conv[0, 4] = k_sharp * 0.0f;

            conv[1, 0] = k_sharp * 0.0f;
            conv[1, 1] = k_sharp * -1.0f;
            conv[1, 2] = k_sharp * -1.0f;
            conv[1, 3] = k_sharp * -1.0f;
            conv[1, 4] = k_sharp * 0.0f;

            conv[2, 0] = k_sharp * 0.0f;
            conv[2, 1] = k_sharp * -1.0f;
            conv[2, 2] = k_sharp * 8.0f + 1.0f;
            conv[2, 3] = k_sharp * -1.0f;
            conv[2, 4] = k_sharp * 0.0f;

            conv[3, 0] = k_sharp * 0.0f;
            conv[3, 1] = k_sharp * -1.0f;
            conv[3, 2] = k_sharp * -1.0f;
            conv[3, 3] = k_sharp * -1.0f;
            conv[3, 4] = k_sharp * 0.0f;

            conv[4, 0] = k_sharp * 0.0f;
            conv[4, 1] = k_sharp * 0.0f;
            conv[4, 2] = k_sharp * 0.0f;
            conv[4, 3] = k_sharp * 0.0f;
            conv[4, 4] = k_sharp * 0.0f;

            for (convy = 0; convy <= 4; convy++)
            {
                for (convx = 0; convx <= 4; convx++)
                {
                    constantBufferData.Data.Write<float>(conv[convy, convx]);    // convolution matrix
                }
            }

            if (chkClip.Checked == true)
            {
                constantBufferData.Data.Write<uint>(1);                  // Show saturation by inverting pixels.
            }
            else
            {
                constantBufferData.Data.Write<uint>(0);                  // Don't show saturation by inverting pixels.
            }

            context.UnmapSubresource(constantBuffer, 0);

            // Next, load the raw image data into a texture.

            // Get a pointer to the start of the raw image data (requires unsafe context).
            ptrRawData = (IntPtr) m_processedImage.data;

            if(ptrRawData == null)
            {
                // Image is not ready, abort.
                return;
            }

            // Deprecated copy method using unsafe pointer operation.
            /*
            if (m_processedImage.pixelFormat == PixelFormat.PixelFormatRaw12)
            {
                // Load 12-bit raw image.
                // First, capture the luminance of each raw pixel directly.
                for (y = 0; y < prevy; y++)
                {
                    for (x = 0; x < prevx; x += 2)
                    {

                        px12 = (((uint)*ptrRawData++) << 16);
                        px12 += (((uint)*ptrRawData++) << 8);
                        px12 += ((uint)*ptrRawData++);


                        px1 = (((px12 >> 16) & 0xFF) << 4) + ((px12 >> 8) & 0x0F);
                        px2 = (((px12 >> 0) & 0xFF) << 4) + ((px12 >> 12) & 0x0F);

                        lumbyte[y * 2 * prevx + 2 * x + 3] = (byte)((px2 >> 4) & 0xFF);
                        lumbyte[y * 2 * prevx + 2 * x + 2] = (byte)((px2 << 4) & 0xFF);
                        lumbyte[y * 2 * prevx + 2 * x + 1] = (byte)((px1 >> 4) & 0xFF);
                        lumbyte[y * 2 * prevx + 2 * x + 0] = (byte)((px1 << 4) & 0xFF);

                    }
                }
            }
            // else if (m_processedImage.pixelFormat == PixelFormat.PixelFormatRaw8)
            else if (m_processedImage.pixelFormat == PixelFormat.PixelFormatRaw8)
            {
                // Load 8-bit raw image.
                // First, capture the luminance of each raw pixel directly.
                for (y = 0; y < prevy; y++)
                {
                    for (x = 0; x < prevx; x++)
                    {
                        px1 = (uint)*ptrRawData++;

                        lumbyte[y * 2 * prevx + 2 * x + 0] = 0;
                        lumbyte[y * 2 * prevx + 2 * x + 1] = (byte)(px1 & 0xFF);

                    }
                }

            }
            else
            {
                // MessageBox.Show("Pixel fromat not supported for hardware-accelerated preview.");
            }
            */

            // Pass 0: Convert 8-bit unsigned to float texture.
            if (m_processedImage.pixelFormat == PixelFormat.PixelFormatRaw8)
            {
                System.Runtime.InteropServices.Marshal.Copy(ptrRawData, lumbyte, 0, (int)(prevx * prevy));
                context.PixelShader.Set(pixelShader0x8);

                // Fill the texture with rgba values:
                texData = context.MapSubresource(tex8, 0, 0, SlimDX.Direct3D11.MapMode.WriteDiscard, SlimDX.Direct3D11.MapFlags.None);
                
                if (texData.Data.CanWrite)
                {
                    // Must scan through row by row since the DataBox rows might be padded.
                    for (y = 0; y < prevy; y++)
                    {
                        texData.Data.Seek(y * texData.RowPitch, System.IO.SeekOrigin.Begin);
                        texData.Data.Write(lumbyte, (int)(y * prevx), (int)(prevx));
                    }
                }
                context.UnmapSubresource(tex8, 0);
                texData.Data.Dispose();
            }
            else if (m_processedImage.pixelFormat == PixelFormat.PixelFormatRaw12)
            {
                System.Runtime.InteropServices.Marshal.Copy(ptrRawData, lumbyte, 0, (int)(prevx * prevy * 3 / 2));
                context.PixelShader.Set(pixelShader0x12);

                // Fill the texture with rgba values:
                texData = context.MapSubresource(tex12, 0, 0, SlimDX.Direct3D11.MapMode.WriteDiscard, SlimDX.Direct3D11.MapFlags.None);

                if (texData.Data.CanWrite)
                {
                    // Must scan through row by row since the DataBox rows might be padded.
                    for (y = 0; y < prevy; y++)
                    {
                        texData.Data.Seek(y * texData.RowPitch, System.IO.SeekOrigin.Begin);
                        texData.Data.Write(lumbyte, (int)(y * prevx * 3 / 2), (int)(prevx * 3 / 2));
                    }
                }
                context.UnmapSubresource(tex12, 0);
                texData.Data.Dispose();
            }

            renderTarget = new SlimDX.Direct3D11.RenderTargetView(device, tex);
            context.OutputMerger.SetTargets(renderTarget);

            viewport = new SlimDX.Direct3D11.Viewport(0.0f, 0.0f, max_recx, max_recy);
            context.Rasterizer.SetViewports(viewport);
            
            context.Draw(4, 0);

            // Adjust the swapchain buffer size if the preview size has been changed:
            /*
            if (bigPreviewToggle)
            {
                if (bigPreview)
                {
                    swapChain.ResizeTarget(new SlimDX.DXGI.ModeDescription(4096, 2160, new SlimDX.Rational(60, 1), SlimDX.DXGI.Format.R8G8B8A8_UNorm));
                    bigPreview = false;
                }
                else
                {
                    swapChain.ResizeTarget(new SlimDX.DXGI.ModeDescription(4096, 2160, new SlimDX.Rational(60, 1), SlimDX.DXGI.Format.R8G8B8A8_UNorm));
                    bigPreview = true;
                }

                bigPreviewToggle = false;
            }
            */

            // Pass 1: Debayer and Color Correction
            context.PixelShader.Set(pixelShader1);
            context.PixelShader.SetSampler(samplerState, 0);

            // Is this step really necessary?
            // context.CopyResource(tex, tex_debayer);

            if(false)
            {
                // bypass the convolution shader to save time, just draw the debayered and color corrected image to the swapchain.
                renderTarget = new SlimDX.Direct3D11.RenderTargetView(device, SlimDX.Direct3D11.Resource.FromSwapChain<SlimDX.Direct3D11.Texture2D>(swapChain, 0));
                context.OutputMerger.SetTargets(renderTarget);

                viewport = new SlimDX.Direct3D11.Viewport(0.0f, 0.0f, 1024.0f, 540.0f);
                context.Rasterizer.SetViewports(viewport);

                context.ClearRenderTargetView(renderTarget, new Color4(0.0f, 0.0f, 0.0f));
                context.Draw(4, 0);
            }
            else
            {
                // run the convolution shader. note: may not run at 30Hz in 864x480 mode for some reason.
                renderTarget = new SlimDX.Direct3D11.RenderTargetView(device, tex_convolve);
                // renderTarget = new SlimDX.Direct3D11.RenderTargetView(device, SlimDX.Direct3D11.Resource.FromSwapChain<SlimDX.Direct3D11.Texture2D>(swapChain, 0));
                context.OutputMerger.SetTargets(renderTarget);

                resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex);
                context.PixelShader.SetShaderResource(resourceView, 2);

                viewport = new SlimDX.Direct3D11.Viewport(0.0f, 0.0f, max_recx, max_recy);
                // viewport = new SlimDX.Direct3D11.Viewport(0.0f, 0.0f, 1024.0f, 540.0f);
                context.Rasterizer.SetViewports(viewport);

                context.ClearRenderTargetView(renderTarget, new Color4(0.0f, 0.0f, 0.0f));
                context.Draw(4, 0);

                resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex_dummy);
                context.PixelShader.SetShaderResource(resourceView, 2);

                // Pass 2: Convolve
                context.PixelShader.Set(pixelShader2);
                context.PixelShader.SetSampler(samplerState, 0);
                // context.CopyResource(tex_debayered, tex_convolve);

                renderTarget = new SlimDX.Direct3D11.RenderTargetView(device, SlimDX.Direct3D11.Resource.FromSwapChain<SlimDX.Direct3D11.Texture2D>(swapChain, 0));
                context.OutputMerger.SetTargets(renderTarget);

                resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex_convolve);
                context.PixelShader.SetShaderResource(resourceView, 3);

                viewport = new SlimDX.Direct3D11.Viewport(0.0f, 0.0f, 1024.0f, 540.0f);
                context.Rasterizer.SetViewports(viewport);

                context.ClearRenderTargetView(renderTarget, new Color4(0.0f, 0.0f, 0.0f));
                context.Draw(4, 0);

                resourceView = new SlimDX.Direct3D11.ShaderResourceView(device, tex_dummy);
                context.PixelShader.SetShaderResource(resourceView, 3);

            }

            swapChain.Present(0, SlimDX.DXGI.PresentFlags.None);

            renderBusy = false;

        }

        private void btnGammaDown_Click(object sender, EventArgs e)
        {
            nudGamma.Value = nudGamma.Value - nudGamma.Increment;
        }

        private void btnGammaUp_Click(object sender, EventArgs e)
        {
            nudGamma.Value = nudGamma.Value + nudGamma.Increment;
        }

        private void btnBrightnessDown_Click(object sender, EventArgs e)
        {
            nudBrightness.Value = nudBrightness.Value - nudBrightness.Increment;
        }

        private void btnBrightnessUp_Click(object sender, EventArgs e)
        {
            nudBrightness.Value = nudBrightness.Value + nudBrightness.Increment;
        }

        private void btnContrastDown_Click(object sender, EventArgs e)
        {
            nudContrast.Value = nudContrast.Value - nudContrast.Increment;
        }

        private void btnContrastUp_Click(object sender, EventArgs e)
        {
            nudContrast.Value = nudContrast.Value + nudContrast.Increment;
        }

        private void btnSaturationDown_Click(object sender, EventArgs e)
        {
            nudSaturation.Value = nudSaturation.Value - nudSaturation.Increment;
        }

        private void btnSaturationUp_Click(object sender, EventArgs e)
        {
            nudSaturation.Value = nudSaturation.Value + nudSaturation.Increment;
        }

        private void btnSharpnessDown_Click(object sender, EventArgs e)
        {
            nudSharpness.Value = nudSharpness.Value - nudSharpness.Increment;
        }

        private void btnSharpnessUp_Click(object sender, EventArgs e)
        {
            nudSharpness.Value = nudSharpness.Value + nudSharpness.Increment;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblBufferSize_Click(object sender, EventArgs e)
        {

        }
    }
}

//=============================================================================
// $Log: not supported by cvs2svn $
// Revision 1.3  2011/02/02 17:52:47  soowei
// [1] Handle grab errors in the grab loop
//
// Revision 1.2  2011/02/02 01:20:16  soowei
// [1] Add some more information to GUI
//
// Revision 1.1  2011/02/01 23:10:35  soowei
// [1] Adding FlyCapture2SimpleGUI_CSharp example
//
//=============================================================================
