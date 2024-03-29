﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using CoreApp;
using ComponentFactory.Krypton.Toolkit;

namespace UserManagement
{
    public partial class frmUserManagement : KryptonForm
    {
        public frmUserManagement()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(User_Lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(User_Lang);

            InitializeComponent();
            rdAdmin.Checked = false;
        }
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;
        string UserName = string.Empty;
        string DBName = string.Empty;
        int LogID = 1;
        bool admin = true;
        //bool admin = false;
        public static string User_Lang = "en-US";
        public bool IsNew = true;

        public void LoginStatus(int LoginID, bool IsAdmin)
        {
            LogID = LoginID;
            rdLimitedUser.Checked = true;
            admin = IsAdmin;
        }
        private bool CountofAdmin()
        {
            DataTable dt = ObjDAL.GetData(DBName + ".dbo.UserManagement", "IsAdmin=1", "UserID");
            if (dt != null && dt.Rows.Count > 1)
            {
                //grpAccount.Enabled = true;
                return true;
            }
            else
            {
                //grpAccount.Enabled = false;
                return false;
            }
        }
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            //clsUtility._UserMessageType = clsUtility.MessageType.SparklePurple;
            //clsUtility._UserMessageType = clsUtility.MessageType.Office2010Blue;
            //clsUtility._UserMessageType = clsUtility.MessageType.Office2007Blue;
            clsUtility._UserMessageType = clsUtility.MessageType.BlueTheme;

            LoadTheme();

            EnableDisable(false);

            //DBName = ObjDAL.GetCurrentDBName(true);

            //string a = ObjDAL.ReadConStringFromFile("AppConfig/ServerConfig.sc", true);
            //string[] arr = a.Split(new char[] { ';', '=' });
            //DBName = arr[3].ToString();
            LoadData();

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, admin);
        }
        private void LoadTheme()
        {
            btnAdd.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.8f, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.8f, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.8f, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.8f, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.8f, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.8f, FontStyle.Regular, GraphicsUnit.Point);
            picIMGPass1.SizeMode = PictureBoxSizeMode.Zoom;
            picIMGPass2.SizeMode = PictureBoxSizeMode.Zoom;
            if (clsUtility.MessageType.SparklePurple == clsUtility._UserMessageType)
            {
                BackgroundImage = null;
                base.PaletteMode = PaletteMode.SparklePurple;
                BackColor = Color.FromArgb(82, 91, 114);
                Lable_Color(Color.White);
                btnAdd.PaletteMode = PaletteMode.SparklePurple;
                btnSave.PaletteMode = PaletteMode.SparklePurple;
                btnEdit.PaletteMode = PaletteMode.SparklePurple;
                btnUpdate.PaletteMode = PaletteMode.SparklePurple;
                btnDelete.PaletteMode = PaletteMode.SparklePurple;
                btnCancel.PaletteMode = PaletteMode.SparklePurple;
                cmbSecurity.PaletteMode = PaletteMode.SparklePurple;
                picIMGPass1.Image = Properties.Resources.picIMGPass_Image1;
                picIMGPass2.Image = Properties.Resources.picIMGPass_Image1;
                grpGridview.PaletteMode = PaletteMode.SparklePurple;
            }
            else if (clsUtility.MessageType.BlueTheme == clsUtility._UserMessageType)
            {
                Color clr= Color.FromArgb(240, 240, 240);

                pnlTitle.StateCommon.Color1 = Color.FromArgb(99, 157, 207);
                pnlTitle.StateCommon.Color2 = Color.FromArgb(99, 157, 207);
                base.PaletteMode = PaletteMode.Office2010Blue;
                BackColor = clr;
                Lable_Color(Color.Black);

                btnAdd.PaletteMode = PaletteMode.Office2007Blue;
                btnSave.PaletteMode = PaletteMode.Office2007Blue;
                btnEdit.PaletteMode = PaletteMode.Office2007Blue;
                btnUpdate.PaletteMode = PaletteMode.Office2007Blue;
                btnDelete.PaletteMode = PaletteMode.Office2007Blue;
                btnCancel.PaletteMode = PaletteMode.Office2007Blue;
                cmbSecurity.PaletteMode = PaletteMode.Office2007Blue;

                btnAdd.Values.Image = Properties.Resources.Blue_add;
                btnSave.Values.Image = Properties.Resources.Blue_save;
                btnEdit.Values.Image = Properties.Resources.Blue_edit;
                btnUpdate.Values.Image = Properties.Resources.Blue_refresh;
                btnDelete.Values.Image = Properties.Resources.Blue_delete;
                btnCancel.Values.Image = Properties.Resources.Blue_cancel;

                picIMGPass1.Image = Properties.Resources.picIMGPass_Black;
                picIMGPass2.Image = Properties.Resources.picIMGPass_Black;

                grpUserDetails.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpUserDetails.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                grpUserDetails.StateCommon.Border.Color1 = Color.FromArgb(99, 157, 207);
                grpUserDetails.StateNormal.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpUserDetails.StateCommon.HeaderPrimary.Content.ShortText.Color1 = Color.White;
                grpUserDetail.BackColor = clr;
                grpAccountType.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpAccountType.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                grpAccountType.StateCommon.Border.Color1 = Color.FromArgb(99, 157, 207);
                grpAccountType.StateNormal.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpAccountType.StateCommon.HeaderPrimary.Content.ShortText.Color1 = Color.White;
                grpAccountType.BackColor = clr;
                grpActiveStatus.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpActiveStatus.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                grpActiveStatus.StateCommon.Border.Color1 = Color.FromArgb(99, 157, 207);
                grpActiveStatus.StateNormal.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpActiveStatus.StateCommon.HeaderPrimary.Content.ShortText.Color1 = Color.White;
                grpActiveStatus.BackColor = clr;
                grpGridview.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                grpGridview.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                grpGridview.StateCommon.HeaderPrimary.Content.ShortText.Color1 = clr;
                grpGridview.PaletteMode = PaletteMode.Office2007Blue;

                dataGridView1.PaletteMode = PaletteMode.Office2007Blue;
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(183, 219, 255);
                dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            }
            else if (clsUtility._UserMessageType == clsUtility.MessageType.Office2007Blue)
            {
                Color clr= Color.White;

                BackgroundImage = Properties.Resources.back_green;
                pnlTitle.StateCommon.Image = Properties.Resources.titlebg_green;
                base.PaletteMode = PaletteMode.Office2007Blue;
                BackColor = clr;
                Lable_Color(Color.Black);
                btnAdd.PaletteMode = PaletteMode.Office2007Blue;
                btnSave.PaletteMode = PaletteMode.Office2007Blue;
                btnEdit.PaletteMode = PaletteMode.Office2007Blue;
                btnUpdate.PaletteMode = PaletteMode.Office2007Blue;
                btnDelete.PaletteMode = PaletteMode.Office2007Blue;
                btnCancel.PaletteMode = PaletteMode.Office2007Blue;
                cmbSecurity.PaletteMode = PaletteMode.Office2007Blue;
                btnAdd.Values.Image = Properties.Resources._new;
                btnSave.Values.Image = Properties.Resources.save;
                btnEdit.Values.Image = Properties.Resources.edit;
                btnUpdate.Values.Image = Properties.Resources.update;
                btnDelete.Values.Image = Properties.Resources.delete;
                btnCancel.Values.Image = Properties.Resources.cancel;
                picIMGPass1.Image = Properties.Resources.picIMGPass_green_Image;
                picIMGPass2.Image = Properties.Resources.picIMGPass_green_Image;
                grpUserDetails.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpAccountType.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpActiveStatus.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpGridview.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpGridview.PaletteMode = PaletteMode.Office2007Blue;
            }
            else if (clsUtility.MessageType.Office2010Blue == clsUtility._UserMessageType)
            {
                Color clr = Color.White;

                BackgroundImage = Properties.Resources.back_green;
                pnlTitle.StateCommon.Image = Properties.Resources.titlebg_green;
                base.PaletteMode = PaletteMode.Office2010Blue;
                BackColor = clr;
                Lable_Color(Color.Black);
                btnAdd.PaletteMode = PaletteMode.Office2010Blue;
                btnSave.PaletteMode = PaletteMode.Office2010Blue;
                btnEdit.PaletteMode = PaletteMode.Office2010Blue;
                btnUpdate.PaletteMode = PaletteMode.Office2010Blue;
                btnDelete.PaletteMode = PaletteMode.Office2010Blue;
                btnCancel.PaletteMode = PaletteMode.Office2010Blue;
                cmbSecurity.PaletteMode = PaletteMode.Office2010Blue;
                btnAdd.Values.Image = Properties.Resources._new;
                btnSave.Values.Image = Properties.Resources.save;
                btnEdit.Values.Image = Properties.Resources.edit;
                btnUpdate.Values.Image = Properties.Resources.update;
                btnDelete.Values.Image = Properties.Resources.delete;
                btnCancel.Values.Image = Properties.Resources.cancel;
                picIMGPass1.Image = Properties.Resources.picIMGPass_green_Image;
                picIMGPass2.Image = Properties.Resources.picIMGPass_green_Image;
                grpUserDetails.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpAccountType.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpActiveStatus.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpGridview.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                grpGridview.PaletteMode = PaletteMode.Office2010Blue;
            }
        }

        private void Lable_Color(Color clr)
        {
            lblUserName.ForeColor = clr;
            lblPassword.ForeColor = clr;
            lblVerifyPass.ForeColor = clr;
            lblSecurityQuestion.ForeColor = clr;
            lblAnswer.ForeColor = clr;
            lblEmail.ForeColor = clr;

            rdAdmin.ForeColor = clr;
            rdLimitedUser.ForeColor = clr;

            rdActive.ForeColor = clr;
            rdInActive.ForeColor = clr;

            if (Color.White == clr)
            {
                //lblManAnswer.ForeColor = clr;
                lblManEmail.ForeColor = clr;
                lblManPass.ForeColor = clr;
                lblManUserName.ForeColor = clr;
                lblManVerifyPass.ForeColor = clr;
            }
            else
            {
                //lblManAnswer.ForeColor = Color.FromArgb(192, 0, 0);
                lblManEmail.ForeColor = Color.FromArgb(192, 0, 0);
                lblManPass.ForeColor = Color.FromArgb(192, 0, 0);
                lblManUserName.ForeColor = Color.FromArgb(192, 0, 0);
                lblManVerifyPass.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void EnableDisable(bool b)
        {
            txtUserName.Enabled = b;
            txtAsnwer.Enabled = b;
            txtEmail.Enabled = b;
            txtPassword.Enabled = b;
            txtVerifyPassword.Enabled = b;
            cmbSecurity.Enabled = b;
        }

        //private void frmUserManagement_Load(object sender, EventArgs e)
        //{
        //    //clsUtility._UserMessageType = clsUtility.MessageType.SparklePurple;
        //    //clsUtility._UserMessageType = clsUtility.MessageType.Office2010Blue;
        //    clsUtility._UserMessageType = clsUtility.MessageType.BlueTheme;

        //    LoadTheme();

        //    EnableDisable(false);

        //    //DBName = ObjDAL.GetCurrentDBName(true);

        //    //string a = ObjDAL.ReadConStringFromFile("AppConfig/ServerConfig.sc", true);
        //    //string[] arr = a.Split(new char[] { ';', '=' });
        //    //DBName = arr[3].ToString();
        //    LoadData();

        //    ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
        //    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, admin);
        //}
        private void LoadData()
        {
            DataTable dt = null;
            if (admin)
            {
                dt = ObjDAL.ExecuteSelectStatement("SELECT UserID,UserName,[Password],ISNULL(EmailID,'') AS EmailID,SecurityQuestion,Answer,(CASE IsAdmin WHEN 1 THEN 'Admin' WHEN 0 THEN 'Limited User' END)as 'AccountType'" +
                    ",(CASE ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END)as 'ActiveStatus'" +
                    " FROM " + clsUtility.DBName + ".[dbo].[UserManagement] WITH(NOLOCK) WHERE UserName<>'atech'");
            }
            else
            {
                dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.UserManagement", "UserID,UserName,[Password],SecurityQuestion,Answer,ISNULL(EmailID,'') AS EmailID," +
                    "(CASE IsAdmin WHEN 1 THEN 'Admin' WHEN 0 THEN 'Limited User' END)as 'AccountType',(CASE ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END)as 'ActiveStatus'", "UserID=" + LogID, "UserID");
            }
            if (ObjUtil.ValidateTable(dt))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                EnableDisable(false);

                ClearAll();
                LoadData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, admin);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                if (DuplicateUser(ID))
                {
                    string pass = ObjUtil.Encrypt(txtPassword.Text, true);
                    ObjDAL.UpdateColumnData("UserName", SqlDbType.NVarChar, txtUserName.Text);
                    ObjDAL.UpdateColumnData("Password", SqlDbType.NVarChar, pass);
                    ObjDAL.UpdateColumnData("EmailID", SqlDbType.VarChar, txtEmail.Text);
                    ObjDAL.UpdateColumnData("SecurityQuestion", SqlDbType.NVarChar, cmbSecurity.SelectedItem.ToString());
                    ObjDAL.UpdateColumnData("Answer", SqlDbType.NVarChar, ObjUtil.Encrypt(txtAsnwer.Text.Trim(), true));
                    ObjDAL.UpdateColumnData("IsAdmin", SqlDbType.Bit, rdAdmin.Checked == true ? 1 : 0);
                    ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, rdActive.Checked == true ? 1 : 0);
                    if (rdAdmin.Checked == false)
                    {
                        admin = false;
                        clsUtility.IsAdmin = admin;
                    }

                    if (UserName != txtUserName.Text.Trim() || txtVerifyPassword.Text.Trim() != ObjUtil.Decrypt(pass, true) || rdAdmin.Checked || rdLimitedUser.Checked)
                    {
                        ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, LogID); //if LogID=0 then Test Admin else user
                    }
                    if (ObjDAL.UpdateData(DBName + ".dbo.UserManagement", "UserID=" + ID) > 0)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, admin);
                        LoadData();
                        ClearAll();
                        EnableDisable(false);
                        clsUtility.ShowInfoMessage("'" + UserName + "' user is Updated", clsUtility.strProjectTitle);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + UserName + "' user is not Updated", clsUtility.strProjectTitle);
                    }
                    ObjDAL.ResetData();
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' UserName OR EmailID is already exist..", clsUtility.strProjectTitle);
                    txtUserName.Focus();
                }
            }
        }
        private bool IsAdmin()
        {
            object a = ObjDAL.ExecuteScalar("SELECT IsAdmin FROM " + DBName + ".[dbo].[UserManagement] WITH(NOLOCK) WHERE UserName='" + txtUserName.Text.Trim() + "'");
            bool admin = Convert.ToBoolean(a);
            return admin;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsUtility.LoginID == ID)
            {
                clsUtility.ShowInfoMessage(dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() + " user is not deleted " + Environment.NewLine + " because its already login..", clsUtility.strProjectTitle);
                return;
            }
            if (IsAdmin())
            {
                if (CountofAdmin())
                {
                    UserDeleted();
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' user is not deleted\n Because atleast one User have an Administrator ", clsUtility.strProjectTitle);
                }
            }
            else
            {
                UserDeleted();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, admin);

            //rdActive.Enabled = true;
            //rdInActive.Enabled = true;
            if (admin)
            {
                EnableDisable(true);
            }
            else
            {
                rdAdmin.Enabled = false;
                rdLimitedUser.Enabled = false;
                //grpAccount.Enabled = false;
            }
            txtUserName.Focus();
            txtUserName.SelectionStart = txtUserName.MaxLength;
        }
        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtUserName))
            {
                clsUtility.ShowInfoMessage("Enter User Name            ", clsUtility.strProjectTitle);
                txtUserName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtPassword))
            {
                clsUtility.ShowInfoMessage("Enter Password             ", clsUtility.strProjectTitle);
                txtPassword.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtVerifyPassword))
            {
                clsUtility.ShowInfoMessage("Enter Verify Password             ", clsUtility.strProjectTitle);
                txtVerifyPassword.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() != txtVerifyPassword.Text.Trim())
            {
                clsUtility.ShowInfoMessage("Password and Verify Password must be Same       ", clsUtility.strProjectTitle);
                txtVerifyPassword.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtEmail))
            {
                clsUtility.ShowInfoMessage("Enter E-Mail Address            ", clsUtility.strProjectTitle);
                txtEmail.Focus();
                return false;
            }
            else if (!ObjUtil.ValidateEmail(txtEmail.Text))
            {
                clsUtility.ShowInfoMessage("Enter Valid E-Mail Address.", clsUtility.strProjectTitle);
                txtEmail.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbSecurity))
            {
                clsUtility.ShowInfoMessage("Select Security question for password retrival.", clsUtility.strProjectTitle);
                cmbSecurity.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtAsnwer))
            {
                clsUtility.ShowInfoMessage("Enter Security's question.", clsUtility.strProjectTitle);
                txtAsnwer.Focus();
                return false;
            }
            else if (rdAdmin.Checked == false && rdLimitedUser.Checked == false)
            {
                clsUtility.ShowInfoMessage("Select Account Type      ", clsUtility.strProjectTitle);
                grpAccount.Focus();
                return false;
            }
            return true;
        }
        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(DBName + ".dbo.UserManagement", "UserName='" + txtUserName.Text + "'");
                if (a == 0)
                {
                    a = ObjDAL.CountRecords(DBName + ".dbo.UserManagement", "EmailID='" + txtEmail.Text + "'");
                }
            }
            else
            {
                a = ObjDAL.CountRecords(DBName + ".dbo.UserManagement", "UserID !=" + i + " AND (UserName = '" + txtUserName.Text + "' OR EmailID = '" + txtEmail.Text + "')");
            }
            if (a > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                if (DuplicateUser(0))
                {
                    string name = txtUserName.Text.Trim();
                    string pass = ObjUtil.Encrypt(txtPassword.Text, true);
                    ObjDAL.SetColumnData("UserName", SqlDbType.NVarChar, name);
                    ObjDAL.SetColumnData("Password", SqlDbType.NVarChar, pass);
                    ObjDAL.SetColumnData("EmailID", SqlDbType.VarChar, txtEmail.Text);
                    ObjDAL.SetColumnData("SecurityQuestion", SqlDbType.NVarChar, cmbSecurity.SelectedItem.ToString());
                    ObjDAL.SetColumnData("Answer", SqlDbType.NVarChar, ObjUtil.Encrypt(txtAsnwer.Text.Trim(), true));
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, LogID); //if LogID=0 then Test Admin else user
                    ObjDAL.SetColumnData("IsAdmin", SqlDbType.Bit, rdAdmin.Checked == true ? 1 : 0);
                    ObjDAL.SetColumnData("ActiveStatus", SqlDbType.Bit, rdActive.Checked == true ? 1 : 0);
                    if (ObjDAL.InsertData(DBName + ".dbo.UserManagement", true) > 0)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, admin);
                        ClearAll();
                        LoadData();

                        EnableDisable(false);
                        clsUtility.ShowInfoMessage("User Name: '" + name + "' is Saved Successfully..", clsUtility.strProjectTitle);
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("User Name: '" + name + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                    }
                    ObjDAL.ResetData();
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' UserName OR EmailID is already exist..", clsUtility.strProjectTitle);
                    txtUserName.Focus();
                }
            }
        }
        private void ClearAll()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtVerifyPassword.Clear();
            txtAsnwer.Clear();
            txtEmail.Clear();
            cmbSecurity.SelectedIndex = -1;
            rdAdmin.Checked = false;
            rdLimitedUser.Checked = false;
            rdActive.Checked = false;
            rdInActive.Checked = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, admin);
            grpUserDetail.Enabled = true;
            grpAccount.Enabled = true;
            grpActive.Enabled = true;
            btnSave.Enabled = false;

            EnableDisable(true);

            txtUserName.Focus();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            //ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Answer"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grpGridview.ValuesSecondary.Heading = "Total Records : " + dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ClearAll();
                    EnableDisable(false);
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);
                    //AccountType
                    if (dataGridView1.SelectedRows[0].Cells["AccountType"].Value.ToString() == "Admin")
                    {
                        rdAdmin.Checked = true;
                    }
                    else
                    {
                        rdLimitedUser.Checked = true;
                    }
                    if (dataGridView1.SelectedRows[0].Cells["ActiveStatus"].Value.ToString() == "Active")
                    {
                        rdActive.Checked = true;
                    }
                    else
                    {
                        rdInActive.Checked = true;
                    }
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, admin);
                    btnDelete.Enabled = false;

                    txtUserName.Text = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                    UserName = txtUserName.Text;
                    txtPassword.Text = ObjUtil.Decrypt(dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString(), true);
                    txtVerifyPassword.Text = txtPassword.Text;
                    txtEmail.Text = dataGridView1.SelectedRows[0].Cells["EmailID"].Value.ToString();
                    cmbSecurity.Text = dataGridView1.SelectedRows[0].Cells["SecurityQuestion"].Value.ToString();
                    txtAsnwer.Text = ObjUtil.Decrypt(dataGridView1.SelectedRows[0].Cells["Answer"].Value.ToString(), true);
                    txtUserName.Focus();
                }
                catch
                { }
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
                txtPassword.SelectionStart = txtPassword.MaxLength;
                return;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtVerifyPassword.Focus();
                txtVerifyPassword.SelectionStart = txtVerifyPassword.MaxLength;
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtPassword.Focus();
                txtPassword.SelectionStart = txtPassword.MaxLength;
                return;
            }
        }

        private void txtVerifyPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbSecurity.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtVerifyPassword.Focus();
                txtVerifyPassword.SelectionStart = txtVerifyPassword.MaxLength;
                return;
            }
        }
        private void UserDeleted()
        {
            bool b = clsUtility.ShowQuestionMessage("Are you sure want to delete '" + txtUserName.Text + "' user ");
            if (b)
            {
                if (ObjDAL.DeleteData(DBName + ".dbo.UserManagement", "UserID=" + ID) > 0)
                {
                    clsUtility.ShowInfoMessage("'" + txtUserName.Text + "' user is deleted  ", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadData();
                    EnableDisable(false);
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, admin);
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' user is not deleted  ", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                }
            }
        }

        private void picIMGPass1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtVerifyPassword.UseSystemPasswordChar = false;

            txtPassword.PasswordChar = '\0';
            txtVerifyPassword.PasswordChar = '\0';
        }

        private void picIMGPass1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtVerifyPassword.UseSystemPasswordChar = true;
        }

        private void picIMGPass2_MouseDown(object sender, MouseEventArgs e)
        {
            txtAsnwer.UseSystemPasswordChar = false;
            txtAsnwer.PasswordChar = '\0';
        }

        private void picIMGPass2_MouseUp(object sender, MouseEventArgs e)
        {
            txtAsnwer.UseSystemPasswordChar = true;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsAlphaNumeric(e);
            if (e.Handled)
            {
                clsUtility.ShowInfoMessage("Enter Valid UserName...", clsUtility.strProjectTitle);
                txtUserName.Focus();
            }
        }

        private void cmbSecurity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grpUserDetail.Focus();
        }
    }
}