namespace SecureME
{
    partial class FOLDERS_DIALOG_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOLDERS_DIALOG_FRM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBox_Files = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title_bar_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Open_folders_btn = new System.Windows.Forms.Button();
            this.delete_item_btn = new System.Windows.Forms.Button();
            this.clear_all_btn = new System.Windows.Forms.Button();
            this.SELECT_FOLDERS_FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.Upload_lbl = new System.Windows.Forms.LinkLabel();
            this.Upload_picBOX = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Upload_picBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 48);
            this.panel1.TabIndex = 14;
            // 
            // ListBox_Files
            // 
            this.ListBox_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Files.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Files.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ListBox_Files.FormattingEnabled = true;
            this.ListBox_Files.HorizontalScrollbar = true;
            this.ListBox_Files.ItemHeight = 17;
            this.ListBox_Files.Location = new System.Drawing.Point(12, 51);
            this.ListBox_Files.Name = "ListBox_Files";
            this.ListBox_Files.Size = new System.Drawing.Size(679, 408);
            this.ListBox_Files.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 43);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // Title_bar_lbl
            // 
            this.Title_bar_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Title_bar_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_bar_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_bar_lbl.ForeColor = System.Drawing.Color.White;
            this.Title_bar_lbl.Location = new System.Drawing.Point(0, 0);
            this.Title_bar_lbl.Name = "Title_bar_lbl";
            this.Title_bar_lbl.Size = new System.Drawing.Size(703, 48);
            this.Title_bar_lbl.TabIndex = 16;
            this.Title_bar_lbl.Text = "                                                          SELECT THE SPECIFIC FOL" +
    "DER";
            this.Title_bar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_bar_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_bar_lbl_MouseDown);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipTitle = "SecureME";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Refresh_btn.FlatAppearance.BorderSize = 0;
            this.Refresh_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btn.Image = global::SecureME.Properties.Resources.REFRESH_PIC;
            this.Refresh_btn.Location = new System.Drawing.Point(67, 0);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(62, 48);
            this.Refresh_btn.TabIndex = 22;
            this.Refresh_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Refresh_btn, "Refresh");
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Image = global::SecureME.Properties.Resources.BACK_PIC;
            this.Back_btn.Location = new System.Drawing.Point(1, 0);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(62, 48);
            this.Back_btn.TabIndex = 20;
            this.Back_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Back_btn, "Save and Close");
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Open_folders_btn
            // 
            this.Open_folders_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Open_folders_btn.FlatAppearance.BorderSize = 0;
            this.Open_folders_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Open_folders_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.Open_folders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_folders_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_folders_btn.ForeColor = System.Drawing.Color.White;
            this.Open_folders_btn.Image = global::SecureME.Properties.Resources.OPEN_FILE_PIC;
            this.Open_folders_btn.Location = new System.Drawing.Point(506, 0);
            this.Open_folders_btn.Name = "Open_folders_btn";
            this.Open_folders_btn.Size = new System.Drawing.Size(63, 48);
            this.Open_folders_btn.TabIndex = 19;
            this.Open_folders_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Open_folders_btn, "Choose Files");
            this.Open_folders_btn.UseVisualStyleBackColor = false;
            this.Open_folders_btn.Click += new System.EventHandler(this.Open_folders_btn_Click);
            // 
            // delete_item_btn
            // 
            this.delete_item_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.delete_item_btn.FlatAppearance.BorderSize = 0;
            this.delete_item_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.delete_item_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.delete_item_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_item_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_item_btn.ForeColor = System.Drawing.Color.White;
            this.delete_item_btn.Image = global::SecureME.Properties.Resources.DELETE_PIC;
            this.delete_item_btn.Location = new System.Drawing.Point(572, 0);
            this.delete_item_btn.Name = "delete_item_btn";
            this.delete_item_btn.Size = new System.Drawing.Size(63, 48);
            this.delete_item_btn.TabIndex = 18;
            this.delete_item_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.delete_item_btn, "Remove Selected");
            this.delete_item_btn.UseVisualStyleBackColor = false;
            this.delete_item_btn.Click += new System.EventHandler(this.delete_item_btn_Click);
            // 
            // clear_all_btn
            // 
            this.clear_all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clear_all_btn.FlatAppearance.BorderSize = 0;
            this.clear_all_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clear_all_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.clear_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_all_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all_btn.ForeColor = System.Drawing.Color.White;
            this.clear_all_btn.Image = global::SecureME.Properties.Resources.CLEAR_ALL_PIC;
            this.clear_all_btn.Location = new System.Drawing.Point(638, 0);
            this.clear_all_btn.Name = "clear_all_btn";
            this.clear_all_btn.Size = new System.Drawing.Size(63, 48);
            this.clear_all_btn.TabIndex = 17;
            this.clear_all_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.clear_all_btn, "Remove All");
            this.clear_all_btn.UseVisualStyleBackColor = false;
            this.clear_all_btn.Click += new System.EventHandler(this.clear_all_btn_Click);
            // 
            // SELECT_FOLDERS_FBD
            // 
            this.SELECT_FOLDERS_FBD.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Upload_lbl
            // 
            this.Upload_lbl.ActiveLinkColor = System.Drawing.Color.Silver;
            this.Upload_lbl.AutoSize = true;
            this.Upload_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Upload_lbl.DisabledLinkColor = System.Drawing.Color.Silver;
            this.Upload_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_lbl.ForeColor = System.Drawing.Color.Silver;
            this.Upload_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Upload_lbl.LinkColor = System.Drawing.Color.Silver;
            this.Upload_lbl.Location = new System.Drawing.Point(146, 272);
            this.Upload_lbl.Name = "Upload_lbl";
            this.Upload_lbl.Size = new System.Drawing.Size(416, 21);
            this.Upload_lbl.TabIndex = 54;
            this.Upload_lbl.TabStop = true;
            this.Upload_lbl.Text = "NO FILES HERE...WOULD YOU LIKE TO CHOOSE SOME?";
            this.Upload_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Upload_lbl.VisitedLinkColor = System.Drawing.Color.Silver;
            this.Upload_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Upload_lbl_LinkClicked);
            // 
            // Upload_picBOX
            // 
            this.Upload_picBOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Upload_picBOX.Image = ((System.Drawing.Image)(resources.GetObject("Upload_picBOX.Image")));
            this.Upload_picBOX.Location = new System.Drawing.Point(301, 173);
            this.Upload_picBOX.Name = "Upload_picBOX";
            this.Upload_picBOX.Size = new System.Drawing.Size(100, 100);
            this.Upload_picBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Upload_picBOX.TabIndex = 53;
            this.Upload_picBOX.TabStop = false;
            this.Upload_picBOX.Click += new System.EventHandler(this.Upload_picBOX_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 8);
            this.label3.TabIndex = 59;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(695, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 421);
            this.label2.TabIndex = 58;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 421);
            this.label1.TabIndex = 57;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FOLDERS_DIALOG_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Upload_lbl);
            this.Controls.Add(this.Upload_picBOX);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.clear_all_btn);
            this.Controls.Add(this.delete_item_btn);
            this.Controls.Add(this.Open_folders_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListBox_Files);
            this.Controls.Add(this.Title_bar_lbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOLDERS_DIALOG_FRM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHOOSE FOLDERS OR DRIVERS";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FOLDERS_DIALOG_FRM_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.Upload_picBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBox_Files;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title_bar_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Open_folders_btn;
        private System.Windows.Forms.Button delete_item_btn;
        private System.Windows.Forms.Button clear_all_btn;
        private System.Windows.Forms.FolderBrowserDialog SELECT_FOLDERS_FBD;
        private System.Windows.Forms.LinkLabel Upload_lbl;
        private System.Windows.Forms.PictureBox Upload_picBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}