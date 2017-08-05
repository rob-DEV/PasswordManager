using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PasswordManagerUI.Forms;
using Data;

namespace PasswordManagerUI.UserControls
{
    public partial class LoginsList : UserControl
    {
        private MAIN m_MainInstance;
        private DataReader dataReader = new DataReader();
        public void GetLogins()
        {
            panLogins.Controls.Clear();
            List<Data.Login> logins = dataReader.GetLoginData();

            for (int i = 0; i < logins.Count; i++)
            {
                panLogins.Controls.Add(new ucLoginRecord(logins[i], new Point(0, 22 * i), m_MainInstance));
            }

            logins.Clear();
        }

        public LoginsList(MAIN instance)
        {
            InitializeComponent();
            m_MainInstance = instance;
            GetLogins();
        }
    }
}
