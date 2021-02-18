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
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtVerifyPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblVerifyPass = new System.Windows.Forms.Label();
            this.lblManEmail = new System.Windows.Forms.Label();
            this.lblManAnswer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblManVerifyPass = new System.Windows.Forms.Label();
            this.lblManPass = new System.Windows.Forms.Label();
            this.lblManUserName = new System.Windows.Forms.Label();
            this.cmbSecurity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAsnwer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpUserDetails = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpUserDetail = new gGlowBox.gGlowGroupBox();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.grpGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpAccountType = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpAccount = new gGlowBox.gGlowGroupBox();
            this.rdLimitedUser = new System.Windows.Forms.RadioButton();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.pnlTitle = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpActive = new gGlowBox.gGlowGroupBox();
            this.rdInActive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.grpActiveStatus = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picIMGPass2 = new System.Windows.Forms.PictureBox();
            this.picIMGPass1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserDetails.Panel)).BeginInit();
            this.grpUserDetails.Panel.SuspendLayout();
            this.grpUserDetails.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).BeginInit();
            this.grpGridview.Panel.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAccountType.Panel)).BeginInit();
            this.grpAccountType.Panel.SuspendLayout();
            this.grpAccountType.SuspendLayout();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.grpActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpActiveStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpActiveStatus.Panel)).BeginInit();
            this.grpActiveStatus.Panel.SuspendLayout();
            this.grpActiveStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Name = "lblUserName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Name = "lblPassword";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUserName.StateCommon.Border.Rounding = 10;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtVerifyPassword, "txtVerifyPassword");
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtVerifyPassword.StateCommon.Border.Rounding = 10;
            this.txtVerifyPassword.UseSystemPasswordChar = true;
            this.txtVerifyPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerifyPassword_KeyDown);
            // 
            // lblVerifyPass
            // 
            resources.ApplyResources(this.lblVerifyPass, "lblVerifyPass");
            this.lblVerifyPass.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyPass.ForeColor = System.Drawing.Color.White;
            this.lblVerifyPass.Name = "lblVerifyPass";
            // 
            // lblManEmail
            // 
            resources.ApplyResources(this.lblManEmail, "lblManEmail");
            this.lblManEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblManEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManEmail.Name = "lblManEmail";
            // 
            // lblManAnswer
            // 
            resources.ApplyResources(this.lblManAnswer, "lblManAnswer");
            this.lblManAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblManAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManAnswer.Name = "lblManAnswer";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Name = "label9";
            // 
            // lblManVerifyPass
            // 
            resources.ApplyResources(this.lblManVerifyPass, "lblManVerifyPass");
            this.lblManVerifyPass.BackColor = System.Drawing.Color.Transparent;
            this.lblManVerifyPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManVerifyPass.Name = "lblManVerifyPass";
            // 
            // lblManPass
            // 
            resources.ApplyResources(this.lblManPass, "lblManPass");
            this.lblManPass.BackColor = System.Drawing.Color.Transparent;
            this.lblManPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManPass.Name = "lblManPass";
            // 
            // lblManUserName
            // 
            resources.ApplyResources(this.lblManUserName, "lblManUserName");
            this.lblManUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblManUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManUserName.Name = "lblManUserName";
            // 
            // cmbSecurity
            // 
            this.cmbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurity.DropDownWidth = 285;
            resources.ApplyResources(this.cmbSecurity, "cmbSecurity");
            this.cmbSecurity.FormattingEnabled = true;
            this.cmbSecurity.Items.AddRange(new object[] {
            resources.GetString("cmbSecurity.Items"),
            resources.GetString("cmbSecurity.Items1"),
            resources.GetString("cmbSecurity.Items2"),
            resources.GetString("cmbSecurity.Items3"),
            resources.GetString("cmbSecurity.Items4")});
            this.cmbSecurity.Name = "cmbSecurity";
            this.cmbSecurity.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cmbSecurity.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSecurity.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbSecurity.SelectionChangeCommitted += new System.EventHandler(this.cmbSecurity_SelectionChangeCommitted);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 10;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Name = "lblEmail";
            // 
            // txtAsnwer
            // 
            this.txtAsnwer.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtAsnwer, "txtAsnwer");
            this.txtAsnwer.Name = "txtAsnwer";
            this.txtAsnwer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAsnwer.StateCommon.Border.Rounding = 10;
            this.txtAsnwer.UseSystemPasswordChar = true;
            // 
            // lblAnswer
            // 
            resources.ApplyResources(this.lblAnswer, "lblAnswer");
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Name = "lblAnswer";
            // 
            // lblSecurityQuestion
            // 
            resources.ApplyResources(this.lblSecurityQuestion, "lblSecurityQuestion");
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 5;
            this.btnCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Values.Image")));
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
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 5;
            this.btnDelete.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Values.Image")));
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
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 5;
            this.btnUpdate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Values.Image")));
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
            this.btnEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEdit.StateCommon.Border.Rounding = 5;
            this.btnEdit.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Values.Image")));
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
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 5;
            this.btnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Values.Image")));
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
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 5;
            this.btnAdd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnAdd.Values.Text = resources.GetString("btnAdd.Values.Text");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpUserDetails
            // 
            resources.ApplyResources(this.grpUserDetails, "grpUserDetails");
            this.grpUserDetails.HeaderVisibleSecondary = false;
            this.grpUserDetails.Name = "grpUserDetails";
            this.grpUserDetails.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpUserDetails.Panel
            // 
            this.grpUserDetails.Panel.Controls.Add(this.grpUserDetail);
            this.grpUserDetails.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpUserDetails.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpUserDetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpUserDetails.StateCommon.Border.Rounding = 10;
            this.grpUserDetails.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpUserDetails.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserDetails.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserDetails.ValuesPrimary.Heading = resources.GetString("grpKrytonHeader.ValuesPrimary.Heading");
            this.grpUserDetails.ValuesPrimary.Image = global::UserManagement.Properties.Resources.customersmall;
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.BackColor = System.Drawing.Color.Transparent;
            this.grpUserDetail.Controls.Add(this.lblManEmail);
            this.grpUserDetail.Controls.Add(this.lblUserName);
            this.grpUserDetail.Controls.Add(this.picIMGPass2);
            this.grpUserDetail.Controls.Add(this.txtVerifyPassword);
            this.grpUserDetail.Controls.Add(this.picIMGPass1);
            this.grpUserDetail.Controls.Add(this.lblVerifyPass);
            this.grpUserDetail.Controls.Add(this.lblManAnswer);
            this.grpUserDetail.Controls.Add(this.txtPassword);
            this.grpUserDetail.Controls.Add(this.label9);
            this.grpUserDetail.Controls.Add(this.lblSecurityQuestion);
            this.grpUserDetail.Controls.Add(this.lblManVerifyPass);
            this.grpUserDetail.Controls.Add(this.txtUserName);
            this.grpUserDetail.Controls.Add(this.lblManPass);
            this.grpUserDetail.Controls.Add(this.lblAnswer);
            this.grpUserDetail.Controls.Add(this.lblManUserName);
            this.grpUserDetail.Controls.Add(this.lblPassword);
            this.grpUserDetail.Controls.Add(this.cmbSecurity);
            this.grpUserDetail.Controls.Add(this.txtAsnwer);
            this.grpUserDetail.Controls.Add(this.txtEmail);
            this.grpUserDetail.Controls.Add(this.lblEmail);
            resources.ApplyResources(this.grpUserDetail, "grpUserDetail");
            this.grpUserDetail.GlowAmount = 20;
            this.grpUserDetail.GlowColorDefault = System.Drawing.Color.White;
            this.grpUserDetail.GlowFeather = 70;
            this.grpUserDetail.GlowOn = true;
            this.grpUserDetail.Name = "grpUserDetail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
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
            this.grpGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpGridview.Panel
            // 
            this.grpGridview.Panel.Controls.Add(this.dataGridView1);
            this.grpGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpGridview.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpGridview.StateCommon.Border.Rounding = 10;
            this.grpGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpGridview.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.grpGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.ValuesPrimary.Heading = resources.GetString("grpGridview.ValuesPrimary.Heading");
            this.grpGridview.ValuesPrimary.Image = global::UserManagement.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.grpGridview.ValuesSecondary.Heading = resources.GetString("grpGridview.ValuesSecondary.Heading");
            // 
            // grpAccountType
            // 
            this.grpAccountType.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.grpAccountType, "grpAccountType");
            this.grpAccountType.Name = "grpAccountType";
            this.grpAccountType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpAccountType.Panel
            // 
            this.grpAccountType.Panel.Controls.Add(this.grpAccount);
            this.grpAccountType.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpAccountType.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpAccountType.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpAccountType.StateCommon.Border.Rounding = 10;
            this.grpAccountType.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpAccountType.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpAccountType.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.grpAccountType.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountType.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountType.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup1.ValuesPrimary.Heading");
            this.grpAccountType.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.rdLimitedUser);
            this.grpAccount.Controls.Add(this.rdAdmin);
            resources.ApplyResources(this.grpAccount, "grpAccount");
            this.grpAccount.ForeColor = System.Drawing.Color.White;
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
            this.rdLimitedUser.ForeColor = System.Drawing.Color.White;
            this.rdLimitedUser.Name = "rdLimitedUser";
            this.grpAccount.SetsGlowColor(this.rdLimitedUser, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdLimitedUser.sGlowColor"))));
            this.grpAccount.SetUseEffect(this.rdLimitedUser, false);
            this.rdLimitedUser.UseVisualStyleBackColor = false;
            // 
            // rdAdmin
            // 
            resources.ApplyResources(this.rdAdmin, "rdAdmin");
            this.rdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmin.Checked = true;
            this.grpAccount.SetEffectType(this.rdAdmin, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdAdmin.ForeColor = System.Drawing.Color.White;
            this.rdAdmin.Name = "rdAdmin";
            this.grpAccount.SetsGlowColor(this.rdAdmin, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdAdmin.sGlowColor"))));
            this.rdAdmin.TabStop = true;
            this.grpAccount.SetUseEffect(this.rdAdmin, false);
            this.rdAdmin.UseVisualStyleBackColor = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.pnlTitle.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
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
            // rdInActive
            // 
            resources.ApplyResources(this.rdInActive, "rdInActive");
            this.rdInActive.BackColor = System.Drawing.Color.Transparent;
            this.grpActive.SetEffectType(this.rdInActive, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdInActive.ForeColor = System.Drawing.Color.White;
            this.rdInActive.Name = "rdInActive";
            this.grpActive.SetsGlowColor(this.rdInActive, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdInActive.sGlowColor"))));
            this.grpActive.SetUseEffect(this.rdInActive, false);
            this.rdInActive.UseVisualStyleBackColor = false;
            // 
            // rdActive
            // 
            resources.ApplyResources(this.rdActive, "rdActive");
            this.rdActive.BackColor = System.Drawing.Color.Transparent;
            this.rdActive.Checked = true;
            this.grpActive.SetEffectType(this.rdActive, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdActive.ForeColor = System.Drawing.Color.White;
            this.rdActive.Name = "rdActive";
            this.grpActive.SetsGlowColor(this.rdActive, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdActive.sGlowColor"))));
            this.rdActive.TabStop = true;
            this.grpActive.SetUseEffect(this.rdActive, false);
            this.rdActive.UseVisualStyleBackColor = false;
            // 
            // grpActiveStatus
            // 
            resources.ApplyResources(this.grpActiveStatus, "grpActiveStatus");
            this.grpActiveStatus.HeaderVisibleSecondary = false;
            this.grpActiveStatus.Name = "grpActiveStatus";
            this.grpActiveStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpActiveStatus.Panel
            // 
            this.grpActiveStatus.Panel.Controls.Add(this.grpActive);
            this.grpActiveStatus.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpActiveStatus.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpActiveStatus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpActiveStatus.StateCommon.Border.Rounding = 10;
            this.grpActiveStatus.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpActiveStatus.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActiveStatus.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActiveStatus.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup2.ValuesPrimary.Heading");
            this.grpActiveStatus.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup2.ValuesPrimary.Image")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // picIMGPass2
            // 
            this.picIMGPass2.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass2.Image = global::UserManagement.Properties.Resources.picIMGPass_Image1;
            resources.ApplyResources(this.picIMGPass2, "picIMGPass2");
            this.picIMGPass2.Name = "picIMGPass2";
            this.picIMGPass2.TabStop = false;
            this.picIMGPass2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass2_MouseDown);
            this.picIMGPass2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass2_MouseUp);
            // 
            // picIMGPass1
            // 
            this.picIMGPass1.BackColor = System.Drawing.Color.Transparent;
            this.picIMGPass1.Image = global::UserManagement.Properties.Resources.picIMGPass_Image1;
            resources.ApplyResources(this.picIMGPass1, "picIMGPass1");
            this.picIMGPass1.Name = "picIMGPass1";
            this.picIMGPass1.TabStop = false;
            this.picIMGPass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseDown);
            this.picIMGPass1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picIMGPass1_MouseUp);
            // 
            // frmUserManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.grpAccountType);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.grpActiveStatus);
            this.Controls.Add(this.grpUserDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserManagement";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserDetails.Panel)).EndInit();
            this.grpUserDetails.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpUserDetails)).EndInit();
            this.grpUserDetails.ResumeLayout(false);
            this.grpUserDetail.ResumeLayout(false);
            this.grpUserDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).EndInit();
            this.grpGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).EndInit();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpAccountType.Panel)).EndInit();
            this.grpAccountType.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpAccountType)).EndInit();
            this.grpAccountType.ResumeLayout(false);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.grpActive.ResumeLayout(false);
            this.grpActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpActiveStatus.Panel)).EndInit();
            this.grpActiveStatus.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpActiveStatus)).EndInit();
            this.grpActiveStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGPass1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        //private System.Windows.Forms.TextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtVerifyPassword;
        private System.Windows.Forms.Label lblVerifyPass;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSecurity;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAsnwer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSecurityQuestion;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblManAnswer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblManVerifyPass;
        private System.Windows.Forms.Label lblManPass;
        private System.Windows.Forms.Label lblManUserName;
        private System.Windows.Forms.PictureBox picIMGPass2;
        private System.Windows.Forms.PictureBox picIMGPass1;
        private System.Windows.Forms.Label lblManEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private gGlowBox.gGlowGroupBox grpUserDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpUserDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpAccountType;
        private gGlowBox.gGlowGroupBox grpAccount;
        private System.Windows.Forms.RadioButton rdLimitedUser;
        private System.Windows.Forms.RadioButton rdAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private gGlowBox.gGlowGroupBox grpActive;
        private System.Windows.Forms.RadioButton rdInActive;
        private System.Windows.Forms.RadioButton rdActive;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpActiveStatus;
    }
}