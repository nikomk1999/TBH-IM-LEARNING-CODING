
namespace TimerManForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTime = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.OnOffBox = new System.Windows.Forms.CheckBox();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbTimeTarg = new System.Windows.Forms.Label();
            this.pbDone = new System.Windows.Forms.ProgressBar();
            this.lbTimeRemain = new System.Windows.Forms.Label();
            this.lbTimeRemainNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(12, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 13);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time";
            this.lbTime.Visible = false;
            this.lbTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // OnOffBox
            // 
            this.OnOffBox.AutoSize = true;
            this.OnOffBox.Location = new System.Drawing.Point(13, 26);
            this.OnOffBox.Name = "OnOffBox";
            this.OnOffBox.Size = new System.Drawing.Size(59, 17);
            this.OnOffBox.TabIndex = 1;
            this.OnOffBox.Text = "On/Off";
            this.OnOffBox.UseVisualStyleBackColor = true;
            this.OnOffBox.Visible = false;
            this.OnOffBox.CheckedChanged += new System.EventHandler(this.OnOffBox_CheckedChanged);
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(33, 50);
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(41, 20);
            this.nudHour.TabIndex = 2;
            this.nudHour.Visible = false;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(110, 50);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 20);
            this.nudMinute.TabIndex = 3;
            this.nudMinute.Visible = false;
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(189, 50);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(41, 20);
            this.nudSecond.TabIndex = 4;
            this.nudSecond.Visible = false;
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Location = new System.Drawing.Point(12, 52);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(15, 13);
            this.lbHour.TabIndex = 5;
            this.lbHour.Text = "H";
            this.lbHour.Visible = false;
            this.lbHour.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(80, 52);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(24, 13);
            this.lbMinute.TabIndex = 6;
            this.lbMinute.Text = "Min";
            this.lbMinute.Visible = false;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(157, 52);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(26, 13);
            this.lbSecond.TabIndex = 7;
            this.lbSecond.Text = "Sec";
            this.lbSecond.Visible = false;
            // 
            // lbTimeTarg
            // 
            this.lbTimeTarg.AutoSize = true;
            this.lbTimeTarg.Location = new System.Drawing.Point(10, 84);
            this.lbTimeTarg.Name = "lbTimeTarg";
            this.lbTimeTarg.Size = new System.Drawing.Size(52, 13);
            this.lbTimeTarg.TabIndex = 8;
            this.lbTimeTarg.Text = "TimeTarg";
            this.lbTimeTarg.Visible = false;
            // 
            // pbDone
            // 
            this.pbDone.Location = new System.Drawing.Point(12, 100);
            this.pbDone.Name = "pbDone";
            this.pbDone.Size = new System.Drawing.Size(218, 23);
            this.pbDone.TabIndex = 9;
            this.pbDone.Visible = false;
            // 
            // lbTimeRemain
            // 
            this.lbTimeRemain.AutoSize = true;
            this.lbTimeRemain.Location = new System.Drawing.Point(236, 100);
            this.lbTimeRemain.Name = "lbTimeRemain";
            this.lbTimeRemain.Size = new System.Drawing.Size(80, 13);
            this.lbTimeRemain.TabIndex = 10;
            this.lbTimeRemain.Text = "TimeRemaining";
            this.lbTimeRemain.Visible = false;
            // 
            // lbTimeRemainNum
            // 
            this.lbTimeRemainNum.AutoSize = true;
            this.lbTimeRemainNum.Location = new System.Drawing.Point(236, 113);
            this.lbTimeRemainNum.Name = "lbTimeRemainNum";
            this.lbTimeRemainNum.Size = new System.Drawing.Size(80, 13);
            this.lbTimeRemainNum.TabIndex = 11;
            this.lbTimeRemainNum.Text = "TimeRemaining";
            this.lbTimeRemainNum.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTimeRemainNum);
            this.Controls.Add(this.lbTimeRemain);
            this.Controls.Add(this.pbDone);
            this.Controls.Add(this.lbTimeTarg);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.OnOffBox);
            this.Controls.Add(this.lbTime);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.CheckBox OnOffBox;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbTimeTarg;
        private System.Windows.Forms.ProgressBar pbDone;
        private System.Windows.Forms.Label lbTimeRemain;
        private System.Windows.Forms.Label lbTimeRemainNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

