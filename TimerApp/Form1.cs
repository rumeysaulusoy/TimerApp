using System;
using System.Timers;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        
        private int secondsElapsed = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Stop(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            secondsElapsed = 0;
            lblTime.Text = "00:00";
        }


        private void timer1_Elapsed_1(object sender, ElapsedEventArgs e)
        {
            secondsElapsed++;
            TimeSpan time = TimeSpan.FromSeconds(secondsElapsed);
            lblTime.Text = time.ToString(@"mm\:ss");
        }
    }
}