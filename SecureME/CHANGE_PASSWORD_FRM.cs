using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureME
{
    public partial class CHANGE_PASSWORD_FRM : Form
    {
        public CHANGE_PASSWORD_FRM()
        {
            InitializeComponent();
        }
        //*************************************************************************[(START)This code is for BOX SHADOW AND SYSTEM BORDER]***********
        [System.Runtime.InteropServices.DllImportAttribute("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,       // x-coordinate of upper-left corner
            int nTopRect,        // y-coordinate of upper-left corner
            int nRightRect,      // x-coordinate of lower-right corner
            int nBottomRect,     // y-coordinate of lower-right corner
            int nWidthEllipse,   // height of ellipse
            int nHeightEllipse   // width of ellipse
         );
        [System.Runtime.InteropServices.DllImportAttribute("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImportAttribute("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImportAttribute("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        // variables for box shadow
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        // struct for box shadow
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        // variables for dragging the form
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                // box shadow
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
            // drag the form
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }
        //***************************************************************************[(END)This code is for BOX SHADOW AND SYSTEM BORDER]***********
        // This block is for dragging the form and other things.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        bool UN_SAVED, PWD_SAVED = false;

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            OldUsername_txt.Clear();
        }
        private void Clear_btn2_Click(object sender, EventArgs e)
        {
            NewUsername_txt.Clear();
        }
        private void ShowOldPassword_btn_MouseDown(object sender, MouseEventArgs e)
        {
            OldPassword_txt.UseSystemPasswordChar = false;
        }
        private void ShowOldPassword_btn_MouseLeave(object sender, EventArgs e)
        {
            OldPassword_txt.UseSystemPasswordChar = true;
        }
        private void ShowOldPassword_btn_MouseUp(object sender, MouseEventArgs e)
        {
            OldPassword_txt.UseSystemPasswordChar = true;
        }
        private void ShowNewPassword_btn_MouseDown(object sender, MouseEventArgs e)
        {
            NewPassword_txt.UseSystemPasswordChar = false;
        }
        private void ShowNewPassword_btn_MouseLeave(object sender, EventArgs e)
        {
            NewPassword_txt.UseSystemPasswordChar = true;
        }
        private void ShowNewPassword_btn_MouseUp(object sender, MouseEventArgs e)
        {
            NewPassword_txt.UseSystemPasswordChar = true;
        }
        private void ShowConfirmNewPassword_btn_MouseDown(object sender, MouseEventArgs e)
        {
            NewPasswordConfirm_txt.UseSystemPasswordChar = false;
        }
        private void ShowConfirmNewPassword_btn_MouseLeave(object sender, EventArgs e)
        {
            NewPasswordConfirm_txt.UseSystemPasswordChar = true;
        }
        private void ShowConfirmNewPassword_btn_MouseUp(object sender, MouseEventArgs e)
        {
            NewPasswordConfirm_txt.UseSystemPasswordChar = true;
        }
        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SAVE_CHANGES_BTN_Click(object sender, EventArgs e)
        {
            // [BLOCK] Checking if the old username was correct or not..
            if (OldUsername_txt.Text == SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString())
            {
                if (NewUsername_txt.Text == "")
                {
                    SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS = "admin";
                    UN_SAVED = true;
                }
                else
                {
                    SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS = NewUsername_txt.Text.ToString();
                    SecureME.Properties.Settings.Default.Save();
                    UN_SAVED = true;
                }
            }
            else
            {
                Status_lbl.Text = "Your old username is incorrect!";
                Status_lbl.Visible = true;
            }

            // [BLOCK] Checking if the old password was correct or not..
            if (OldPassword_txt.Text == SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
            {
                if (NewPassword_txt.Text == NewPasswordConfirm_txt.Text)
                {
                    SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS = NewPasswordConfirm_txt.Text;
                    SecureME.Properties.Settings.Default.Save();
                    PWD_SAVED = true;
                }
                else
                {
                    Status_lbl.Text = "Please, Check your new password and confirm it correctly!";
                    Status_lbl.Visible = true;
                }
            }
            else
            {
                Status_lbl.Text = "Your old password is incorrect!";
                Status_lbl.Visible = true;
            }

            // [FINAL BLOCK] Checking if everything went correclty then save changes and exit..
            if (UN_SAVED == true && PWD_SAVED == true)
            {
                this.Close();
            }
        }

        private void Title_bar_lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CHANGE_PASSWORD_FRM_Load(object sender, EventArgs e)
        {
            if (SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS == "admin")
            {
                OldUsername_txt.Text = "admin";
            }
            else
            {
                OldUsername_txt.Text = "";
            }
        }

        private void CHANGE_PASSWORD_FRM_Deactivate(object sender, EventArgs e)
        {
            Title_bar_lbl.Focus();
        }


    }
}
