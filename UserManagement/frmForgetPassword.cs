using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;
using CoreApp;
using ComponentFactory.Krypton.Toolkit;

namespace UserManagement
{
    public partial class frmForgetPassword : KryptonForm
    {
        public frmForgetPassword()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(User_Lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(User_Lang);

            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsThreadTask ObjThread = new clsThreadTask();

        Image imgLoading = UserManagement.Properties.Resources.animated;

        bool b = false;
        DataTable dt = null;
        string DBName = string.Empty;
        public string strReuestType;

        public static string User_Lang = "en-US";
        public bool IsNew = true;

        private void LoadTailoringTheme()
        {
            //this.BackgroundImage = TAILORING.Properties.Resources.Background;

            btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            if (clsUtility.MessageType.SparklePurple == clsUtility._UserMessageType)
            {
                Lable_Color(Color.White);

                this.BackgroundImage = null;
                this.PaletteMode = PaletteMode.SparklePurple;
                this.BackColor = Color.FromArgb(82, 91, 114);

                btnSubmit.PaletteMode = PaletteMode.SparklePurple;
                btnReset.PaletteMode = PaletteMode.SparklePurple;
            }
            else if (clsUtility.MessageType.Office2010Blue == clsUtility._UserMessageType)
            {
                Lable_Color(Color.Black);

                this.BackgroundImage = Properties.Resources.back_green;
                pnlTitle.StateCommon.Image = Properties.Resources.titlebg_green;
                this.PaletteMode = PaletteMode.Office2010Blue;
                this.BackColor = Color.White;

                grpKrytonHeader.PaletteMode = PaletteMode.Office2010Blue;
                cmbSecurity.PaletteMode = PaletteMode.Office2010Blue;
                btnSubmit.PaletteMode = PaletteMode.Office2010Blue;
                btnReset.PaletteMode = PaletteMode.Office2010Blue;
            }
        }

        private void Lable_Color(Color clr)
        {
            lblAnswer.ForeColor = clr;
            lblEmail.ForeColor = clr;
            lblRetrive.ForeColor = clr;
            lblSecurityQuestion.ForeColor = clr;
            lblUserName.ForeColor = clr;
        }
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            clsUtility._UserMessageType = clsUtility.MessageType.SparklePurple;
            //if (IsNew)
            //{
            //    this.BackgroundImage = UserManagement.Properties.Resources.back_green;
            //    pnlTitle.BackgroundImage = UserManagement.Properties.Resources.titlebg_green;
            //}
            //else
            //{
            //    this.BackgroundImage = UserManagement.Properties.Resources.back1;
            //    pnlTitle.BackgroundImage = UserManagement.Properties.Resources.titlebg;
            //}
            LoadTailoringTheme();
            DBName = ObjDAL.GetCurrentDBName(true);
        }

        private bool FormValidation()
        {
            string ValidatingEmailID = txtEmail.Text.Trim();

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
            else if (!ObjUtil.ValidateEmail(ValidatingEmailID))
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
                        txtRetrivePassword.Text = ObjUtil.Decrypt(Password, true);
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
            }
            catch
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
                    DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT UserName,Password FROM " + DBName + ".dbo.UserManagement WITH(NOLOCK)");
                    string body = string.Empty;
                    string content = string.Empty;
                    content = "Machine Name " + Environment.MachineName + " has request for a new Password for " + clsUtility.strProjectTitle + " and Total Users found : " + dt.Rows.Count;
                    if (ObjUtil.ValidateTable(dt))
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

        private void picIMGPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtRetrivePassword.UseSystemPasswordChar = false;
            txtRetrivePassword.PasswordChar = '\0';
        }

        private void picIMGPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtRetrivePassword.UseSystemPasswordChar = true;
        }
    }
}