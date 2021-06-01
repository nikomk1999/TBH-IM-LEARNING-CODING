
namespace TimerManForm
{
    partial class BOOT
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
            this.BRtoC1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BRtoC1
            // 
            this.BRtoC1.AutoSize = true;
            this.BRtoC1.Location = new System.Drawing.Point(13, 13);
            this.BRtoC1.Name = "BRtoC1";
            this.BRtoC1.Size = new System.Drawing.Size(89, 17);
            this.BRtoC1.TabIndex = 0;
            this.BRtoC1.Text = "ClockLoaded";
            this.BRtoC1.UseVisualStyleBackColor = true;
            this.BRtoC1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BOOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 257);
            this.Controls.Add(this.BRtoC1);
            this.Name = "BOOT";
            this.Text = "BOOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BRtoC1;
    }
}