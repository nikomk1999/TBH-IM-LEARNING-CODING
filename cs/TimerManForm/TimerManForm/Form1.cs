using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TimerManForm
{
    public partial class Form1 : Form
    {
        private bool RtoC1;
        public Form1()
        {
            InitializeComponent();
            Timer1.Start();
            BOOT Form2 = new BOOT();
            Form2.Show();
            TimeVisible();
        }

        private async void TimeVisible()
        {
            RtoC1 = false;
            await Task.Delay(2000);
            lbTime.Visible = true;
            RtoC1 = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.lbTime.Text = DateTime.Now.ToString();
        }
    }
}
