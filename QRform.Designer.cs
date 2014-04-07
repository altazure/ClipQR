namespace ClipQR
{
    partial class QRform
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
            this.qrBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrBox
            // 
            this.qrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrBox.Location = new System.Drawing.Point(0, 0);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(284, 265);
            this.qrBox.TabIndex = 0;
            this.qrBox.TabStop = false;
            this.qrBox.Click += new System.EventHandler(this.qrBox_Click);
            this.qrBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // QRform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.qrBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QRform";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClipQR";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRform_FormClosing);
            this.Resize += new System.EventHandler(this.QRform_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrBox;
    }
}

