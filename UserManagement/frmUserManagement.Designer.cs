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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.lblVerifyPass = new System.Windows.Forms.Label();
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpUserDetail = new gGlowBox.gGlowGroupBox();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.grpGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpAccount = new gGlowBox.gGlowGroupBox();
            this.rdLimitedUser = new System.Windows.Forms.RadioButton();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.grpActive = new gGlowBox.gGlowGroupBox();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.rdInActive = new System.Windows.Forms.RadioButton();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).BeginInit();
            this.grpGridview.Panel.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.grpActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
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
            this.grpUserDetail.SetEffectType(this.txtUserName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.grpUserDetail.SetsGlowColor(this.txtUserName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtUserName.sGlowColor"))));
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtPassword, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.grpUserDetail.SetsGlowColor(this.txtPassword, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtPassword.sGlowColor"))));
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtVerifyPassword, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtVerifyPassword, "txtVerifyPassword");
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.grpUserDetail.SetsGlowColor(this.txtVerifyPassword, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtVerifyPassword.sGlowColor"))));
            this.txtVerifyPassword.UseSystemPasswordChar = true;
            this.txtVerifyPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerifyPassword_KeyDown);
            // 
            // lblVerifyPass
            // 
            resources.ApplyResources(this.lblVerifyPass, "lblVerifyPass");
            this.lblVerifyPass.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyPass.Name = "lblVerifyPass";
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
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.grpUserDetail.SetEffectType(this.txtEmail, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.grpUserDetail.SetsGlowColor(this.txtEmail, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtEmail.sGlowColor"))));
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
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
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Values.Image = global::UserManagement.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = resources.GetString("btnCancel.Values.Text");
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Values.Image = global::UserManagement.Properties.Resources.btnDelete_Values_Image;
            this.btnDelete.Values.Text = resources.GetString("btnDelete.Values.Text");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Values.Image = global::UserManagement.Properties.Resources.btnUpdate_Values_Image;
            this.btnUpdate.Values.Text = resources.GetString("btnUpdate.Values.Text");
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Values.Image = global::UserManagement.Properties.Resources.btnEdit_Values_Image;
            this.btnEdit.Values.Text = resources.GetString("btnEdit.Values.Text");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Values.Image = global::UserManagement.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = resources.GetString("btnSave.Values.Text");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Values.Image = global::UserManagement.Properties.Resources.btnAdd_Values_Image;
            this.btnAdd.Values.Text = resources.GetString("btnAdd.Values.Text");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpKrytonHeader
            // 
            resources.ApplyResources(this.grpKrytonHeader, "grpKrytonHeader");
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
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
            this.grpUserDetail.Controls.Add(this.label7);
            this.grpUserDetail.Controls.Add(this.lblUserName);
            this.grpUserDetail.Controls.Add(this.picIMGPass2);
            this.grpUserDetail.Controls.Add(this.txtVerifyPassword);
            this.grpUserDetail.Controls.Add(this.picIMGPass1);
            this.grpUserDetail.Controls.Add(this.lblVerifyPass);
            this.grpUserDetail.Controls.Add(this.label10);
            this.grpUserDetail.Controls.Add(this.txtPassword);
            this.grpUserDetail.Controls.Add(this.label9);
            this.grpUserDetail.Controls.Add(this.label2);
            this.grpUserDetail.Controls.Add(this.label4);
            this.grpUserDetail.Controls.Add(this.txtUserName);
            this.grpUserDetail.Controls.Add(this.label3);
            this.grpUserDetail.Controls.Add(this.label6);
            this.grpUserDetail.Controls.Add(this.label8);
            this.grpUserDetail.Controls.Add(this.lblPassword);
            this.grpUserDetail.Controls.Add(this.cmbSecurity);
            this.grpUserDetail.Controls.Add(this.txtAsnwer);
            this.grpUserDetail.Controls.Add(this.txtEmail);
            this.grpUserDetail.Controls.Add(this.label5);
            resources.ApplyResources(this.grpUserDetail, "grpUserDetail");
            this.grpUserDetail.GlowAmount = 22;
            this.grpUserDetail.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpUserDetail.GlowFeather = 60;
            this.grpUserDetail.GlowOn = true;
            this.grpUserDetail.Name = "grpUserDetail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // grpGridview
            // 
            resources.ApplyResources(this.grpGridview, "grpGridview");
            this.grpGridview.Name = "grpGridview";
            // 
            // grpGridview.Panel
            // 
            this.grpGridview.Panel.Controls.Add(this.dataGridView1);
            this.grpGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.ValuesPrimary.Heading = resources.GetString("grpGridview.ValuesPrimary.Heading");
            this.grpGridview.ValuesPrimary.Image = global::UserManagement.Properties.Resources.kryptonHeaderGroup1_ValuesPrimary_Image;
            this.grpGridview.ValuesSecondary.Heading = resources.GetString("grpGridview.ValuesSecondary.Heading");
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.kryptonHeaderGroup1, "kryptonHeaderGroup1");
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.grpAccount);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup1.ValuesPrimary.Heading");
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.rdLimitedUser);
            this.grpAccount.Controls.Add(this.rdAdmin);
            resources.ApplyResources(this.grpAccount, "grpAccount");
            this.grpAccount.GlowAmount = 22;
            this.grpAccount.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpAccount.GlowFeather = 60;
            this.grpAccount.GlowOn = true;
            this.grpAccount.Name = "grpAccount";
            // 
            // rdLimitedUser
            // 
            resources.ApplyResources(this.rdLimitedUser, "rdLimitedUser");
            this.rdLimitedUser.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.SetEffectType(this.rdLimitedUser, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdLimitedUser.Name = "rdLimitedUser";
            this.grpAccount.SetsGlowColor(this.rdLimitedUser, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdLimitedUser.sGlowColor"))));
            this.rdLimitedUser.UseVisualStyleBackColor = false;
            // 
            // rdAdmin
            // 
            resources.ApplyResources(this.rdAdmin, "rdAdmin");
            this.rdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmin.Checked = true;
            this.grpAccount.SetEffectType(this.rdAdmin, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdAdmin.Name = "rdAdmin";
            this.grpAccount.SetsGlowColor(this.rdAdmin, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdAdmin.sGlowColor"))));
            this.rdAdmin.TabStop = true;
            this.rdAdmin.UseVisualStyleBackColor = false;
            // 
            // grpActive
            // 
            this.grpActive.BackColor = System.Drawing.Color.Transparent;
            this.grpActive.Controls.Add(this.rdInActive);
            this.grpActive.Controls.Add(this.rdActive);
            resources.ApplyResources(this.grpActive, "grpActive");
            this.grpActive.GlowAmount = 22;
            this.grpActive.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpActive.GlowFeather = 60;
            this.grpActive.GlowOn = true;
            this.grpActive.Name = "grpActive";
            // 
            // rdActive
            // 
            resources.ApplyResources(this.rdActive, "rdActive");
            this.rdActive.BackColor = System.Drawing.Color.Transparent;
            this.rdActive.Checked = true;
            this.grpActive.SetEffectType(this.rdActive, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdActive.Name = "rdActive";
            this.grpActive.SetsGlowColor(this.rdActive, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdActive.sGlowColor"))));
            this.rdActive.TabStop = true;
            this.rdActive.UseVisualStyleBackColor = false;
            // 
            // rdInActive
            // 
            resources.ApplyResources(this.rdInActive, "rdInActive");
            this.rdInActive.BackColor = System.Drawing.Color.Transparent;
            this.grpActive.SetEffectType(this.rdInActive, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdInActive.Name = "rdInActive";
            this.grpActive.SetsGlowColor(this.rdInActive, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdInActive.sGlowColor"))));
            this.rdInActive.UseVisualStyleBackColor = false;
            // 
            // kryptonHeaderGroup2
            // 
            resources.ApplyResources(this.kryptonHeaderGroup2, "kryptonHeaderGroup2");
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.grpActive);
            this.kryptonHeaderGroup2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup2.ValuesPrimary.Heading");
            this.kryptonHeaderGroup2.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup2.ValuesPrimary.Image")));
            // 
            // frmUserManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserManagement.Properties.Resources.back_green;
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserManagement";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpUserDetail.ResumeLayout(false);
            this.grpUserDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).EndInit();
            this.grpGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).EndInit();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpActive.ResumeLayout(false);
            this.grpActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label12;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private gGlowBox.gGlowGroupBox grpUserDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox grpAccount;
        private System.Windows.Forms.RadioButton rdLimitedUser;
        private System.Windows.Forms.RadioButton rdAdmin;
        private gGlowBox.gGlowGroupBox grpActive;
        private System.Windows.Forms.RadioButton rdInActive;
        private System.Windows.Forms.RadioButton rdActive;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
    }
}