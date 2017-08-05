using System.Windows.Forms;

using Data;

namespace PasswordManagerUI.UserControls
{
    public partial class PasswordsViewPanel : UserControl
    {
        public PasswordsViewPanel()
        {
            InitializeComponent();
        }

        public void SetCurrentLogin(Login currentLogin)
        {
            lblHeader.Text = string.Format("Login Details - {0}", currentLogin.website);
            lblUrl.Text = string.Format("URL: {0}", currentLogin.url);
            lblUser.Text = string.Format("User: {0}", currentLogin.username);
            lblPasswordText.Text = string.Format(currentLogin.password);
        }

        private void btnCopyPassword_Click(object sender, System.EventArgs e)
        {
            if (lblPasswordText.Text.Length > 0)
                Clipboard.SetText(lblPasswordText.Text);
        }
    }
}
