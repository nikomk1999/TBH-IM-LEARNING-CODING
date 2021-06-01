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
        public bool RtoC1;
        public Form1()
        {
            InitializeComponent();
            Timer1.Start();
            BOOT Form2 = new BOOT();
            Form2.Show();
            TimeVisible();
            IsitON();
            WhenGaming();
        }

        private async void TimeVisible()
        {
            RtoC1 = false;
            await Task.Delay(2000);
            lbTime.Visible = true;
            RtoC1 = true;


        }

        private async void IsitON()
        {
            if (RtoC1 = false);
            {
                await Task.Delay(2000);
                return;
            }         
        }

        private async void WhenGaming()
        {
            while (true) 
            {
                await Task.Delay(100);
                if (OnOffBox.Checked)
                {
                    lbHour.Visible = lbMinute.Visible = lbSecond.Visible = lbTimeTarg.Visible = lbTimeTarg.Visible = lbTimeRemain.Visible = button1.Visible = textBox1.Visible = lbTimeRemainNum.Visible = true;
                    nudHour.Visible = nudMinute.Visible = nudSecond.Visible = true;
                    pbDone.Visible = true;
                }
                else
                {
                    lbHour.Visible = lbMinute.Visible = lbSecond.Visible = lbTimeTarg.Visible = lbTimeTarg.Visible = lbTimeRemain.Visible = button1.Visible = textBox1.Visible = lbTimeRemainNum.Visible = false;
                    nudHour.Visible = nudMinute.Visible = nudSecond.Visible = false;
                    pbDone.Visible = false;
                }
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.lbTime.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e) // ignore
        {

        }

        private void label1_Click_1(object sender, EventArgs e) // ignore
        {

        }

        private void OnOffBox_CheckedChanged(object sender, EventArgs e) // ignore
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
