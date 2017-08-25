using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SecureME
{
    public partial class LOGIN_FRM : Form
    {
        public LOGIN_FRM()
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

        private void Show_Pass_btn_MouseDown(object sender, MouseEventArgs e) {
            Password_txt.UseSystemPasswordChar = false;
        }
        private void Show_Pass_btn_MouseUp(object sender, MouseEventArgs e) {
            Password_txt.UseSystemPasswordChar = true;
        }
        private void Clear_btn_Click(object sender, EventArgs e) {
            Username_txt.Clear();
        }
        private void EXIT_BTN_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void SET_PASSWORD_FRM_Deactivate(object sender, EventArgs e) 
        {
            Title_bar_lbl.Focus();
        }


        private void SET_PASSWORD_FRM_Load(object sender, EventArgs e)
        {
            if (SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS == "admin")
            {
                Username_txt.Text = "admin";
            }
            else
            {
                Username_txt.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clear_btn.Focused || Show_Pass_btn.Focused)
            {
                Title_bar_lbl.Focus();
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

        private void LOGIN_BTN_Click(object sender, EventArgs e)
        {
            if (Username_txt.Text == SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString() &&
                Password_txt.Text == SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
            {
                Status_lbl.Visible = false;
                MAIN_FRM FRM = new MAIN_FRM();
                Thread.Sleep(200);
                FRM.Show();
                this.Hide();
            }
            else
            {
                if (Username_txt.Text != SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString() && Password_txt.Text != SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                {
                    Status_lbl.Text = "Both of Username and Password are incorrect!";
                    Status_lbl.Visible = true;
                }
                else if (Username_txt.Text != SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString())
                {
                    Status_lbl.Text = "Your Username is incorrect!";
                    Status_lbl.Visible = true;
                }
                else if (Password_txt.Text != SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                {
                    Status_lbl.Text = "Your Password is incorrect!";
                    Status_lbl.Visible = true;
                }
                else
                {
                    MessageBox.Show("Something went wrong in the data processing, Try to restart\nthe program and then try access again if so then contact us we'll find a better solution",
                        "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Username_txt.Text == SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString() &&
                    Password_txt.Text == SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                {
                    Status_lbl.Visible = false;
                    MAIN_FRM FRM = new MAIN_FRM();
                    FRM.Show();
                    this.Hide();
                }
                else
                {
                    if (Username_txt.Text != SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString() && Password_txt.Text != SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                    {
                        Status_lbl.Text = "Both of Username and Password are incorrect!";
                        Status_lbl.Visible = true;
                    }
                    else if (Username_txt.Text != SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString())
                    {
                        Status_lbl.Text = "Your Username is incorrect!";
                        Status_lbl.Visible = true;
                    }
                    else if (Password_txt.Text != SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                    {
                        Status_lbl.Text = "Your Password is incorrect!";
                        Status_lbl.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong in the data processing, Try to restart\nthe program and then try access again if so then contact us we'll find a better solution",
                            "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Username_txt.Text == SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString() &&
                    Password_txt.Text == SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                {
                    Status_lbl.Visible = false;
                    MAIN_FRM FRM = new MAIN_FRM();
                    FRM.Show();
                    this.Hide();
                }
                else
                {
                    if (Username_txt.Text != SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString() && Password_txt.Text != SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                    {
                        Status_lbl.Text = "Both of Username and Password are incorrect!";
                        Status_lbl.Visible = true;
                    }
                    else if (Username_txt.Text != SecureME.Properties.Settings.Default.USERNAME_FIELD_SETTINGS.ToString())
                    {
                        Status_lbl.Text = "Your Username is incorrect!";
                        Status_lbl.Visible = true;
                    }
                    else if (Password_txt.Text != SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS.ToString())
                    {
                        Status_lbl.Text = "Your Password is incorrect!";
                        Status_lbl.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong in the data processing, Try to restart\nthe program and then try access again if so then contact us we'll find a better solution",
                            "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Show_Pass_btn_MouseLeave(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = true;
        }


    }
}
