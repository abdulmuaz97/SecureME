namespace SecureME
{
    partial class LOGIN_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_FRM));
            this.Title_bar_lbl = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Show_Pass_btn = new System.Windows.Forms.Button();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EXIT_BTN = new System.Windows.Forms.Button();
            this.LOGIN_BTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shadow_picBox2 = new System.Windows.Forms.PictureBox();
            this.shadow_picBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadow_picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadow_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_bar_lbl
            // 
            this.Title_bar_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Title_bar_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_bar_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_bar_lbl.ForeColor = System.Drawing.Color.White;
            this.Title_bar_lbl.Location = new System.Drawing.Point(0, 0);
            this.Title_bar_lbl.Name = "Title_bar_lbl";
            this.Title_bar_lbl.Size = new System.Drawing.Size(416, 57);
            this.Title_bar_lbl.TabIndex = 7;
            this.Title_bar_lbl.Text = "ACCESS REQUIRED!";
            this.Title_bar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title_bar_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_bar_lbl_MouseDown);
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.Color.White;
            this.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Username_txt.Location = new System.Drawing.Point(6, 7);
            this.Username_txt.MaxLength = 15;
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(337, 26);
            this.Username_txt.TabIndex = 2;
            this.Username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_txt_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Clear_btn);
            this.panel1.Controls.Add(this.Username_txt);
            this.panel1.Location = new System.Drawing.Point(33, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 41);
            this.panel1.TabIndex = 0;
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.White;
            this.Clear_btn.FlatAppearance.BorderSize = 0;
            this.Clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("Clear_btn.Image")));
            this.Clear_btn.Location = new System.Drawing.Point(302, 0);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(46, 41);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Clear_btn, "Clear Text");
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Show_Pass_btn);
            this.panel2.Controls.Add(this.Password_txt);
            this.panel2.Location = new System.Drawing.Point(33, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 41);
            this.panel2.TabIndex = 0;
            // 
            // Show_Pass_btn
            // 
            this.Show_Pass_btn.BackColor = System.Drawing.Color.White;
            this.Show_Pass_btn.FlatAppearance.BorderSize = 0;
            this.Show_Pass_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Show_Pass_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Show_Pass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Pass_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Pass_btn.ForeColor = System.Drawing.Color.White;
            this.Show_Pass_btn.Image = global::SecureME.Properties.Resources.EYE_PASSWORD_PIC;
            this.Show_Pass_btn.Location = new System.Drawing.Point(302, 0);
            this.Show_Pass_btn.Name = "Show_Pass_btn";
            this.Show_Pass_btn.Size = new System.Drawing.Size(46, 41);
            this.Show_Pass_btn.TabIndex = 6;
            this.Show_Pass_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Show_Pass_btn, "Show Password");
            this.Show_Pass_btn.UseVisualStyleBackColor = false;
            this.Show_Pass_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show_Pass_btn_MouseDown);
            this.Show_Pass_btn.MouseLeave += new System.EventHandler(this.Show_Pass_btn_MouseLeave);
            this.Show_Pass_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Show_Pass_btn_MouseUp);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.Color.White;
            this.Password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Password_txt.Location = new System.Drawing.Point(6, 7);
            this.Password_txt.MaxLength = 15;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(337, 26);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_txt.UseSystemPasswordChar = true;
            this.Password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_txt_KeyDown);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.username_lbl.Location = new System.Drawing.Point(30, 92);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(146, 17);
            this.username_lbl.TabIndex = 16;
            this.username_lbl.Text = "Username or Full Name";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pass_lbl.Location = new System.Drawing.Point(31, 167);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(64, 17);
            this.pass_lbl.TabIndex = 17;
            this.pass_lbl.Text = "Password";
            // 
            // Status_lbl
            // 
            this.Status_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Status_lbl.Location = new System.Drawing.Point(11, 62);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(392, 17);
            this.Status_lbl.TabIndex = 18;
            this.Status_lbl.Text = "Error username or password..!";
            this.Status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Status_lbl.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipTitle = "SecureME";
            // 
            // EXIT_BTN
            // 
            this.EXIT_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.EXIT_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EXIT_BTN.FlatAppearance.BorderSize = 0;
            this.EXIT_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.EXIT_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.EXIT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BTN.ForeColor = System.Drawing.Color.White;
            this.EXIT_BTN.Image = global::SecureME.Properties.Resources.EXIT_PIC;
            this.EXIT_BTN.Location = new System.Drawing.Point(1, 2);
            this.EXIT_BTN.Name = "EXIT_BTN";
            this.EXIT_BTN.Size = new System.Drawing.Size(63, 53);
            this.EXIT_BTN.TabIndex = 4;
            this.EXIT_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.EXIT_BTN, "Exit");
            this.EXIT_BTN.UseVisualStyleBackColor = false;
            this.EXIT_BTN.Click += new System.EventHandler(this.EXIT_BTN_Click);
            // 
            // LOGIN_BTN
            // 
            this.LOGIN_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGIN_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LOGIN_BTN.FlatAppearance.BorderSize = 0;
            this.LOGIN_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LOGIN_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.LOGIN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BTN.ForeColor = System.Drawing.Color.White;
            this.LOGIN_BTN.Image = global::SecureME.Properties.Resources.FORWARD_PIC;
            this.LOGIN_BTN.Location = new System.Drawing.Point(352, 2);
            this.LOGIN_BTN.Name = "LOGIN_BTN";
            this.LOGIN_BTN.Size = new System.Drawing.Size(63, 53);
            this.LOGIN_BTN.TabIndex = 3;
            this.LOGIN_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.LOGIN_BTN, "Login");
            this.LOGIN_BTN.UseVisualStyleBackColor = false;
            this.LOGIN_BTN.Click += new System.EventHandler(this.LOGIN_BTN_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shadow_picBox2
            // 
            this.shadow_picBox2.Image = ((System.Drawing.Image)(resources.GetObject("shadow_picBox2.Image")));
            this.shadow_picBox2.Location = new System.Drawing.Point(23, 184);
            this.shadow_picBox2.Name = "shadow_picBox2";
            this.shadow_picBox2.Size = new System.Drawing.Size(369, 47);
            this.shadow_picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shadow_picBox2.TabIndex = 14;
            this.shadow_picBox2.TabStop = false;
            // 
            // shadow_picBox
            // 
            this.shadow_picBox.Image = ((System.Drawing.Image)(resources.GetObject("shadow_picBox.Image")));
            this.shadow_picBox.Location = new System.Drawing.Point(23, 111);
            this.shadow_picBox.Name = "shadow_picBox";
            this.shadow_picBox.Size = new System.Drawing.Size(369, 47);
            this.shadow_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shadow_picBox.TabIndex = 14;
            this.shadow_picBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 8);
            this.label3.TabIndex = 30;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(408, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 198);
            this.label2.TabIndex = 29;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 198);
            this.label1.TabIndex = 28;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LOGIN_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.EXIT_BTN;
            this.ClientSize = new System.Drawing.Size(416, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOGIN_BTN);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.shadow_picBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EXIT_BTN);
            this.Controls.Add(this.Title_bar_lbl);
            this.Controls.Add(this.shadow_picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LOGIN_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCESS REQUIRED!";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.SET_PASSWORD_FRM_Deactivate);
            this.Load += new System.EventHandler(this.SET_PASSWORD_FRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadow_picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadow_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_bar_lbl;
        private System.Windows.Forms.Button EXIT_BTN;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.PictureBox shadow_picBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.PictureBox shadow_picBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Show_Pass_btn;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Button LOGIN_BTN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}