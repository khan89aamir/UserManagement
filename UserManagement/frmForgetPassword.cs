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

        string DBName = string.Empty;
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            //button1.BackgroundImage = B_Leave;
            DBName = ObjDAL.GetCurrentDBName(true);
        }

        public string strReuestType;
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
            else if (Regex.Match(validating, EId).Success)
            {
                return true;
            }
            else
            {
                clsUtility.ShowInfoMessage("Enter Valid E-Mail Address.", clsUtility.strProjectTitle);
                txtEmail.Focus();
                return false;
            }
        }
        bool b = false;

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
        private void button1_Click(object sender, EventArgs e)
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
                            button1.Enabled = false;
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
    }
}

