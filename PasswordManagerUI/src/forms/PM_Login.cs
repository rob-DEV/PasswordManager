using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerUI.Forms
{
    public partial class APPLOGIN : Form
    {
        public APPLOGIN()
        {
            InitializeComponent();
            this.CenterToScreen();
        }



        #region Login
        private void ValidateMasterPassword()
        {
            Data.ValidationResponse response = Data.FileIO.ValidateMasterPassword(txtMasterPassword.Text);
            if (response == Data.ValidationResponse.Accepted)
            {
                MAIN mainForm = new MAIN();
                mainForm.Show();
                this.Hide();
                mainForm.FormClosing += delegate { this.Close(); };
            }
            else if(response == Data.ValidationResponse.Refused)
            {
                lblResponse.Text = "Password Incorrect! Cannot decrypt database.";
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidateMasterPassword();
        }

        
        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMasterPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateMasterPassword();
            }
            e.Handled = e.SuppressKeyPress = true;          
        }
    }
}
