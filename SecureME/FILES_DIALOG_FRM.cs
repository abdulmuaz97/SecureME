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
    public partial class FILES_DIALOG_FRM : Form
    {
        public FILES_DIALOG_FRM()
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

        // This block is for saving the settings as a public function.
        public void SAVE_SETTINGS()
        {
            textBox1.Clear();
            foreach (object line in ListBox_Files.Items)
            {
                textBox1.Text += line + Environment.NewLine;
            }
            SecureME.Properties.Settings.Default.PATH_FILES_STR_SETTINGS = textBox1.Text;
            SecureME.Properties.Settings.Default.Save();
        }

        // This block is for loading the settings as a public function.
        public void LOAD_SETTINGS()
        {
            textBox1.Text = SecureME.Properties.Settings.Default.PATH_FILES_STR_SETTINGS;
            SecureME.Properties.Settings.Default.Reload();
            foreach (object line in textBox1.Lines)
            {
                if (line == "")
                {
                    continue;
                }
                else
                {
                    ListBox_Files.Items.Add(line);
                }
            }
            if (ListBox_Files.Items.Count <= 0)
            {
                Upload_lbl.Visible = true;
                Upload_picBOX.Visible = true;
            }
            else
            {
                Upload_lbl.Visible = false;
                Upload_picBOX.Visible = false;
            }
        }

        private void Select_Files_Form_Deactivate(object sender, EventArgs e)
        {
            Title_bar_lbl.Focus();
        }

        private void Select_Files_Form_Load(object sender, EventArgs e)
        {
            // Loading all settings once the dialog start..
            LOAD_SETTINGS();
        }

        private void Select_Files_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
           SAVE_SETTINGS();
        }

        private void Title_bar_lbl_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Open_file_btn_Click(object sender, EventArgs e)
        {
            SELECT_FILES_OFD.Filter = "All Files(*.*)|*.*";
            if (SELECT_FILES_OFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string file_name in SELECT_FILES_OFD.FileNames)
                {
                    if (ListBox_Files.Items.Contains(file_name))
                    {
                        continue;
                    }
                    else
                    {
                        ListBox_Files.Items.Add(file_name);
                    }
                }
            }
            else
            {

            }
            if (ListBox_Files.Items.Count <= 0)
            {
                Upload_lbl.Visible = true;
                Upload_picBOX.Visible = true;
            }
            else
            {
                Upload_lbl.Visible = false;
                Upload_picBOX.Visible = false;
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            SAVE_SETTINGS();
        }

        private void delete_item_btn_Click(object sender, EventArgs e)
        {
            ListBox_Files.Items.Remove(ListBox_Files.SelectedItem);
            if (ListBox_Files.Items.Count <= 0)
            {
                Upload_lbl.Visible = true;
                Upload_picBOX.Visible = true;
            }
            else
            {
                Upload_lbl.Visible = false;
                Upload_picBOX.Visible = false;
            }
        }

        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            ListBox_Files.Items.Clear();
            if (ListBox_Files.Items.Count <= 0)
            {
                Upload_lbl.Visible = true;
                Upload_picBOX.Visible = true;
            }
            else
            {
                Upload_lbl.Visible = false;
                Upload_picBOX.Visible = false;
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ListBox_Files.Refresh();
            foreach (object empty_item in ListBox_Files.Items)
            {
                if (empty_item == "")
                {
                    ListBox_Files.Items.Remove(empty_item);
                }
            }
            if (ListBox_Files.Items.Count <= 0)
            {
                Upload_lbl.Visible = true;
                Upload_picBOX.Visible = true;
            }
            else
            {
                Upload_lbl.Visible = false;
                Upload_picBOX.Visible = false;
            }
        }

        private void Upload_lbl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SELECT_FILES_OFD.Filter = "All Files(*.*)|*.*";
            if (SELECT_FILES_OFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string file_name in SELECT_FILES_OFD.FileNames)
                {
                    if (ListBox_Files.Items.Contains(file_name))
                    {
                        continue;
                    }
                    else
                    {
                        ListBox_Files.Items.Add(file_name);
                    }
                }
            }
            else
            {

            }
            if (ListBox_Files.Items.Count <= 0)
            {
                Upload_lbl.Visible = true;
                Upload_picBOX.Visible = true;
            }
            else
            {
                Upload_lbl.Visible = false;
                Upload_picBOX.Visible = false;
            }
        }

        private void Upload_picBOX_Click_1(object sender, EventArgs e)
        {
            SELECT_FILES_OFD.Filter = "All Files(*.*)|*.*";
            if (SELECT_FILES_OFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string file_name in SELECT_FILES_OFD.FileNames)
                {
                    if (ListBox_Files.Items.Contains(file_name))
                    {
                        continue;
                    }
                    else
                    {
                        ListBox_Files.Items.Add(file_name);
                    }
                }
                if (ListBox_Files.Items.Count <= 0)
                {
                    Upload_lbl.Visible = true;
                    Upload_picBOX.Visible = true;
                }
                else
                {
                    Upload_lbl.Visible = false;
                    Upload_picBOX.Visible = false;
                }
            }
            else
            {

            }
        }

    }
}
