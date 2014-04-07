using System;
using System.IO;
using System.Windows.Forms;

namespace ClipQR
{
        public partial class QRform
        {
            public NotifyIcon notifyIcon = new NotifyIcon();
            public ContextMenu notifyMenu = new ContextMenu();
            private bool canClose = false;

            public void CreateNotifyIcon()
            {
                notifyIcon.Text = "ClipQR";
                notifyIcon.Icon = new System.Drawing.Icon(Directory.GetCurrentDirectory() + @"\ClipQR.ico"); ;
                notifyIcon.MouseClick += notifyIcon_MouseClick;

                // Add menu items to context menu.

                notifyMenu.MenuItems.Add("E&xit", ExitApplication);

                // Set properties of NotifyIcon component.

                notifyIcon.ContextMenu = notifyMenu;

                notifyIcon.Visible = true;
            }

            void notifyIcon_MouseClick(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!this.Visible)
                    {
                        GetClipboardText();
                        SetSize();
                        this.Show();
                        this.Refresh();
                        this.WindowState = FormWindowState.Normal;
                        this.BringToFront();
                        this.Focus();
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }

            private void ExitApplication(object sender, EventArgs e)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit ClipQR?", "ClipQR", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    canClose = true;
                    notifyIcon.Visible = false;
                    notifyIcon.Dispose();
                    this.Close();
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }

            }

            private void QRform_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (canClose == false)
                {
                    this.Hide();
                    e.Cancel = true;
                    GC.Collect();
                }
                else
                {
                    // do nothing
                }
            }

        }
}
