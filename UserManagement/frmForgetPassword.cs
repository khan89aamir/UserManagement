using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using CoreApp;

namespace UserManagement
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsThreadTask ObjThread = new clsThreadTask();

        Image B_Leave = UserManagement.Properties.Resources.B_click;
        Image B_Enter = UserManagement.Properties.Resources.B_on;
        Image imgLoading = UserManagement.Properties.Resources.animated;

        bool b = false;
        DataTable dt = null;
        string DBName = string.Empty;
        public string strReuestType;
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            //button1.BackgroundImage = B_Leave;
            DBName = ObjDAL.GetCurrentDBName(true);
        }

        private void ButtonMouserEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }
        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }
        private bool FormValidation()
        {
            string EId = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
               @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
               @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            string validating = txtEmail.Text.Trim();

            //clsUtility.ShowInfoMessage(Regex.Match(validating, EId).Success.ToString(), clsUtility.strProjectTitle);

            if (ObjUtil.IsControlTextEmpty(txtUserName))
            {
                clsUtility.ShowInfoMessage("Enter UserName.", clsUtility.strProjectTitle);
                txtUserName.Focus();
                return false;
            }

            else if (ObjUtil.IsControlTextEmpty(txtEmail))
            {
                clsUtility.ShowInfoMessage("Enter E-Mail Address.", clsUtility.strProjectTitle);
                txtEmail.Focus();
                return false;
            }
            else if (!Regex.Match(validating, EId).Success)
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
            else
            //else if (ObjUtil.ValidateEmail(txtEmail.Text))
            {
                dt = ObjDAL.GetDataCol(DBName + ".dbo.UserManagement", "[UserName],[SecurityQuestion],[Answer],[Password],EmailID", "UserName='" + txtUserName.Text + "'", null);
                if (ObjUtil.ValidateTable(dt))
                {
                    string SecurityQuestion, Answer, Password, EmailID;

                    SecurityQuestion = dt.Rows[0]["SecurityQuestion"].ToString();
                    Answer = ObjUtil.Decrypt(dt.Rows[0]["Answer"].ToString(), true);
                    Password = dt.Rows[0]["Password"].ToString();
                    EmailID = dt.Rows[0]["EmailID"].ToString();

                    if (SecurityQuestion == cmbSecurity.SelectedItem.ToString() && Answer.ToLower() == txtAsnwer.Text.ToLower() && EmailID.ToLower() == txtEmail.Text.ToLower())
                    {
                        txtRetrivePassword.Text = Password;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Entered details is not matching.", clsUtility.strProjectTitle);
                        return false;
                    }

                }
                else
                {
                    clsUtility.ShowInfoMessage("Entered UserName or EmailID is not exist.", clsUtility.strProjectTitle);
                    return false;
                }
                return true;
            }
            //else
            //{
            //    clsUtility.ShowInfoMessage("Enter Valid E-Mail Address.", clsUtility.strProjectTitle);
            //    txtEmail.Focus();
            //    return false;
            //}
        }

        private void TestLoad()
        {
            string s1 = CoreSys.clsRegKey.GenrateEncKey("KhanSoft", "13579");
            ObjThread.CloseImageLoadingDialog();
        }
        private void SendEmail(string subject, string body)
        {
            SendMail Obj = new SendMail();
            try
            {
                Obj.To = "abdulmateen50@gmail.com,Khan89aamir@gmail.com";
                Obj.Sub = subject;
                Obj.Body = body;
                Obj.SendEMail();
                b = Obj.IsMail;
                //Thread th = new Thread(new ThreadStart(Obj.SendEMail));

            }
            catch //(Exception ex)
            {
                ObjThread.CloseImageLoadingDialog();
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormValidation())
                {
                    ObjThread.ShowImageLoading(clsUtility.strProjectTitle, "Sending An E-Mail please Wait..", this, null);
                    Thread th = new Thread(new ThreadStart(TestLoad));
                    th.Start();
                    DataTable dt = ObjDAL.ExecuteSelectStatement("Select UserName,Password from " + DBName + ".dbo.UserManagement");
                    string body = string.Empty;
                    string content = string.Empty;
                    content = "Machine Name " + Environment.MachineName + " has request for a new Password for " + clsUtility.strProjectTitle + " and Total Users found : " + dt.Rows.Count;
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            body += "\n " + (i + 1) + "- User Name : " + dt.Rows[i]["UserName"].ToString() + "\n " + (i + 1) + "- Passowrd : " + ObjUtil.Decrypt(dt.Rows[i]["Password"].ToString(), true);
                        }

                        SendEmail("Request for a new Password", content + body + "\n forgot password for User Name : " + txtUserName.Text.Trim());
                        if (b)
                        {
                            clsUtility.ShowInfoMessage("An E-Mail has been sent to the software developers for your password.\nYou will receive your Password at your E-Mail Address " + txtEmail.Text.Trim(), clsUtility.strProjectTitle);
                            btnSubmit.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Unable to Send An E-Mail for your password request.\nBeacuse Unable to connect Internet.", clsUtility.strProjectTitle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsUtility.ShowInfoMessage(ex.ToString(), clsUtility.strProjectTitle);
                this.Close();
            }
        }

        private void ClearAll()
        {
            txtUserName.Clear();
            txtAsnwer.Clear();
            txtEmail.Clear();
            txtRetrivePassword.Clear();
            cmbSecurity.SelectedIndex = -1;
            txtUserName.Focus();
            btnSubmit.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtRetrivePassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtRetrivePassword.Text.Length > 0)
                txtRetrivePassword.Text = ObjUtil.Decrypt(txtRetrivePassword.Text, true);

            txtRetrivePassword.UseSystemPasswordChar = false;
        }

        private void txtRetrivePassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtRetrivePassword.Text.Length > 0)
                txtRetrivePassword.Text = ObjUtil.Encrypt(txtRetrivePassword.Text, true);

            txtRetrivePassword.UseSystemPasswordChar = true;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }
    }
}

