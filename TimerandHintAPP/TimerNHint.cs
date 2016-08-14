using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TimerandHintAPP
{
    public partial class TimerNhint : System.Windows.Forms.Form
    {
        public class UpdateHintEventArgs : EventArgs
        {
            public string xxhint { get; set; }
            public string xxstart { get; set; }
            public string xxpause { get; set; }
            public string xxresume { get; set; }
            public string xxreset { get; set; }
            public string xxAddsec { get; set; }
            public string xxAddmin { get; set; }
        }

        public event EventHandler<UpdateHintEventArgs> xxhintUpdate;
        protected virtual void oNxxhintUpdate(UpdateHintEventArgs e)
        {
            if(xxhintUpdate != null)
            {
                xxhintUpdate(this, e);
            }
        }
    
        private Timer timer1;


        public TimerNhint()
        {
            InitializeComponent();
           lb_Time.Text =  TimeSpan.FromHours(1).ToString();
            lb_Error.Text = "";

        }

        private void BUT_timerSubmit_Click(object sender, EventArgs e)
        {



            if (BUT_timerSubmit.Text == "Pause")
            {
                timer1.Stop();
                BUT_timerSubmit.Text = "Resume";
                But_Stop.Text = "Reset";

                string sohint = "Pause";
                UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                uHEA.xxpause = sohint;
                oNxxhintUpdate(uHEA);
            }
            else if(BUT_timerSubmit.Text == "Resume")
            {
                timer1.Start();
                But_Stop.Text = "Stop";
                BUT_timerSubmit.Text = "Pause";
              
                var startTime = DateTime.Now;
                string xtimer = (TimeSpan.Parse(lb_Time.Text) + TimeSpan.FromSeconds(1)).ToString("hh\\:mm\\:ss");
                timer1.Tick += (obj, args) => lb_Time.Text = (TimeSpan.Parse(xtimer) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");

                string sohint = "Resume";
                UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                uHEA.xxresume = sohint;
                oNxxhintUpdate(uHEA);

            }
            
            else if (BUT_timerSubmit.Text == "TimerSubmit")
            {
              

                timer1 = new Timer() { Interval = 500 };
                var startTime = DateTime.Now;

                timer1.Tick += (obj, args) => lb_Time.Text = (TimeSpan.FromHours(1) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");

                timer1.Start();

                BUT_timerSubmit.Text = "Pause";
               

                string sohint = lb_Time.Text;
                UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                uHEA.xxstart = sohint;
                oNxxhintUpdate(uHEA);
            }
        }
        


        private void But_STOPCLICK(object sender, EventArgs e)
        {
            if (But_Stop.Text == "Stop")
            {
                timer1.Stop();
                But_Stop.Text = "Reset";

                BUT_timerSubmit.Text = "Resume";

                string sohint = "Pause";
                UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                uHEA.xxpause = sohint;
                oNxxhintUpdate(uHEA);

            }
            else if (But_Stop.Text == "Reset")
            {
                
                timer1.Stop();
                lb_Time.Text = TimeSpan.FromHours(1).ToString();

                timer1.Tick += (obj, args) =>  
                lb_Time.Text = (TimeSpan.FromHours(1).ToString("hh\\:mm\\:ss"));
                
                But_Stop.Text = "Stop";
                BUT_timerSubmit.Text = "TimerSubmit";

                string sohint = "Reset";
                UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                uHEA.xxreset = sohint;
                oNxxhintUpdate(uHEA);


            }
        }

        private void but_AddTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (textAddsec.Text != "")
                {
                    timer1.Stop();
                    var startTime = DateTime.Now;
                    string xx = "0.00:00:" + textAddsec.Text;
                    string xtimer = (TimeSpan.Parse(lb_Time.Text) + TimeSpan.Parse(xx)).ToString("hh\\:mm\\:ss");
                    timer1.Tick += (obj, args) => lb_Time.Text = (TimeSpan.Parse(xtimer) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
                    timer1.Start();
                    But_Stop.Text = "Stop";
                    BUT_timerSubmit.Text = "Pause";

                    string sohint = textAddsec.Text;
                    UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                    uHEA.xxAddsec = sohint;
                    oNxxhintUpdate(uHEA);

                }
                if (textAddMin.Text != "") 
                {
                    timer1.Stop();
                    var startTime = DateTime.Now;
                    string tt = "0.00:"+ textAddMin.Text + ":00";
                    string xtimer = (TimeSpan.Parse(lb_Time.Text) + TimeSpan.Parse(tt)).ToString("hh\\:mm\\:ss");
                    timer1.Tick += (obj, args) => lb_Time.Text = (TimeSpan.Parse(xtimer) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
                    timer1.Start();
                    But_Stop.Text = "Stop";
                    BUT_timerSubmit.Text = "Pause";

                    string sohint = textAddMin.Text;
                    UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
                    uHEA.xxAddmin = sohint;
                    oNxxhintUpdate(uHEA);
                }
            }
            catch
            {
                lb_Error.Text = "Please start the timer before adding time.\n Must be in number format. No letters.";
            }
        }
        private void but_HIntSubmit_Click(object sender, EventArgs e)
        {
            string sohint = richTextHint.Text;
            UpdateHintEventArgs uHEA = new UpdateHintEventArgs();
            uHEA.xxhint = sohint;
            oNxxhintUpdate(uHEA);
            
        }

        private void but_win1_Click(object sender, EventArgs e)
        {

        }
    }
}

