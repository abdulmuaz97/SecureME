using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace SecureME
{
    public partial class MAIN_FRM : Form
    {
        public MAIN_FRM()
        {
            InitializeComponent();

            Username_txt.Text = AdminUserName;
            if (Environment.Is64BitOperatingSystem)
            {
                IS_64bit_OS_lbl.Text = "Running On: 64 bit OS";
            }
            else
            {
                IS_64bit_OS_lbl.Text = "Running On: 32 bit OS";
            }
            Computers_Name_lbl.Text = "Using in: " + Environment.MachineName.ToString();

            LOAD_SETTINGS();
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
        
        // This block is for checking the internet connecttion and return a logic value weather TRUE or FALSE.
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        void isMainPanelVisible(bool Visibility)
        {
            if (Visibility == true)
            {
                Change_PWD_btn.Visible = true;
                Exit_btn.Visible = true;
                UserImage.Visible = true;
                Username_txt.Visible = true;
            }
            else
            {
                Change_PWD_btn.Visible = false;
                Exit_btn.Visible = false;
                UserImage.Visible = false;
                Username_txt.Visible = false;
            }
        }

        // This block is for SAVE SETTINGS function.
        public void SAVE_SETTINGS()
        {
            SecureME.Properties.Settings.Default.IS_LOCKED_SETTINGS = IsLocked;
            SecureME.Properties.Settings.Default.IS_HIDDEN_SETTINGS = IsHidden;
            SecureME.Properties.Settings.Default.Save();
        }
        
        
        public void LOAD_SETTINGS()
        {
            IsLocked = SecureME.Properties.Settings.Default.IS_LOCKED_SETTINGS;
            IsHidden = SecureME.Properties.Settings.Default.IS_HIDDEN_SETTINGS;
            SecureME.Properties.Settings.Default.Reload();

            if (IsLocked == true)
            {
                Lock_Unlock_btn.Text = "Locked";
                Lock_Unlock_btn.Image = SecureME.Properties.Resources.LOCKED_PIC;
            }
            else
            {
                Lock_Unlock_btn.Text = "Unlocked";
                Lock_Unlock_btn.Image = SecureME.Properties.Resources.UNLOCKED_PIC;
            }
            if (IsHidden == true)
            {
                Hide_Unhide_btn.Text = "Hidden";
                Hide_Unhide_btn.Image = SecureME.Properties.Resources.HIDDEN_PIC;
            }
            else
            {
                Hide_Unhide_btn.Text = "Unhidden";
                Hide_Unhide_btn.Image = SecureME.Properties.Resources.UNHIDDEN_PIC;
            }
            if (SecureME.Properties.Settings.Default.PASSWORD_FIELD_SETTINGS == "")
            {
                label7.Text = "Password Set: Default";
            }
            else
            {
                label7.Text = "Password Set: Yes\\Changed";
            }
        }


        // VARIABLES DECLEARATION SECTION.
        bool IsPanelClosed = true;
        bool IsLocked = false;
        bool IsHidden = false;
        string AdminUserName = Environment.UserName;


        private void Main_Bar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_Form_Deactivate(object sender, EventArgs e)
        {
            main_menu_panel.Focus();
        }

        private void main_menu_btn_Click_1(object sender, EventArgs e)
        {
            if (IsPanelClosed == true)
            {
                isMainPanelVisible(true);
                main_menu_panel.Size = new System.Drawing.Size(250, main_menu_panel.Size.Height);
                IsPanelClosed = false;
            }
            else
            {
                isMainPanelVisible(false);
                main_menu_panel.Size = new System.Drawing.Size(50, main_menu_panel.Size.Height);
                IsPanelClosed = true;
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Lock_Unlock_btn_Click(object sender, EventArgs e)
        {
            if (IsHidden == true)
            {
                MessageBox.Show("You can't Lock files or anything while you're hidding other files!\nTurn off the hidding button and try again.", "Wrong Option",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text = SecureME.Properties.Settings.Default.PATH_FILES_STR_SETTINGS;
                textBox2.Text = SecureME.Properties.Settings.Default.PATH_FOLDERS_STR_SETTINGS;
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("There are no files or anything to Lock!", "No Nothing to Secure!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lock_Unlock_btn.Text = "Unlocked";
                    Lock_Unlock_btn.Image = SecureME.Properties.Resources.UNLOCKED_PIC;
                }
                else
                {
                    if (Lock_Unlock_btn.Text == "Unlocked")
                    {
                        try
                        {
                            foreach (object path_line1 in textBox1.Lines)
                            {
                                if (path_line1 == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    DirectorySecurity Dir_Sec = Directory.GetAccessControl(path_line1.ToString());
                                    FileSystemAccessRule F_SYS_R = new FileSystemAccessRule(AdminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                                    Dir_Sec.AddAccessRule(F_SYS_R);
                                    Directory.SetAccessControl(path_line1.ToString(), Dir_Sec);
                                }
                            }
                        }
                        catch (Exception ex1)
                        {
                            // MessageBox.Show(ex1.Message, "Something went wrong!");
                        }
                        try
                        {
                            foreach (object path_line2 in textBox2.Lines)
                            {
                                if (path_line2 == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    DirectorySecurity Dir_Sec = Directory.GetAccessControl(path_line2.ToString());
                                    FileSystemAccessRule F_SYS_R = new FileSystemAccessRule(AdminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                                    Dir_Sec.AddAccessRule(F_SYS_R);
                                    Directory.SetAccessControl(path_line2.ToString(), Dir_Sec);
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                            // MessageBox.Show(ex2.Message, "Something went wrong!");
                        }
                        Lock_Unlock_btn.Text = "Locked";
                        Lock_Unlock_btn.Image = SecureME.Properties.Resources.LOCKED_PIC;
                        IsLocked = true;
                    }
                    else
                    {
                        try
                        {
                            foreach (object path_line in textBox1.Lines)
                            {
                                if (path_line == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    DirectorySecurity Dir_Sec = Directory.GetAccessControl(path_line.ToString());
                                    FileSystemAccessRule F_SYS_R = new FileSystemAccessRule(AdminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                                    Dir_Sec.RemoveAccessRule(F_SYS_R);
                                    Directory.SetAccessControl(path_line.ToString(), Dir_Sec);
                                }
                            }
                        }
                        catch (Exception ex1)
                        {
                            // MessageBox.Show(ex1.Message, "Something went wrong!");
                        }
                        try
                        {
                            foreach (object path_line2 in textBox2.Lines)
                            {
                                if (path_line2 == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    DirectorySecurity Dir_Sec = Directory.GetAccessControl(path_line2.ToString());
                                    FileSystemAccessRule F_SYS_R = new FileSystemAccessRule(AdminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                                    Dir_Sec.RemoveAccessRule(F_SYS_R);
                                    Directory.SetAccessControl(path_line2.ToString(), Dir_Sec);
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                            // MessageBox.Show(ex2.Message, "Something went wrong!");
                        }
                        Lock_Unlock_btn.Text = "Unlocked";
                        Lock_Unlock_btn.Image = SecureME.Properties.Resources.UNLOCKED_PIC;
                        IsLocked = false;

                    }
                }
            }
        }

        private void Hide_Unhide_btn_Click(object sender, EventArgs e)
        {
            if (IsLocked == true)
            {
                MessageBox.Show("You can't Hide files or anything while you're Locking other files!\nTurn off the Locking button and try again.", "Wrong Option",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text = SecureME.Properties.Settings.Default.PATH_FILES_STR_SETTINGS;
                textBox2.Text = SecureME.Properties.Settings.Default.PATH_FOLDERS_STR_SETTINGS;
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("There are no files or anything to Hide!", "No Nothing to Secure!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lock_Unlock_btn.Text = "Unlocked";
                    Lock_Unlock_btn.Image = SecureME.Properties.Resources.UNLOCKED_PIC;
                }
                else
                {
                    if (Hide_Unhide_btn.Text == "Unhidden")
                    {
                        try
                        {
                            foreach (object path_line1 in textBox1.Lines)
                            {
                                if (path_line1 == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    File.SetAttributes(path_line1.ToString(), FileAttributes.Hidden);
                                }
                            }
                        }
                        catch (Exception ex1)
                        {
                            // MessageBox.Show(ex1.Message, "Something went wrong!");
                        }
                        try
                        {
                            foreach (object path_line2 in textBox2.Lines)
                            {
                                if (path_line2 == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    File.SetAttributes(path_line2.ToString(), FileAttributes.Hidden);
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                           // MessageBox.Show(ex2.Message, "Something went wrong!");
                        }
                        Hide_Unhide_btn.Text = "Hidden";
                        Hide_Unhide_btn.Image = SecureME.Properties.Resources.HIDDEN_PIC;
                        IsHidden = true;
                    }
                    else
                    {
                        try
                        {
                            foreach (object path_line in textBox1.Lines)
                            {
                                if (path_line == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    File.SetAttributes(path_line.ToString(), FileAttributes.Normal);
                                }
                            }
                        }
                        catch (Exception ex1)
                        {
                            // MessageBox.Show(ex.Message, "Something went wrong!");
                        }
                        try
                        {
                            foreach (object path_line2 in textBox2.Lines)
                            {
                                if (path_line2 == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    File.SetAttributes(path_line2.ToString(), FileAttributes.Normal);
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                            // MessageBox.Show(ex2.Message, "Something went wrong!");
                        }
                        Hide_Unhide_btn.Text = "Unhidden";
                        Hide_Unhide_btn.Image = SecureME.Properties.Resources.UNHIDDEN_PIC;
                        IsHidden = false;
                    }
                }

            }
        }

        private void Warring_Timer_Tick(object sender, EventArgs e)
        {
            if (!(IsLocked == true || IsHidden == true))
            {
                Warring_lbl.Text = "                                                       Files Are Not Secured!";
                Warring_lbl.Image = SecureME.Properties.Resources.ERROR_PIC;
            }
            else
            {
                Warring_lbl.Text = "                                                   Files Are Secured!";
                Warring_lbl.Image = SecureME.Properties.Resources.OK_PIC;
            }
            if (CheckNet() == true)
            {
                Internet_Check_lbl.Image = SecureME.Properties.Resources.ONLINE_PIC;
                Internet_Check_lbl.Text = "                        Online";
            }
            else
            {
                Internet_Check_lbl.Image = SecureME.Properties.Resources.OFFLINE_PIC;
                Internet_Check_lbl.Text = "                        Offline";
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            isMainPanelVisible(false);
            main_menu_panel.Size = new System.Drawing.Size(50, main_menu_panel.Size.Height);
            IsPanelClosed = true;
        }

        private void Warring_lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Internet_Check_lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            SAVE_SETTINGS();
        }

        private void Selected_Files_btn_Click(object sender, EventArgs e)
        {
            FILES_DIALOG_FRM frm = new FILES_DIALOG_FRM();
            frm.ShowDialog();
        }

        private void Exit_btn_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleBar_lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Change_PWD_btn_Click(object sender, EventArgs e)
        {
            isMainPanelVisible(false);
            main_menu_panel.Size = new System.Drawing.Size(50, main_menu_panel.Size.Height);
            IsPanelClosed = true;
            CHANGE_PASSWORD_FRM FRM = new CHANGE_PASSWORD_FRM();
            FRM.ShowDialog();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            ABOUT_FRM FRM = new ABOUT_FRM();
            FRM.ShowDialog();
        }

        private void Selected_Folders_btn_Click(object sender, EventArgs e)
        {
            FOLDERS_DIALOG_FRM FRM = new FOLDERS_DIALOG_FRM();
            FRM.ShowDialog();
        }

        private void HELP_btn_Click(object sender, EventArgs e)
        {
            HELP_FRM FRM = new HELP_FRM();
            FRM.ShowDialog();
        }

        private void Change_PWD_btn2_Click(object sender, EventArgs e)
        {
            CHANGE_PASSWORD_FRM FRM = new CHANGE_PASSWORD_FRM();
            FRM.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
