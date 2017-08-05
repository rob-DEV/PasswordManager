using System;
using System.Linq;
using System.Windows.Forms;
using Data;
namespace PasswordManagerUI.Forms
{
    public partial class CREATELOGIN : Form
    {
        public CREATELOGIN()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void createLogin()
        {
            string loginDisplayName = txtUrl.Text;
            if (txtUrl.Text.Contains("www."))
            {
                //index pointers
                //0123456789
                //www.ebay.com
                //display name becomes Ebay

                loginDisplayName = loginDisplayName.Split('.')[1];
                loginDisplayName = loginDisplayName.First().ToString().ToUpper() + loginDisplayName.Substring(1);
            }

            Login createdLogin = new Login(1, loginDisplayName, txtUrl.Text, txtUser.Text, txtPassword.Text);
            DataWriter dr = new DataWriter();
            dr.PublishLogin(createdLogin);
            MessageBox.Show("Successfully Saved!");
            this.Close();
        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Length > 0 && txtUser.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (txtPassword.Text == txtRetypePassword.Text)
                {
                    createLogin();
                }
            }
        }
    }
}
