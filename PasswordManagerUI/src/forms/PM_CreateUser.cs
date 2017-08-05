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
    public partial class PM_CREATEUSER : Form
    {
        public PM_CREATEUSER()
        {
            InitializeComponent();
            this.CenterToScreen();
            lblHeader.Text = "Enter your master password! \r\nDo not forget this as it \r\ncannot be recovered! \r\n Enter a strong password!";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtMasterPassword.Text == txtMasterPasswordRepeat.Text)
            {
                Data.FileIO.CreateAndEncryptDatabase(txtMasterPassword.Text);

                MAIN mainForm = new MAIN();
                mainForm.Show();
                this.Hide();
                mainForm.FormClosing += delegate { this.Close(); };
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
