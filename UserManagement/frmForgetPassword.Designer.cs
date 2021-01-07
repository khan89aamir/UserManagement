namespace UserManagement
{
    partial class frmForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPassword));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSecurity = new System.Windows.Forms.ComboBox();
            this.txtAsnwer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRetrivePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picIMGPass = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpUserDetail = new gGlowBox.gGlowGroupBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtUserName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.grpUserDetail.SetsGlowColor(this.txtUserName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtUserName.sGlowColor"))));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtEmail, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.grpUserDetail.SetsGlowColor(this.txtEmail, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtEmail.sGlowColor"))));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Name = "label3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Name = "label8";
            // 
            // cmbSecurity
            // 
            this.cmbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpUserDetail.SetEffectType(this.cmbSecurity, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.cmbSecurity, "cmbSecurity");
            this.cmbSecurity.FormattingEnabled = true;
            this.cmbSecurity.Items.AddRange(new object[] {
            resources.GetString("cmbSecurity.Items"),
            resources.GetString("cmbSecurity.Items1"),
            resources.GetString("cmbSecurity.Items2"),
            resources.GetString("cmbSecurity.Items3"),
            resources.GetString("cmbSecurity.Items4")});
            this.cmbSecurity.Name = "cmbSecurity";
            this.grpUserDetail.SetsGlowColor(this.cmbSecurity, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbSecurity.sGlowColor"))));
            // 
            // txtAsnwer
            // 
            this.txtAsnwer.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtAsnwer, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtAsnwer, "txtAsnwer");
            this.txtAsnwer.Name = "txtAsnwer";
            this.grpUserDetail.SetsGlowColor(this.txtAsnwer, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtAsnwer.sGlowColor"))));
            this.txtAsnwer.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Name = "label4";
            // 
            // txtRetrivePassword
            // 
            this.txtRetrivePassword.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtRetrivePassword, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtRetrivePassword, "txtRetrivePassword");
            this.txtRetrivePassword.Name = "txtRetrivePassword";
            this.txtRetrivePassword.ReadOnly = true;
            this.grpUserDetail.SetsGlowColor(this.txtRetrivePassword, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtRetrivePassword.sGlowColor"))));
            this.txtRetrivePassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Name = "label9";
            // 
            // picIMGPass
            // 
            this.picIMGPass.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass.Image = global::UserManagement.Properties.Resources.picIMGPass_Image;
            resources.ApplyResources(this.picIMGPass, "picIMGPass");
            this.picIMGPass.Name = "picIMGPass";
            this.picIMGPass.TabStop = false;
            this.picIMGPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass_MouseDown);
            this.picIMGPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass_MouseUp);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::UserManagement.Properties.Resources.titlebg_green;
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.Controls.Add(this.label12);
            this.pnlTitle.Name = "pnlTitle";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // grpKrytonHeader
            // 
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.grpKrytonHeader, "grpKrytonHeader");
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.grpUserDetail);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.ValuesPrimary.Heading = resources.GetString("grpKrytonHeader.ValuesPrimary.Heading");
            this.grpKrytonHeader.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpKrytonHeader.ValuesPrimary.Image")));
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.BackColor = System.Drawing.Color.Transparent;
            this.grpUserDetail.Controls.Add(this.label2);
            this.grpUserDetail.Controls.Add(this.txtUserName);
            this.grpUserDetail.Controls.Add(this.txtEmail);
            this.grpUserDetail.Controls.Add(this.label3);
            this.grpUserDetail.Controls.Add(this.label5);
            this.grpUserDetail.Controls.Add(this.picIMGPass);
            this.grpUserDetail.Controls.Add(this.label8);
            this.grpUserDetail.Controls.Add(this.label9);
            this.grpUserDetail.Controls.Add(this.label1);
            this.grpUserDetail.Controls.Add(this.label7);
            this.grpUserDetail.Controls.Add(this.label6);
            this.grpUserDetail.Controls.Add(this.txtRetrivePassword);
            this.grpUserDetail.Controls.Add(this.txtAsnwer);
            this.grpUserDetail.Controls.Add(this.label4);
            this.grpUserDetail.Controls.Add(this.cmbSecurity);
            resources.ApplyResources(this.grpUserDetail, "grpUserDetail");
            this.grpUserDetail.GlowAmount = 22;
            this.grpUserDetail.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpUserDetail.GlowFeather = 60;
            this.grpUserDetail.GlowOn = true;
            this.grpUserDetail.Name = "grpUserDetail";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSubmit.StateNormal.Content.LongText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Values.Image = global::UserManagement.Properties.Resources.btnSave_Values_Image;
            this.btnSubmit.Values.Text = resources.GetString("btnSubmit.Values.Text");
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Name = "btnReset";
            this.btnReset.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnReset.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Values.Image = global::UserManagement.Properties.Resources.btnCancel_Values_Image;
            this.btnReset.Values.Text = resources.GetString("btnReset.Values.Text");
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmForgetPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserManagement.Properties.Resources.back_green;
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgetPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpUserDetail.ResumeLayout(false);
            this.grpUserDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSecurity;
        public System.Windows.Forms.TextBox txtAsnwer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRetrivePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picIMGPass;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label12;
        private gGlowBox.gGlowGroupBox grpUserDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
    }
}