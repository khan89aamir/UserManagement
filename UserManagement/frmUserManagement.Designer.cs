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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.rdLimitedUser = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.rdBlock = new System.Windows.Forms.RadioButton();
            this.grpIsBlock = new System.Windows.Forms.GroupBox();
            this.rdUnblocked = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGridview.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpIsBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(18, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(120, 17);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Enter User Name :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(18, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 17);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Enter Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(181, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(206, 25);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(181, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.MouseFoucsLeave);
            this.txtPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseDown);
            this.txtPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseUp);
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.BackColor = System.Drawing.Color.White;
            this.txtVerifyPassword.Location = new System.Drawing.Point(181, 97);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.Size = new System.Drawing.Size(206, 25);
            this.txtVerifyPassword.TabIndex = 3;
            this.txtVerifyPassword.UseSystemPasswordChar = true;
            this.txtVerifyPassword.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtVerifyPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerifyPassword_KeyDown);
            this.txtVerifyPassword.Leave += new System.EventHandler(this.MouseFoucsLeave);
            this.txtVerifyPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseDown);
            this.txtVerifyPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseUp);
            // 
            // lblVerifyPass
            // 
            this.lblVerifyPass.AutoSize = true;
            this.lblVerifyPass.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyPass.Location = new System.Drawing.Point(18, 102);
            this.lblVerifyPass.Name = "lblVerifyPass";
            this.lblVerifyPass.Size = new System.Drawing.Size(113, 17);
            this.lblVerifyPass.TabIndex = 18;
            this.lblVerifyPass.Text = "Verify Password :";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(471, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(389, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(227, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(145, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(56, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(307, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 25);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(562, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // grpGridview
            // 
            this.grpGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpGridview.Controls.Add(this.dataGridView1);
            this.grpGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.Location = new System.Drawing.Point(26, 422);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.Size = new System.Drawing.Size(575, 175);
            this.grpGridview.TabIndex = 37;
            this.grpGridview.TabStop = false;
            this.grpGridview.Text = "List of Users";
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.BackColor = System.Drawing.Color.Transparent;
            this.grpUserDetail.Controls.Add(this.label10);
            this.grpUserDetail.Controls.Add(this.label9);
            this.grpUserDetail.Controls.Add(this.label7);
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
            this.grpUserDetail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserDetail.Location = new System.Drawing.Point(56, 90);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Size = new System.Drawing.Size(488, 255);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "User Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(389, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 240;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(474, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 239;
            this.label9.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(389, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 238;
            this.label7.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(389, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 237;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(389, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 236;
            this.label3.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(389, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 235;
            this.label8.Text = "*";
            // 
            // cmbSecurity
            // 
            this.cmbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurity.FormattingEnabled = true;
            this.cmbSecurity.Items.AddRange(new object[] {
            "In what city or town was your first job?",
            "What was your childhood nickname? ",
            "What was your favorite place to visit as a child?",
            "Where did you vacation last year?",
            "Who was your childhood hero? "});
            this.cmbSecurity.Location = new System.Drawing.Point(181, 174);
            this.cmbSecurity.Name = "cmbSecurity";
            this.cmbSecurity.Size = new System.Drawing.Size(291, 27);
            this.cmbSecurity.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(181, 135);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 26);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtEmail.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 182;
            this.label5.Text = "E-Mail :";
            // 
            // txtAsnwer
            // 
            this.txtAsnwer.BackColor = System.Drawing.Color.White;
            this.txtAsnwer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsnwer.Location = new System.Drawing.Point(181, 214);
            this.txtAsnwer.MaxLength = 12;
            this.txtAsnwer.Name = "txtAsnwer";
            this.txtAsnwer.Size = new System.Drawing.Size(206, 26);
            this.txtAsnwer.TabIndex = 6;
            this.txtAsnwer.UseSystemPasswordChar = true;
            this.txtAsnwer.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtAsnwer.Leave += new System.EventHandler(this.MouseFoucsLeave);
            this.txtAsnwer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseDown);
            this.txtAsnwer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 184;
            this.label6.Text = "Enter Answer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 183;
            this.label2.Text = "Select Security Question :";
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmin.Checked = true;
            this.rdAdmin.Location = new System.Drawing.Point(24, 25);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(106, 21);
            this.rdAdmin.TabIndex = 0;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Administrator";
            this.rdAdmin.UseVisualStyleBackColor = false;
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.label11);
            this.grpAccount.Controls.Add(this.rdLimitedUser);
            this.grpAccount.Controls.Add(this.rdAdmin);
            this.grpAccount.Location = new System.Drawing.Point(56, 351);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(272, 62);
            this.grpAccount.TabIndex = 0;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Select Account Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(253, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 243;
            this.label11.Text = "*";
            // 
            // rdLimitedUser
            // 
            this.rdLimitedUser.AutoSize = true;
            this.rdLimitedUser.BackColor = System.Drawing.Color.Transparent;
            this.rdLimitedUser.Location = new System.Drawing.Point(155, 25);
            this.rdLimitedUser.Name = "rdLimitedUser";
            this.rdLimitedUser.Size = new System.Drawing.Size(103, 21);
            this.rdLimitedUser.TabIndex = 1;
            this.rdLimitedUser.Text = "Limited User";
            this.rdLimitedUser.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 40);
            this.panel2.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "User Management";
            // 
            // rdBlock
            // 
            this.rdBlock.AutoSize = true;
            this.rdBlock.BackColor = System.Drawing.Color.Transparent;
            this.rdBlock.Location = new System.Drawing.Point(14, 24);
            this.rdBlock.Name = "rdBlock";
            this.rdBlock.Size = new System.Drawing.Size(74, 21);
            this.rdBlock.TabIndex = 0;
            this.rdBlock.Text = "Blocked";
            this.rdBlock.UseVisualStyleBackColor = false;
            // 
            // grpIsBlock
            // 
            this.grpIsBlock.BackColor = System.Drawing.Color.Transparent;
            this.grpIsBlock.Controls.Add(this.rdUnblocked);
            this.grpIsBlock.Controls.Add(this.rdBlock);
            this.grpIsBlock.Location = new System.Drawing.Point(335, 351);
            this.grpIsBlock.Name = "grpIsBlock";
            this.grpIsBlock.Size = new System.Drawing.Size(209, 62);
            this.grpIsBlock.TabIndex = 1;
            this.grpIsBlock.TabStop = false;
            this.grpIsBlock.Text = "Change Block Status";
            // 
            // rdUnblocked
            // 
            this.rdUnblocked.AutoSize = true;
            this.rdUnblocked.BackColor = System.Drawing.Color.Transparent;
            this.rdUnblocked.Location = new System.Drawing.Point(107, 25);
            this.rdUnblocked.Name = "rdUnblocked";
            this.rdUnblocked.Size = new System.Drawing.Size(89, 21);
            this.rdUnblocked.TabIndex = 1;
            this.rdUnblocked.Text = "Unblocked";
            this.rdUnblocked.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 180;
            this.label1.Text = "Total Records : 0";
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpIsBlock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpUserDetail);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUserManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGridview.ResumeLayout(false);
            this.grpUserDetail.ResumeLayout(false);
            this.grpUserDetail.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpIsBlock.ResumeLayout(false);
            this.grpIsBlock.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdBlock;
        private System.Windows.Forms.GroupBox grpIsBlock;
        private System.Windows.Forms.RadioButton rdUnblocked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSecurity;
        public System.Windows.Forms.TextBox txtAsnwer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}