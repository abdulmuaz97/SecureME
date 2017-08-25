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
    public partial class ABOUT_FRM : Form
    {
        public ABOUT_FRM()
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

        private void ABOUT_FRM_Load(object sender, EventArgs e)
        {
            label4.Text = SecureME.Properties.Settings.Default.LOVED_IT_STR;
            if (SecureME.Properties.Settings.Default.LOVED_IT == true)
            {
                REACT_PIC.Image = SecureME.Properties.Resources.LOVED_FILL_PIC;
            }
            else
            {
                REACT_PIC.Image = SecureME.Properties.Resources.LOVED_PIC;
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
        private void ABOUT_FRM_Deactivate(object sender, EventArgs e)
        {
            Title_bar_lbl.Focus();
        }
        private void FB_BTN_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("http://www.facebook.com/AbdulMuaz.Aqeel.SSP");}
        private void INSTA_BTN_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://www.instagram.com/abdulmuaz_ssp/");}
        private void GH_BTN_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://github.com/abdulmuaz97");}
        private void GPlus_BTN_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://plus.google.com/u/0/115245547277144814028");}
        private void TW_BTN_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://twitter.com/AbdulMuaz_Aqeel");}
        private void YT_BTN_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCfr2BstkBSzYXqK5GSNiW7g");}
        private void EXIT_BTN_Click(object sender, EventArgs e) {this.Close();}

        private void REACT_PIC_Click(object sender, EventArgs e)
        {
            if (SecureME.Properties.Settings.Default.IS_MESSAGE_SENT == true)
            {

            }else
            {
                REACT_PIC.Image = SecureME.Properties.Resources.LOVED_FILL_PIC;
                label4.Text = "Thank You! We do appreciate it.";
                SecureME.Properties.Settings.Default.LOVED_IT = true;
                SecureME.Properties.Settings.Default.LOVED_IT_STR = label4.Text;
                SecureME.Properties.Settings.Default.Save();
            }
        }
    }
} 
