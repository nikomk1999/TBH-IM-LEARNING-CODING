
namespace Mousetracker
{
    partial class MouseTracker
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
            System.Windows.Forms.Button ButAbout;
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonstart = new System.Windows.Forms.Button();
            this.lbly = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TargX = new System.Windows.Forms.Label();
            this.TargY = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.Label();
            ButAbout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButAbout
            // 
            ButAbout.Location = new System.Drawing.Point(3, 124);
            ButAbout.Name = "ButAbout";
            ButAbout.Size = new System.Drawing.Size(44, 23);
            ButAbout.TabIndex = 2;
            ButAbout.Text = "About";
            ButAbout.UseVisualStyleBackColor = true;
            ButAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButAbout_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(ButAbout);
            this.panel1.Controls.Add(this.buttonstart);
            this.panel1.Controls.Add(this.TargY);
            this.panel1.Controls.Add(this.lbly);
            this.panel1.Controls.Add(this.Target);
            this.panel1.Controls.Add(this.TargX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 152);
            this.panel1.TabIndex = 0;
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(84, 50);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(143, 44);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "Start tracking";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.Location = new System.Drawing.Point(166, 96);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(72, 25);
            this.lbly.TabIndex = 0;
            this.lbly.Text = "0000";
            this.lbly.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            this.label2.Visible = false;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.Location = new System.Drawing.Point(166, 50);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(72, 25);
            this.lblx.TabIndex = 0;
            this.lblx.Text = "0000";
            this.lblx.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TargX
            // 
            this.TargX.AutoSize = true;
            this.TargX.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargX.Location = new System.Drawing.Point(238, 50);
            this.TargX.Name = "TargX";
            this.TargX.Size = new System.Drawing.Size(72, 25);
            this.TargX.TabIndex = 0;
            this.TargX.Text = "0000";
            this.TargX.Visible = false;
            // 
            // TargY
            // 
            this.TargY.AutoSize = true;
            this.TargY.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargY.Location = new System.Drawing.Point(238, 96);
            this.TargY.Name = "TargY";
            this.TargY.Size = new System.Drawing.Size(72, 25);
            this.TargY.TabIndex = 0;
            this.TargY.Text = "0000";
            this.TargY.Visible = false;
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target.Location = new System.Drawing.Point(238, 25);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(82, 25);
            this.Target.TabIndex = 0;
            this.Target.Text = "Target";
            this.Target.Visible = false;
            // 
            // MouseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 147);
            this.Controls.Add(this.panel1);
            this.Name = "MouseTracker";
            this.Text = "MouseTracking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TargY;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Label TargX;
    }
}

