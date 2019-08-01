using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT.Control
{
    public partial class DelayBox : TextBox
    {
        private int _threshold = 1000;
        public DelayBox()
        {
            InitializeComponent();
        }

        public int Delay
        {
            get
            {
                return _threshold;
            }
            set { _threshold = value; }
        }
        public System.Windows.Forms.Timer Timer;
        protected override void OnTextChanged(EventArgs e)
        {
            if (Timer == null)
            {
                Timer = new Timer();
                Timer.Interval = _threshold;
                Timer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            Timer.Stop();
            Timer.Start();
        }
        private void handleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer;
            if (timer == null)
            {
                return;
            }
            timer.Stop();
            base.OnTextChanged(e);
        }

        private void DelayBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Timer.Stop();
                base.OnTextChanged(e);
            }
        }
    }
}
