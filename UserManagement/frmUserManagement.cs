
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CoreApp;

namespace UserManagement
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            rdAdmin.Checked = false;
        }
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;
        string UserName = string.Empty;
        string DBName = string.Empty;
        int LogID = 0;
        bool admin = false;//false

        Image Add = UserManagement.Properties.Resources.B_click;
        public void LoginStatus(int LoginID, bool IsAdmin)
        {
            LogID = LoginID;
            rdLimitedUser.Checked = true;
            admin = IsAdmin;
        }
        private bool CountofAdmin()
        {
            DataTable dt = ObjDAL.GetData(DBName + ".dbo.UserManagement", "IsAdmin=1", "ID");
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
            btnAdd.BackgroundImage = Add;
            btnSave.BackgroundImage = Add;
            btnEdit.BackgroundImage = Add;
            btnUpdate.BackgroundImage = Add;
            btnDelete.BackgroundImage = Add;
            btnCancel.BackgroundImage = Add;

            DBName = ObjDAL.GetCurrentDBName(true);
            //string a = ObjDAL.ReadConStringFromFile("AppConfig/ServerConfig.sc", true);
            //string[] arr = a.Split(new char[] { ';', '=' });
            //DBName = arr[3].ToString();
            LoadData();

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning, admin);
        }
        private void LoadData()
        {
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            DataTable dt = null;
            if (admin)
            {
                dt = ObjDAL.ExecuteSelectStatement("select ID,UserName,[Password],ISNULL(EmailID,'') AS EmailID,SecurityQuestion,Answer,(CASE WHEN IsAdmin=1 THEN 'Admin'WHEN IsAdmin=0 THEN 'Limited User'END)as 'AccountType'" +
                    ",(CASE WHEN IsBlock=1 THEN 'Yes'WHEN ISNULL(IsBlock,0)=0 THEN 'No'END)as 'IsBlock'" +
                    " from " + DBName + ".[dbo].[UserManagement]");
            }
            else
            {
                dt = ObjDAL.GetDataCol(DBName + ".dbo.UserManagement", "ID,UserName,[Password],SecurityQuestion,Answer,ISNULL(EmailID,'') AS EmailID," +
                    "(CASE WHEN IsAdmin=1 THEN 'Admin'WHEN IsAdmin=0 THEN 'Limited User'END)as 'AccountType'", "ID=" + LogID, "ID");
            }
            if (ObjUtil.ValidateTable(dt))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
            grpUserDetail.Enabled = false;
            grpAccount.Enabled = false;
            grpIsBlock.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                grpUserDetail.Enabled = false;
                grpAccount.Enabled = false;
                rdBlock.Enabled = false;
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
                    if (rdAdmin.Checked == false)
                    {
                        admin = false;
                        clsUtility.IsAdmin = admin;
                    }
                    if (IsAdmin())
                    {
                        if (CountofAdmin())
                        {
                            ObjDAL.UpdateColumnData("IsBlock", SqlDbType.Bit, rdBlock.Checked == true ? 1 : 0);
                        }
                        else
                        {
                            if (rdBlock.Checked)
                            {
                                clsUtility.ShowInfoMessage("'" + UserName + "' user is not Blocked\n Because atleast one User is Administrator ", clsUtility.strProjectTitle);
                                grpAccount.Focus();
                                ObjDAL.ResetData();
                                return;
                            }
                            else
                            {
                                ObjDAL.UpdateColumnData("IsBlock", SqlDbType.Bit, 0);
                            }
                            if (rdLimitedUser.Checked)
                            {
                                clsUtility.ShowInfoMessage("'" + UserName + "' user is not Updated\n Because atleast one User is Administrator ", clsUtility.strProjectTitle);
                                grpAccount.Focus();
                                ObjDAL.ResetData();
                                return;
                            }
                        }
                    }
                    else
                    {
                        ObjDAL.UpdateColumnData("IsBlock", SqlDbType.Bit, rdBlock.Checked == true ? 1 : 0);
                    }

                    if (UserName != txtUserName.Text.Trim() || txtVerifyPassword.Text.Trim() != ObjUtil.Decrypt(pass, true) || rdAdmin.Checked || rdLimitedUser.Checked)
                    {
                        ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);
                        ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, LogID); //if LogID=0 then Test Admin else user
                    }
                    if (ObjDAL.UpdateData(DBName + ".dbo.UserManagement", "UserName='" + UserName + "'") > 0)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, admin);
                        LoadData();
                        ClearAll();
                        clsUtility.ShowInfoMessage("'" + UserName + "' user is Updated", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + UserName + "' user is not Updated", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' UserName OR EmailID is already exist..", clsUtility.strProjectTitle);
                    txtUserName.Focus();
                    ObjDAL.ResetData();
                }
            }
        }
        private bool IsAdmin()
        {
            object a = ObjDAL.ExecuteScalar("select IsAdmin from " + DBName + ".[dbo].[UserManagement] with(nolock) where UserName='" + txtUserName.Text.Trim() + "'");
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
                    ObjDAL.ResetData();
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
            grpUserDetail.Enabled = true;
            if (admin)
            {
                grpAccount.Enabled = true;
                grpIsBlock.Enabled = true;
            }
            else
            {
                grpAccount.Enabled = false;
                grpIsBlock.Enabled = false;
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
                txtPassword.Focus();
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
                a = ObjDAL.CountRecords(DBName + ".dbo.UserManagement", "UserName='" + txtUserName.Text + "' AND ID !=" + i + "OR EmailID = '" + txtEmail.Text + "'");
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
                    string name = txtUserName.Text;
                    string pass = ObjUtil.Encrypt(txtPassword.Text, true);
                    ObjDAL.SetColumnData("UserName", SqlDbType.NVarChar, txtUserName.Text.Trim());
                    ObjDAL.SetColumnData("Password", SqlDbType.NVarChar, pass);
                    ObjDAL.SetColumnData("EmailID", SqlDbType.VarChar, txtEmail.Text);
                    ObjDAL.SetColumnData("SecurityQuestion", SqlDbType.NVarChar, cmbSecurity.SelectedItem.ToString());
                    ObjDAL.SetColumnData("Answer", SqlDbType.NVarChar, ObjUtil.Encrypt(txtAsnwer.Text.Trim(), true));
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, LogID); //if LogID=0 then Test Admin else user
                    ObjDAL.SetColumnData("IsBlock", SqlDbType.Bit, rdBlock.Checked == true ? 1 : 0);
                    ObjDAL.SetColumnData("IsAdmin", SqlDbType.Bit, rdAdmin.Checked == true ? 1 : 0);
                    if (ObjDAL.InsertData(DBName + ".dbo.UserManagement", true) > 0)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, admin);
                        ClearAll();
                        LoadData();
                        clsUtility.ShowInfoMessage("User Name: '" + name + "' is Saved Successfully..", clsUtility.strProjectTitle);
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("User Name: '" + name + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' UserName OR EmailID is already exist..", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
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
            rdBlock.Checked = false;
            rdUnblocked.Checked = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, admin);
            grpUserDetail.Enabled = true;
            grpAccount.Enabled = true;
            grpIsBlock.Enabled = true;

            txtUserName.Focus();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Answer"].Visible = false;
            label1.Text = "Total Records : " + dataGridView1.Rows.Count;
            //dataGridView1.Columns["UserName"].HeaderText = "User Name";
            //dataGridView1.Columns["IsAdmin"].HeaderText = "Account Type";
            //if (admin)
            //{
            //    dataGridView1.Columns["CreatedBy"].HeaderText = "Created By";
            //    dataGridView1.Columns["CreatedOn"].HeaderText = "Created On";
            //    dataGridView1.Columns["UpdatedBy"].HeaderText = "Updated By";
            //    dataGridView1.Columns["UpdatedOn"].HeaderText = "Updated On";
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    grpUserDetail.Enabled = false;
                    grpAccount.Enabled = false;
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    if (admin)
                    {
                        if (dataGridView1.SelectedRows[0].Cells["IsBlock"].Value.ToString() == "Yes")
                        {
                            rdBlock.Checked = true;
                        }
                        else
                        {
                            rdUnblocked.Checked = true;
                        }
                    }
                    //AccountType
                    if (dataGridView1.SelectedRows[0].Cells["AccountType"].Value.ToString() == "Admin")
                    {
                        rdAdmin.Checked = true;
                    }
                    else
                    {
                        rdLimitedUser.Checked = true;
                    }
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, admin);

                    txtUserName.Text = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                    UserName = txtUserName.Text;
                    txtPassword.Text = ObjUtil.Decrypt(dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString(), true);
                    txtVerifyPassword.Text = txtPassword.Text;
                    txtEmail.Text = dataGridView1.SelectedRows[0].Cells["EmailID"].Value.ToString();
                    cmbSecurity.SelectedItem = dataGridView1.SelectedRows[0].Cells["SecurityQuestion"].Value.ToString();
                    txtAsnwer.Text = ObjUtil.Decrypt(dataGridView1.SelectedRows[0].Cells["Answer"].Value.ToString(), true);
                    txtUserName.Focus();
                }
                catch
                { }
            }
        }

        private void imgpass_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void imgpass_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void imgverify_MouseEnter(object sender, EventArgs e)
        {
            txtVerifyPassword.UseSystemPasswordChar = false;
            string a = e.GetType().Name;
        }

        private void imgverify_MouseLeave(object sender, EventArgs e)
        {
            txtVerifyPassword.UseSystemPasswordChar = true;
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
            DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtUserName.Text + "' user ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                if (ObjDAL.DeleteData(DBName + ".dbo.UserManagement", "UserName='" + txtUserName.Text + "'") > 0)
                {
                    clsUtility.ShowInfoMessage("'" + txtUserName.Text + "' user is deleted  ", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadData();
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, admin);
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtUserName.Text + "' user is not deleted  ", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                }
            }
        }
        private void MouseFoucsEnter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);

        }
        private void MouseFoucsLeave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private void txtAsnwer_MouseEnter(object sender, EventArgs e)
        {
            txtAsnwer.UseSystemPasswordChar = false;
        }

        private void txtAsnwer_MouseLeave(object sender, EventArgs e)
        {
            txtAsnwer.UseSystemPasswordChar = true;
        }
    }
}
