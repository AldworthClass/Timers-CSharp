using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timers_CSharp
{
    public partial class TimerForm : Form
    {
        int seconds;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            if (tmrFlashText.Enabled) // If the timer is ON, stop it.
            {
                tmrFlashText.Stop();
                lblFlash.Visible = true;    //Makes text visible when Timer is stopped.
            }
            else  //The Timer is off, so start it.
                tmrFlashText.Start();


            // This is another way you could turn the Timer on or off without an if..else 
            //statement:
            
            // tmrFlashText.Enabled = !tmrFlashText.Enabled;

            // Can you figure out how/why it works?
        }

        private void tmrFlashText_Tick(object sender, EventArgs e)
        {
            lblFlash.Visible = !lblFlash.Visible;   //Why does this work?

            // You could also use an if..else statement.
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            seconds = 0;
        }

        private void tmrStopWatch_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimePassed.Text = seconds + "";
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrStopWatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrStopWatch.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            seconds = 0;
            lblTimePassed.Text = "0";
        }
    }
}
