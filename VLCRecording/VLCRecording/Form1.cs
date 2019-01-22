using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace VLCRecording
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var mediaOptions = new string[]
          {
                 ":network-caching=0"
                ,":sout=#duplicate{dst=std{access=file,mux=" + "mp4" + "},dst=display}"

          };
            vlcControl1.SetMedia("rtsp://192.168.2.221:554/Onvif/live/1/1", mediaOptions);
            vlcControl1.Play();
        }

        private void btnContinousRecording_Click(object sender, EventArgs e)
        {
            Configuration();



        }

        private void Configuration()
        {
            try
            {
                var stopTime = Convert.ToInt16(txt_ContiunesRecordingMints.Text.Trim()) * 60000;
                var aTimer = new System.Timers.Timer(stopTime);
                System.Threading.ThreadPool.QueueUserWorkItem((a) =>
                {
                    string fileName = System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".mp4";
                    var mediaOptions = new string[]
                   {
                   ":network-caching=0",
                   ":sout=#duplicate{dst=std{access=file,mux=" + "mp4" + ",dst='D:\\RV"+ "\\"+ fileName + "'},dst=display}",
                   };

                    // just stream  

                    vlcControl1.Play("rtsp://192.168.2.221:554/Onvif/live/1/1", mediaOptions);
                    aTimer.Elapsed += OnTimedEvent;
                    aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Configuration();
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }
    }
}
