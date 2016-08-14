using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerandHintAPP
{
    public partial class Room1 : System.Windows.Forms.Form
    {
        private Timer timer1;

        public Room1()
        {
            InitializeComponent();

            lb_room1timer.Text = TimeSpan.FromHours(1).ToString();
            TimerNhint tNH = new TimerNhint();
            tNH.xxhintUpdate += new EventHandler<TimerNhint.UpdateHintEventArgs>(tNH_xxhintupdate);
            lb_HintRoom1.Text = "";
            tNH.Show();

        }

        void tNH_xxhintupdate(object sender, TimerNhint.UpdateHintEventArgs e)
        {
            if (e != null && e.xxhint !=null)
            {
                lb_HintRoom1.Text = e.xxhint;
            }
            if (e != null && e.xxstart != null)
            {
                timer1 = new Timer() { Interval = 500 };
                var startTime = DateTime.Now;

                timer1.Tick += (obj, args) => lb_room1timer.Text = (TimeSpan.FromHours(1) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");

                timer1.Start();
                
            }
            if (e != null && e.xxpause == "Pause")
            {
                timer1.Stop();
            }
            if (e != null && e.xxresume == "Resume")
            {
                timer1.Start();
            

                var startTime = DateTime.Now;
                string xtimer = (TimeSpan.Parse(lb_room1timer.Text) + TimeSpan.FromSeconds(1)).ToString("hh\\:mm\\:ss");
                timer1.Tick += (obj, args) => lb_room1timer.Text = (TimeSpan.Parse(xtimer) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
            }
            if (e != null && e.xxreset == "Reset")
            {
                timer1.Stop();
                lb_room1timer.Text = TimeSpan.FromHours(1).ToString();

                timer1.Tick += (obj, args) =>
                lb_room1timer.Text = (TimeSpan.FromHours(1).ToString("hh\\:mm\\:ss"));
            }

            if (e != null && e.xxAddsec !=null)
            {
                timer1.Stop();
                var startTime = DateTime.Now;
                string xx = "0.00:00:" + e.xxAddsec;
                string xtimer = (TimeSpan.Parse(lb_room1timer.Text) + TimeSpan.Parse(xx)).ToString("hh\\:mm\\:ss");
                timer1.Tick += (obj, args) => lb_room1timer.Text = (TimeSpan.Parse(xtimer) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
                timer1.Start();
            }

            if (e != null && e.xxAddmin !=null)
            {
                timer1.Stop();
                var startTime = DateTime.Now;
                string tt = "0.00:" + e.xxAddmin + ":00";
                string xtimer = (TimeSpan.Parse(lb_room1timer.Text) + TimeSpan.Parse(tt)).ToString("hh\\:mm\\:ss");
                timer1.Tick += (obj, args) => lb_room1timer.Text = (TimeSpan.Parse(xtimer) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
                timer1.Start();
            }
        }

        private void but_test_Click(object sender, EventArgs e)
        {
            
        }
    }
}

