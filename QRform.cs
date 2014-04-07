using System;
using System.Drawing;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace ClipQR
{
    public partial class QRform : Form
    {
        private string myText;
        private QrCode myQR;

        private const int CELL_SIZE = 10;

        public QRform()
        {
            InitializeComponent();
            
            this.CreateHandle();
            CreateNotifyIcon();
            this.TopMost = true;
        }

        protected void GetClipboardText()
        {
            if (Clipboard.ContainsText())
            { myText = Clipboard.GetText(TextDataFormat.UnicodeText); }
            else
            { myText = "No text on clipboard!"; }

            this.Text = "ClipQR: " + myText;

            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.L);
            encoder.TryEncode(myText, out myQR);
        }

        private void SetSize()
        {
            this.ClientSize = new System.Drawing.Size(myQR.Matrix.Width * CELL_SIZE, myQR.Matrix.Height * CELL_SIZE);
            Rectangle area = Screen.GetWorkingArea(new Point(0, 0));
            this.Location = new Point(area.Right - this.Width, area.Bottom - this.Height);
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            int size = Math.Min(this.qrBox.Width, this.qrBox.Height);

            new GraphicsRenderer(
                new FixedCodeSize(size, QuietZoneModules.Two)).Draw(
                    e.Graphics, myQR.Matrix);
            base.OnPaint(e);
        }

        private void QRform_Resize(object sender, EventArgs e)
        {
            qrBox.Refresh();
        }

        private void qrBox_Click(object sender, EventArgs e)
        {
            GetClipboardText();
            qrBox.Refresh();
            SetSize();
        }

    }
}
