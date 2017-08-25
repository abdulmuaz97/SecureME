namespace SecureME
{
    partial class MAIN_FRM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_FRM));
            this.Main_Bar_Panel = new System.Windows.Forms.Panel();
            this.Internet_Check_lbl = new System.Windows.Forms.Label();
            this.Warring_lbl = new System.Windows.Forms.Label();
            this.TitleBar_lbl = new System.Windows.Forms.Label();
            this.main_menu_panel = new System.Windows.Forms.Panel();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.Change_PWD_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.main_menu_btn = new System.Windows.Forms.Button();
            this.Warring_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Computers_Name_lbl = new System.Windows.Forms.Label();
            this.IS_64bit_OS_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Exit_btn_2 = new System.Windows.Forms.Button();
            this.About_btn = new System.Windows.Forms.Button();
            this.HELP_btn = new System.Windows.Forms.Button();
            this.Change_PWD_btn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Status_PIC = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Selected_Folders_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Selected_Files_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lock_Unlock_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Hide_Unhide_btn = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Main_Bar_Panel.SuspendLayout();
            this.main_menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Bar_Panel
            // 
            this.Main_Bar_Panel.BackColor = System.Drawing.Color.White;
            this.Main_Bar_Panel.Controls.Add(this.Internet_Check_lbl);
            this.Main_Bar_Panel.Controls.Add(this.Warring_lbl);
            this.Main_Bar_Panel.Controls.Add(this.TitleBar_lbl);
            this.Main_Bar_Panel.Location = new System.Drawing.Point(50, 0);
            this.Main_Bar_Panel.Name = "Main_Bar_Panel";
            this.Main_Bar_Panel.Size = new System.Drawing.Size(759, 48);
            this.Main_Bar_Panel.TabIndex = 1;
            this.Main_Bar_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Bar_Panel_MouseDown);
            // 
            // Internet_Check_lbl
            // 
            this.Internet_Check_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Internet_Check_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Internet_Check_lbl.ForeColor = System.Drawing.Color.White;
            this.Internet_Check_lbl.Image = global::SecureME.Properties.Resources.ONLINE_PIC;
            this.Internet_Check_lbl.Location = new System.Drawing.Point(-52, -2);
            this.Internet_Check_lbl.Name = "Internet_Check_lbl";
            this.Internet_Check_lbl.Size = new System.Drawing.Size(178, 46);
            this.Internet_Check_lbl.TabIndex = 1;
            this.Internet_Check_lbl.Text = "                        Online";
            this.Internet_Check_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Internet_Check_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Internet_Check_lbl_MouseDown);
            // 
            // Warring_lbl
            // 
            this.Warring_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Warring_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warring_lbl.ForeColor = System.Drawing.Color.White;
            this.Warring_lbl.Image = global::SecureME.Properties.Resources.ERROR_PIC;
            this.Warring_lbl.Location = new System.Drawing.Point(-46, -1);
            this.Warring_lbl.Name = "Warring_lbl";
            this.Warring_lbl.Size = new System.Drawing.Size(414, 46);
            this.Warring_lbl.TabIndex = 0;
            this.Warring_lbl.Tag = "10";
            this.Warring_lbl.Text = "                                                       Files Are Not Secured!";
            this.Warring_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Warring_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Warring_lbl_MouseDown);
            // 
            // TitleBar_lbl
            // 
            this.TitleBar_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.TitleBar_lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar_lbl.ForeColor = System.Drawing.Color.White;
            this.TitleBar_lbl.Image = ((System.Drawing.Image)(resources.GetObject("TitleBar_lbl.Image")));
            this.TitleBar_lbl.Location = new System.Drawing.Point(244, -1);
            this.TitleBar_lbl.Name = "TitleBar_lbl";
            this.TitleBar_lbl.Size = new System.Drawing.Size(515, 46);
            this.TitleBar_lbl.TabIndex = 2;
            this.TitleBar_lbl.Text = "                    SecureME";
            this.TitleBar_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleBar_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_lbl_MouseDown);
            // 
            // main_menu_panel
            // 
            this.main_menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.main_menu_panel.Controls.Add(this.Username_txt);
            this.main_menu_panel.Controls.Add(this.UserImage);
            this.main_menu_panel.Controls.Add(this.Change_PWD_btn);
            this.main_menu_panel.Controls.Add(this.Exit_btn);
            this.main_menu_panel.Controls.Add(this.main_menu_btn);
            this.main_menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_menu_panel.Location = new System.Drawing.Point(0, 0);
            this.main_menu_panel.Name = "main_menu_panel";
            this.main_menu_panel.Size = new System.Drawing.Size(75, 581);
            this.main_menu_panel.TabIndex = 3;
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.ForeColor = System.Drawing.Color.White;
            this.Username_txt.Location = new System.Drawing.Point(0, 183);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.ReadOnly = true;
            this.Username_txt.Size = new System.Drawing.Size(75, 22);
            this.Username_txt.TabIndex = 12;
            this.Username_txt.Text = "Set Your Own Username";
            this.Username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserImage
            // 
            this.UserImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserImage.Image = global::SecureME.Properties.Resources.CIRCLE_USER_PIC;
            this.UserImage.Location = new System.Drawing.Point(0, 45);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(75, 138);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserImage.TabIndex = 11;
            this.UserImage.TabStop = false;
            // 
            // Change_PWD_btn
            // 
            this.Change_PWD_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Change_PWD_btn.FlatAppearance.BorderSize = 0;
            this.Change_PWD_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Change_PWD_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Change_PWD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_PWD_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_PWD_btn.ForeColor = System.Drawing.Color.White;
            this.Change_PWD_btn.Image = global::SecureME.Properties.Resources.KEY_PIC;
            this.Change_PWD_btn.Location = new System.Drawing.Point(-192, 422);
            this.Change_PWD_btn.Name = "Change_PWD_btn";
            this.Change_PWD_btn.Size = new System.Drawing.Size(488, 50);
            this.Change_PWD_btn.TabIndex = 9;
            this.Change_PWD_btn.Text = "                                               Change Password";
            this.Change_PWD_btn.UseVisualStyleBackColor = false;
            this.Change_PWD_btn.Click += new System.EventHandler(this.Change_PWD_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = global::SecureME.Properties.Resources.SHUTDOWN_PIC;
            this.Exit_btn.Location = new System.Drawing.Point(-130, 502);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(426, 50);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "                           Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // main_menu_btn
            // 
            this.main_menu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.main_menu_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn.FlatAppearance.BorderSize = 0;
            this.main_menu_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.main_menu_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.main_menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn.Image = global::SecureME.Properties.Resources.MENU_BTN_PIC;
            this.main_menu_btn.Location = new System.Drawing.Point(0, 0);
            this.main_menu_btn.Name = "main_menu_btn";
            this.main_menu_btn.Size = new System.Drawing.Size(75, 45);
            this.main_menu_btn.TabIndex = 3;
            this.main_menu_btn.UseVisualStyleBackColor = false;
            this.main_menu_btn.Click += new System.EventHandler(this.main_menu_btn_Click_1);
            // 
            // Warring_Timer
            // 
            this.Warring_Timer.Enabled = true;
            this.Warring_Timer.Interval = 500;
            this.Warring_Timer.Tick += new System.EventHandler(this.Warring_Timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Computers_Name_lbl);
            this.panel2.Controls.Add(this.IS_64bit_OS_lbl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(442, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 248);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 102);
            this.label1.TabIndex = 39;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Computers_Name_lbl
            // 
            this.Computers_Name_lbl.AutoSize = true;
            this.Computers_Name_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computers_Name_lbl.ForeColor = System.Drawing.Color.White;
            this.Computers_Name_lbl.Location = new System.Drawing.Point(17, 84);
            this.Computers_Name_lbl.Name = "Computers_Name_lbl";
            this.Computers_Name_lbl.Size = new System.Drawing.Size(58, 17);
            this.Computers_Name_lbl.TabIndex = 38;
            this.Computers_Name_lbl.Text = "Using in:";
            // 
            // IS_64bit_OS_lbl
            // 
            this.IS_64bit_OS_lbl.AutoSize = true;
            this.IS_64bit_OS_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_64bit_OS_lbl.ForeColor = System.Drawing.Color.White;
            this.IS_64bit_OS_lbl.Location = new System.Drawing.Point(17, 53);
            this.IS_64bit_OS_lbl.Name = "IS_64bit_OS_lbl";
            this.IS_64bit_OS_lbl.Size = new System.Drawing.Size(83, 17);
            this.IS_64bit_OS_lbl.TabIndex = 37;
            this.IS_64bit_OS_lbl.Text = "Running On: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Password Set: Default";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(778, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 59);
            this.textBox1.TabIndex = 36;
            this.textBox1.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "SecureME ";
            // 
            // Exit_btn_2
            // 
            this.Exit_btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.Exit_btn_2.FlatAppearance.BorderSize = 0;
            this.Exit_btn_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.Exit_btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.Exit_btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn_2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn_2.ForeColor = System.Drawing.Color.White;
            this.Exit_btn_2.Image = global::SecureME.Properties.Resources.SHUTDOWN_PIC;
            this.Exit_btn_2.Location = new System.Drawing.Point(619, 498);
            this.Exit_btn_2.Name = "Exit_btn_2";
            this.Exit_btn_2.Size = new System.Drawing.Size(154, 58);
            this.Exit_btn_2.TabIndex = 12;
            this.toolTip1.SetToolTip(this.Exit_btn_2, "Exit");
            this.Exit_btn_2.UseVisualStyleBackColor = false;
            this.Exit_btn_2.Click += new System.EventHandler(this.Exit_btn_2_Click);
            // 
            // About_btn
            // 
            this.About_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.About_btn.FlatAppearance.BorderSize = 0;
            this.About_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.About_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.About_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_btn.ForeColor = System.Drawing.Color.White;
            this.About_btn.Image = global::SecureME.Properties.Resources.ABOUT_PIC;
            this.About_btn.Location = new System.Drawing.Point(441, 498);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(154, 58);
            this.About_btn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.About_btn, "About...");
            this.About_btn.UseVisualStyleBackColor = false;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // HELP_btn
            // 
            this.HELP_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.HELP_btn.FlatAppearance.BorderSize = 0;
            this.HELP_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.HELP_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(126)))), ((int)(((byte)(142)))));
            this.HELP_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HELP_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HELP_btn.ForeColor = System.Drawing.Color.White;
            this.HELP_btn.Image = ((System.Drawing.Image)(resources.GetObject("HELP_btn.Image")));
            this.HELP_btn.Location = new System.Drawing.Point(263, 498);
            this.HELP_btn.Name = "HELP_btn";
            this.HELP_btn.Size = new System.Drawing.Size(154, 58);
            this.HELP_btn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.HELP_btn, "Help");
            this.HELP_btn.UseVisualStyleBackColor = false;
            this.HELP_btn.Click += new System.EventHandler(this.HELP_btn_Click);
            // 
            // Change_PWD_btn2
            // 
            this.Change_PWD_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.Change_PWD_btn2.FlatAppearance.BorderSize = 0;
            this.Change_PWD_btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.Change_PWD_btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(69)))), ((int)(((byte)(118)))));
            this.Change_PWD_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_PWD_btn2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_PWD_btn2.ForeColor = System.Drawing.Color.White;
            this.Change_PWD_btn2.Image = global::SecureME.Properties.Resources.KEY_PIC;
            this.Change_PWD_btn2.Location = new System.Drawing.Point(86, 499);
            this.Change_PWD_btn2.Name = "Change_PWD_btn2";
            this.Change_PWD_btn2.Size = new System.Drawing.Size(154, 58);
            this.Change_PWD_btn2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Change_PWD_btn2, "Change Password");
            this.Change_PWD_btn2.UseVisualStyleBackColor = false;
            this.Change_PWD_btn2.Click += new System.EventHandler(this.Change_PWD_btn2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Status_PIC);
            this.panel1.Location = new System.Drawing.Point(88, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 248);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 186);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-5, 133);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // Status_PIC
            // 
            this.Status_PIC.BackColor = System.Drawing.Color.Transparent;
            this.Status_PIC.Image = ((System.Drawing.Image)(resources.GetObject("Status_PIC.Image")));
            this.Status_PIC.Location = new System.Drawing.Point(-5, 18);
            this.Status_PIC.Name = "Status_PIC";
            this.Status_PIC.Size = new System.Drawing.Size(100, 100);
            this.Status_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Status_PIC.TabIndex = 27;
            this.Status_PIC.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(778, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 59);
            this.textBox2.TabIndex = 36;
            this.textBox2.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(614, 495);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(164, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(436, 495);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(164, 64);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(258, 495);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(164, 64);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // Selected_Folders_btn
            // 
            this.Selected_Folders_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.Selected_Folders_btn.FlatAppearance.BorderSize = 0;
            this.Selected_Folders_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.Selected_Folders_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(175)))), ((int)(((byte)(57)))));
            this.Selected_Folders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selected_Folders_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_Folders_btn.ForeColor = System.Drawing.Color.White;
            this.Selected_Folders_btn.Image = global::SecureME.Properties.Resources.FOLDERS_PIC;
            this.Selected_Folders_btn.Location = new System.Drawing.Point(620, 330);
            this.Selected_Folders_btn.Name = "Selected_Folders_btn";
            this.Selected_Folders_btn.Size = new System.Drawing.Size(153, 142);
            this.Selected_Folders_btn.TabIndex = 4;
            this.Selected_Folders_btn.Text = "Selected Folders";
            this.Selected_Folders_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Selected_Folders_btn.UseVisualStyleBackColor = false;
            this.Selected_Folders_btn.Click += new System.EventHandler(this.Selected_Folders_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(615, 325);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Selected_Files_btn
            // 
            this.Selected_Files_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.Selected_Files_btn.FlatAppearance.BorderSize = 0;
            this.Selected_Files_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.Selected_Files_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(95)))));
            this.Selected_Files_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selected_Files_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_Files_btn.ForeColor = System.Drawing.Color.White;
            this.Selected_Files_btn.Image = global::SecureME.Properties.Resources.FILES_PIC;
            this.Selected_Files_btn.Location = new System.Drawing.Point(442, 330);
            this.Selected_Files_btn.Name = "Selected_Files_btn";
            this.Selected_Files_btn.Size = new System.Drawing.Size(153, 142);
            this.Selected_Files_btn.TabIndex = 3;
            this.Selected_Files_btn.Text = "Selected Files";
            this.Selected_Files_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Selected_Files_btn.UseVisualStyleBackColor = false;
            this.Selected_Files_btn.Click += new System.EventHandler(this.Selected_Files_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(437, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Lock_Unlock_btn
            // 
            this.Lock_Unlock_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.Lock_Unlock_btn.FlatAppearance.BorderSize = 0;
            this.Lock_Unlock_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.Lock_Unlock_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.Lock_Unlock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lock_Unlock_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lock_Unlock_btn.ForeColor = System.Drawing.Color.White;
            this.Lock_Unlock_btn.Image = global::SecureME.Properties.Resources.UNLOCKED_PIC;
            this.Lock_Unlock_btn.Location = new System.Drawing.Point(264, 330);
            this.Lock_Unlock_btn.Name = "Lock_Unlock_btn";
            this.Lock_Unlock_btn.Size = new System.Drawing.Size(153, 142);
            this.Lock_Unlock_btn.TabIndex = 2;
            this.Lock_Unlock_btn.Text = "Unlocked";
            this.Lock_Unlock_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lock_Unlock_btn.UseVisualStyleBackColor = false;
            this.Lock_Unlock_btn.Click += new System.EventHandler(this.Lock_Unlock_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(81, 496);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(164, 64);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // Hide_Unhide_btn
            // 
            this.Hide_Unhide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.Hide_Unhide_btn.FlatAppearance.BorderSize = 0;
            this.Hide_Unhide_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.Hide_Unhide_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(62)))), ((int)(((byte)(47)))));
            this.Hide_Unhide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_Unhide_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide_Unhide_btn.ForeColor = System.Drawing.Color.White;
            this.Hide_Unhide_btn.Image = global::SecureME.Properties.Resources.UNHIDDEN_PIC;
            this.Hide_Unhide_btn.Location = new System.Drawing.Point(87, 330);
            this.Hide_Unhide_btn.Name = "Hide_Unhide_btn";
            this.Hide_Unhide_btn.Size = new System.Drawing.Size(153, 142);
            this.Hide_Unhide_btn.TabIndex = 1;
            this.Hide_Unhide_btn.Text = "Unhidden";
            this.Hide_Unhide_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Hide_Unhide_btn.UseVisualStyleBackColor = false;
            this.Hide_Unhide_btn.Click += new System.EventHandler(this.Hide_Unhide_btn_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(82, 325);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(164, 153);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 22;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SecureME.Properties.Resources.BOX_SHADOW_PIC;
            this.pictureBox4.Location = new System.Drawing.Point(82, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(341, 261);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SecureME.Properties.Resources.BOX_SHADOW_PIC;
            this.pictureBox5.Location = new System.Drawing.Point(436, 58);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(341, 261);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(85, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "* Built to be FREE";
            // 
            // MAIN_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 581);
            this.Controls.Add(this.main_menu_panel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit_btn_2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.About_btn);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.HELP_btn);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Selected_Folders_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Selected_Files_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lock_Unlock_btn);
            this.Controls.Add(this.Main_Bar_Panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Change_PWD_btn2);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.Hide_Unhide_btn);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MAIN_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecureME";
            this.Deactivate += new System.EventHandler(this.Main_Form_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Main_Bar_Panel.ResumeLayout(false);
            this.main_menu_panel.ResumeLayout(false);
            this.main_menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Main_Bar_Panel;
        private System.Windows.Forms.Panel main_menu_panel;
        private System.Windows.Forms.Button main_menu_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Lock_Unlock_btn;
        private System.Windows.Forms.Button Selected_Files_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Selected_Folders_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Exit_btn_2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button About_btn;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button HELP_btn;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Change_PWD_btn2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button Hide_Unhide_btn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label Warring_lbl;
        private System.Windows.Forms.Timer Warring_Timer;
        private System.Windows.Forms.Label Internet_Check_lbl;
        private System.Windows.Forms.Button Change_PWD_btn;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitleBar_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Status_PIC;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IS_64bit_OS_lbl;
        private System.Windows.Forms.Label Computers_Name_lbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

