﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mousetracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            lblx.Visible = true;
            lbly.Visible = true;
            buttonstart.Visible = false;



            Thread trackerThread = new Thread(Tracker); //makes a new thread for the code bellow
            trackerThread.Start();
        
        }
        private void Tracker()
        {
            while (true) // infinite loop
            {
                int x = MousePosition.X;
                int y = MousePosition.Y; // gets the mouse possition

                lblx.Text = x.ToString();
                lbly.Text = y.ToString(); // sets the form1's text field named "lbly" to the int value
            }
        }
    }
}
