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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSecurity = new System.Windows.Forms.ComboBox();
            this.txtAsnwer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtRetrivePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picIMGPass = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
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
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.BackgroundImage = global::UserManagement.Properties.Resources.B_click;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
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
            resources.ApplyResources(this.cmbSecurity, "cmbSecurity");
            this.cmbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurity.FormattingEnabled = true;
            this.cmbSecurity.Items.AddRange(new object[] {
            resources.GetString("cmbSecurity.Items"),
            resources.GetString("cmbSecurity.Items1"),
            resources.GetString("cmbSecurity.Items2"),
            resources.GetString("cmbSecurity.Items3"),
            resources.GetString("cmbSecurity.Items4")});
            this.cmbSecurity.Name = "cmbSecurity";
            // 
            // txtAsnwer
            // 
            resources.ApplyResources(this.txtAsnwer, "txtAsnwer");
            this.txtAsnwer.BackColor = System.Drawing.Color.White;
            this.txtAsnwer.Name = "txtAsnwer";
            this.txtAsnwer.UseSystemPasswordChar = true;
            this.txtAsnwer.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtAsnwer.Leave += new System.EventHandler(this.txtUserName_Leave);
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
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackgroundImage = global::UserManagement.Properties.Resources.B_click;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // txtRetrivePassword
            // 
            resources.ApplyResources(this.txtRetrivePassword, "txtRetrivePassword");
            this.txtRetrivePassword.BackColor = System.Drawing.Color.White;
            this.txtRetrivePassword.Name = "txtRetrivePassword";
            this.txtRetrivePassword.ReadOnly = true;
            this.txtRetrivePassword.UseSystemPasswordChar = true;
            this.txtRetrivePassword.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtRetrivePassword.Leave += new System.EventHandler(this.txtUserName_Leave);
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
            resources.ApplyResources(this.picIMGPass, "picIMGPass");
            this.picIMGPass.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass.Image = global::UserManagement.Properties.Resources.picIMGPass_Image;
            this.picIMGPass.Name = "picIMGPass";
            this.picIMGPass.TabStop = false;
            this.picIMGPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass_MouseDown);
            this.picIMGPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass_MouseUp);
            // 
            // pnlTitle
            // 
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.BackgroundImage = global::UserManagement.Properties.Resources.titlebg;
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
            // frmForgetPassword
            // 
            this.AcceptButton = this.btnSubmit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserManagement.Properties.Resources.back;
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.picIMGPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRetrivePassword);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSecurity);
            this.Controls.Add(this.txtAsnwer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSecurity;
        public System.Windows.Forms.TextBox txtAsnwer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TextBox txtRetrivePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picIMGPass;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label12;
    }
}