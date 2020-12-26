 namespace UserManagement
{
    partial class frmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.lblVerifyPass = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpGridview = new System.Windows.Forms.GroupBox();
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picIMGPass2 = new System.Windows.Forms.PictureBox();
            this.picIMGPass1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSecurity = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAsnwer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.rdLimitedUser = new System.Windows.Forms.RadioButton();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.grpActive = new System.Windows.Forms.GroupBox();
            this.rdInActive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGridview.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass1)).BeginInit();
            this.grpAccount.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.grpActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Name = "lblUserName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Name = "lblPassword";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtVerifyPassword, "txtVerifyPassword");
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.UseSystemPasswordChar = true;
            this.txtVerifyPassword.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtVerifyPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerifyPassword_KeyDown);
            this.txtVerifyPassword.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // lblVerifyPass
            // 
            resources.ApplyResources(this.lblVerifyPass, "lblVerifyPass");
            this.lblVerifyPass.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyPass.Name = "lblVerifyPass";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // grpGridview
            // 
            resources.ApplyResources(this.grpGridview, "grpGridview");
            this.grpGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpGridview.Controls.Add(this.dataGridView1);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.TabStop = false;
            // 
            // grpUserDetail
            // 
            resources.ApplyResources(this.grpUserDetail, "grpUserDetail");
            this.grpUserDetail.BackColor = System.Drawing.Color.Transparent;
            this.grpUserDetail.Controls.Add(this.label7);
            this.grpUserDetail.Controls.Add(this.picIMGPass2);
            this.grpUserDetail.Controls.Add(this.picIMGPass1);
            this.grpUserDetail.Controls.Add(this.label10);
            this.grpUserDetail.Controls.Add(this.label9);
            this.grpUserDetail.Controls.Add(this.label4);
            this.grpUserDetail.Controls.Add(this.label3);
            this.grpUserDetail.Controls.Add(this.label8);
            this.grpUserDetail.Controls.Add(this.cmbSecurity);
            this.grpUserDetail.Controls.Add(this.txtEmail);
            this.grpUserDetail.Controls.Add(this.lblUserName);
            this.grpUserDetail.Controls.Add(this.label5);
            this.grpUserDetail.Controls.Add(this.txtAsnwer);
            this.grpUserDetail.Controls.Add(this.lblPassword);
            this.grpUserDetail.Controls.Add(this.label6);
            this.grpUserDetail.Controls.Add(this.txtUserName);
            this.grpUserDetail.Controls.Add(this.label2);
            this.grpUserDetail.Controls.Add(this.txtPassword);
            this.grpUserDetail.Controls.Add(this.lblVerifyPass);
            this.grpUserDetail.Controls.Add(this.txtVerifyPassword);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Name = "label7";
            // 
            // picIMGPass2
            // 
            this.picIMGPass2.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass2.Image = global::UserManagement.Properties.Resources.picIMGPass_Image;
            resources.ApplyResources(this.picIMGPass2, "picIMGPass2");
            this.picIMGPass2.Name = "picIMGPass2";
            this.picIMGPass2.TabStop = false;
            this.picIMGPass2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass2_MouseDown);
            this.picIMGPass2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass2_MouseUp);
            // 
            // picIMGPass1
            // 
            this.picIMGPass1.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass1.Image = global::UserManagement.Properties.Resources.picIMGPass_Image;
            resources.ApplyResources(this.picIMGPass1, "picIMGPass1");
            this.picIMGPass1.Name = "picIMGPass1";
            this.picIMGPass1.TabStop = false;
            this.picIMGPass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseDown);
            this.picIMGPass1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseUp);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Name = "label9";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Name = "label8";
            // 
            // cmbSecurity
            // 
            this.cmbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbSecurity, "cmbSecurity");
            this.cmbSecurity.FormattingEnabled = true;
            this.cmbSecurity.Items.AddRange(new object[] {
            resources.GetString("cmbSecurity.Items"),
            resources.GetString("cmbSecurity.Items1"),
            resources.GetString("cmbSecurity.Items2"),
            resources.GetString("cmbSecurity.Items3"),
            resources.GetString("cmbSecurity.Items4")});
            this.cmbSecurity.Name = "cmbSecurity";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtEmail.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // txtAsnwer
            // 
            this.txtAsnwer.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtAsnwer, "txtAsnwer");
            this.txtAsnwer.Name = "txtAsnwer";
            this.txtAsnwer.UseSystemPasswordChar = true;
            this.txtAsnwer.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtAsnwer.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // rdAdmin
            // 
            resources.ApplyResources(this.rdAdmin, "rdAdmin");
            this.rdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmin.Checked = true;
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.TabStop = true;
            this.rdAdmin.UseVisualStyleBackColor = false;
            // 
            // grpAccount
            // 
            resources.ApplyResources(this.grpAccount, "grpAccount");
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.rdLimitedUser);
            this.grpAccount.Controls.Add(this.rdAdmin);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.TabStop = false;
            // 
            // rdLimitedUser
            // 
            resources.ApplyResources(this.rdLimitedUser, "rdLimitedUser");
            this.rdLimitedUser.BackColor = System.Drawing.Color.Transparent;
            this.rdLimitedUser.Name = "rdLimitedUser";
            this.rdLimitedUser.UseVisualStyleBackColor = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::UserManagement.Properties.Resources.titlebg;
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
            // lblTotalRecords
            // 
            resources.ApplyResources(this.lblTotalRecords, "lblTotalRecords");
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Name = "lblTotalRecords";
            // 
            // grpActive
            // 
            resources.ApplyResources(this.grpActive, "grpActive");
            this.grpActive.BackColor = System.Drawing.Color.Transparent;
            this.grpActive.Controls.Add(this.rdInActive);
            this.grpActive.Controls.Add(this.rdActive);
            this.grpActive.Name = "grpActive";
            this.grpActive.TabStop = false;
            // 
            // rdInActive
            // 
            resources.ApplyResources(this.rdInActive, "rdInActive");
            this.rdInActive.BackColor = System.Drawing.Color.Transparent;
            this.rdInActive.Name = "rdInActive";
            this.rdInActive.UseVisualStyleBackColor = false;
            // 
            // rdActive
            // 
            resources.ApplyResources(this.rdActive, "rdActive");
            this.rdActive.BackColor = System.Drawing.Color.Transparent;
            this.rdActive.Checked = true;
            this.rdActive.Name = "rdActive";
            this.rdActive.TabStop = true;
            this.rdActive.UseVisualStyleBackColor = false;
            // 
            // lblCount
            // 
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Name = "lblCount";
            // 
            // frmUserManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserManagement.Properties.Resources.back;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.grpActive);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpUserDetail);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserManagement";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGridview.ResumeLayout(false);
            this.grpUserDetail.ResumeLayout(false);
            this.grpUserDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass1)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.grpActive.ResumeLayout(false);
            this.grpActive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtVerifyPassword;
        private System.Windows.Forms.Label lblVerifyPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpGridview;
        private System.Windows.Forms.GroupBox grpUserDetail;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.RadioButton rdLimitedUser;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.ComboBox cmbSecurity;
        public System.Windows.Forms.TextBox txtAsnwer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picIMGPass2;
        private System.Windows.Forms.PictureBox picIMGPass1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpActive;
        private System.Windows.Forms.RadioButton rdInActive;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.Label lblCount;
    }
}