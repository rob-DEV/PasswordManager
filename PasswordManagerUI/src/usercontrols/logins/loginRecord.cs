using System.Drawing;
using System.Windows.Forms;
using Data;
using PasswordManagerUI.Forms;

namespace PasswordManagerUI.UserControls
{
    public partial class ucLoginRecord : UserControl
    {
        private MAIN m_MainInstance;
        private Login login;

        public ucLoginRecord(Login login, Point location, MAIN instance)
        {
            InitializeComponent();
            m_MainInstance = instance;
            this.login = login;
            Location = location;

            lblWebsite.Text = login.website;
            lblUser.Text = login.username;
        }

        public void SetDetails()
        {
            m_MainInstance.SetCurrentLoginDetails(login);
        }

        private void SetCurrentDetails_click(object sender, System.EventArgs e)
        {
            SetDetails();
        }
    }
}
