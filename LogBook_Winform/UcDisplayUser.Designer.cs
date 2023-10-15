namespace LogBook_Winform
{
    partial class UcDisplayUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblLastSeen = new System.Windows.Forms.Label();
            this.rbGreen = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cbOnline = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.cmbTestScore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbClassScore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelRb = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.rbRed = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbYellow = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cbDiamond3 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.pbUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDeleteDiamond = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnComment = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbDiamond1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.cbDiamond2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.panelRb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(8, 29);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(27, 23);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "ID";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(120, 29);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(181, 23);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "Name Surname Father";
            // 
            // lblLastSeen
            // 
            this.lblLastSeen.AutoSize = true;
            this.lblLastSeen.Location = new System.Drawing.Point(352, 29);
            this.lblLastSeen.Name = "lblLastSeen";
            this.lblLastSeen.Size = new System.Drawing.Size(78, 23);
            this.lblLastSeen.TabIndex = 3;
            this.lblLastSeen.Text = "05/05/23";
            // 
            // rbGreen
            // 
            this.rbGreen.BackColor = System.Drawing.Color.Transparent;
            this.rbGreen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGreen.CheckedState.BorderThickness = 0;
            this.rbGreen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGreen.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGreen.Location = new System.Drawing.Point(13, 5);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(15, 15);
            this.rbGreen.TabIndex = 4;
            this.rbGreen.Text = "guna2CustomRadioButton1";
            this.rbGreen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGreen.UncheckedState.BorderThickness = 2;
            this.rbGreen.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbGreen.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cbOnline
            // 
            this.cbOnline.BackColor = System.Drawing.Color.Transparent;
            this.cbOnline.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOnline.CheckedState.BorderRadius = 2;
            this.cbOnline.CheckedState.BorderThickness = 0;
            this.cbOnline.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOnline.Location = new System.Drawing.Point(713, 32);
            this.cbOnline.Name = "cbOnline";
            this.cbOnline.Size = new System.Drawing.Size(20, 20);
            this.cbOnline.TabIndex = 7;
            this.cbOnline.Text = "guna2CustomCheckBox1";
            this.cbOnline.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.cbOnline.UncheckedState.BorderRadius = 2;
            this.cbOnline.UncheckedState.BorderThickness = 0;
            this.cbOnline.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // cmbTestScore
            // 
            this.cmbTestScore.BackColor = System.Drawing.Color.Transparent;
            this.cmbTestScore.BorderColor = System.Drawing.Color.DarkOrchid;
            this.cmbTestScore.BorderRadius = 6;
            this.cmbTestScore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTestScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestScore.FocusedColor = System.Drawing.Color.DarkOrchid;
            this.cmbTestScore.FocusedState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.cmbTestScore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTestScore.ForeColor = System.Drawing.Color.DarkOrchid;
            this.cmbTestScore.ItemHeight = 30;
            this.cmbTestScore.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.cmbTestScore.Location = new System.Drawing.Point(788, 24);
            this.cmbTestScore.Name = "cmbTestScore";
            this.cmbTestScore.Size = new System.Drawing.Size(86, 36);
            this.cmbTestScore.TabIndex = 8;
            // 
            // cmbClassScore
            // 
            this.cmbClassScore.BackColor = System.Drawing.Color.Transparent;
            this.cmbClassScore.BorderColor = System.Drawing.Color.Green;
            this.cmbClassScore.BorderRadius = 6;
            this.cmbClassScore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClassScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassScore.FocusedColor = System.Drawing.Color.Green;
            this.cmbClassScore.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.cmbClassScore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClassScore.ForeColor = System.Drawing.Color.Green;
            this.cmbClassScore.ItemHeight = 30;
            this.cmbClassScore.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.cmbClassScore.Location = new System.Drawing.Point(1046, 24);
            this.cmbClassScore.Name = "cmbClassScore";
            this.cmbClassScore.Size = new System.Drawing.Size(86, 36);
            this.cmbClassScore.TabIndex = 9;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cmbClassScore);
            this.guna2Panel1.Controls.Add(this.cbDiamond3);
            this.guna2Panel1.Controls.Add(this.btnDeleteDiamond);
            this.guna2Panel1.Controls.Add(this.btnComment);
            this.guna2Panel1.Controls.Add(this.panelRb);
            this.guna2Panel1.Controls.Add(this.cbDiamond1);
            this.guna2Panel1.Controls.Add(this.cbDiamond2);
            this.guna2Panel1.Controls.Add(this.txtComment);
            this.guna2Panel1.Location = new System.Drawing.Point(-115, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1580, 80);
            this.guna2Panel1.TabIndex = 15;
            // 
            // panelRb
            // 
            this.panelRb.BackColor = System.Drawing.Color.Transparent;
            this.panelRb.Controls.Add(this.rbGreen);
            this.panelRb.Controls.Add(this.rbRed);
            this.panelRb.Controls.Add(this.rbYellow);
            this.panelRb.FillColor = System.Drawing.Color.Transparent;
            this.panelRb.FillColor2 = System.Drawing.Color.Transparent;
            this.panelRb.FillColor3 = System.Drawing.Color.Transparent;
            this.panelRb.FillColor4 = System.Drawing.Color.Transparent;
            this.panelRb.Location = new System.Drawing.Point(633, 29);
            this.panelRb.Name = "panelRb";
            this.panelRb.Size = new System.Drawing.Size(123, 23);
            this.panelRb.TabIndex = 19;
            // 
            // rbRed
            // 
            this.rbRed.BackColor = System.Drawing.Color.Transparent;
            this.rbRed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbRed.CheckedState.BorderThickness = 0;
            this.rbRed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbRed.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbRed.Location = new System.Drawing.Point(94, 5);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(15, 15);
            this.rbRed.TabIndex = 18;
            this.rbRed.Text = "guna2CustomRadioButton1";
            this.rbRed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbRed.UncheckedState.BorderThickness = 2;
            this.rbRed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbRed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbYellow
            // 
            this.rbYellow.BackColor = System.Drawing.Color.Transparent;
            this.rbYellow.CheckedState.BorderColor = System.Drawing.Color.Gold;
            this.rbYellow.CheckedState.BorderThickness = 0;
            this.rbYellow.CheckedState.FillColor = System.Drawing.Color.Gold;
            this.rbYellow.CheckedState.InnerColor = System.Drawing.Color.Gold;
            this.rbYellow.Location = new System.Drawing.Point(54, 5);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(15, 15);
            this.rbYellow.TabIndex = 17;
            this.rbYellow.Text = "guna2CustomRadioButton1";
            this.rbYellow.UncheckedState.BorderColor = System.Drawing.Color.Gold;
            this.rbYellow.UncheckedState.BorderThickness = 2;
            this.rbYellow.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbYellow.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cbDiamond3
            // 
            this.cbDiamond3.CheckedState.Image = global::LogBook_Winform.Properties.Resources.diamond_color_48;
            this.cbDiamond3.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.cbDiamond3.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.cbDiamond3.Image = global::LogBook_Winform.Properties.Resources.diamod_color_black48;
            this.cbDiamond3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cbDiamond3.ImageRotate = 0F;
            this.cbDiamond3.ImageSize = new System.Drawing.Size(40, 40);
            this.cbDiamond3.Location = new System.Drawing.Point(1265, 23);
            this.cbDiamond3.Name = "cbDiamond3";
            this.cbDiamond3.Size = new System.Drawing.Size(48, 36);
            this.cbDiamond3.TabIndex = 12;
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.ImageRotate = 0F;
            this.pbUserPicture.Location = new System.Drawing.Point(47, 8);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserPicture.Size = new System.Drawing.Size(56, 60);
            this.pbUserPicture.TabIndex = 1;
            this.pbUserPicture.TabStop = false;
            // 
            // btnDeleteDiamond
            // 
            this.btnDeleteDiamond.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeleteDiamond.HoverState.ImageSize = new System.Drawing.Size(66, 66);
            this.btnDeleteDiamond.Image = global::LogBook_Winform.Properties.Resources.buttonX;
            this.btnDeleteDiamond.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteDiamond.ImageRotate = 0F;
            this.btnDeleteDiamond.Location = new System.Drawing.Point(1319, 24);
            this.btnDeleteDiamond.Name = "btnDeleteDiamond";
            this.btnDeleteDiamond.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeleteDiamond.Size = new System.Drawing.Size(31, 28);
            this.btnDeleteDiamond.TabIndex = 13;
            // 
            // btnComment
            // 
            this.btnComment.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnComment.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnComment.Image = global::LogBook_Winform.Properties.Resources.comment;
            this.btnComment.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnComment.ImageRotate = 0F;
            this.btnComment.ImageSize = new System.Drawing.Size(30, 30);
            this.btnComment.Location = new System.Drawing.Point(1375, 20);
            this.btnComment.Name = "btnComment";
            this.btnComment.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnComment.Size = new System.Drawing.Size(41, 36);
            this.btnComment.TabIndex = 14;
            // 
            // cbDiamond1
            // 
            this.cbDiamond1.CheckedState.Image = global::LogBook_Winform.Properties.Resources.diamond_color_48;
            this.cbDiamond1.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.cbDiamond1.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.cbDiamond1.Image = global::LogBook_Winform.Properties.Resources.diamod_color_black48;
            this.cbDiamond1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cbDiamond1.ImageRotate = 0F;
            this.cbDiamond1.ImageSize = new System.Drawing.Size(40, 40);
            this.cbDiamond1.Location = new System.Drawing.Point(1177, 23);
            this.cbDiamond1.Name = "cbDiamond1";
            this.cbDiamond1.Size = new System.Drawing.Size(48, 36);
            this.cbDiamond1.TabIndex = 10;
            // 
            // cbDiamond2
            // 
            this.cbDiamond2.CheckedState.Image = global::LogBook_Winform.Properties.Resources.diamond_color_48;
            this.cbDiamond2.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.cbDiamond2.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.cbDiamond2.Image = global::LogBook_Winform.Properties.Resources.diamod_color_black48;
            this.cbDiamond2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cbDiamond2.ImageRotate = 0F;
            this.cbDiamond2.ImageSize = new System.Drawing.Size(40, 40);
            this.cbDiamond2.Location = new System.Drawing.Point(1221, 23);
            this.cbDiamond2.Name = "cbDiamond2";
            this.cbDiamond2.Size = new System.Drawing.Size(47, 36);
            this.cbDiamond2.TabIndex = 11;
            // 
            // txtComment
            // 
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Location = new System.Drawing.Point(1356, 24);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "";
            this.txtComment.SelectedText = "";
            this.txtComment.Size = new System.Drawing.Size(140, 32);
            this.txtComment.TabIndex = 20;
            this.txtComment.Visible = false;
            // 
            // UcDisplayUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTestScore);
            this.Controls.Add(this.cbOnline);
            this.Controls.Add(this.lblLastSeen);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.pbUserPicture);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcDisplayUser";
            this.Size = new System.Drawing.Size(1391, 80);
            this.guna2Panel1.ResumeLayout(false);
            this.panelRb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserPicture;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblLastSeen;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbGreen;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbOnline;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTestScore;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClassScore;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cbDiamond1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cbDiamond2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cbDiamond3;
        private Guna.UI2.WinForms.Guna2ImageButton btnDeleteDiamond;
        private Guna.UI2.WinForms.Guna2ImageButton btnComment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbYellow;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbRed;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelRb;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
    }
}
