using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManagerUI.Forms;

namespace PasswordManagerUI.UserControls
{
    public partial class ucPanelOptions : UserControl
    {
        private MAIN m_MAIN;
        bool isPlaceHolder;

        public ucPanelOptions(string lblOptionText, Point position, MAIN main_instance, Image icon = null)
        {
            InitializeComponent();
            m_MAIN = main_instance;
            //UI and position
            lblOption.Text = lblOptionText;
            this.Location = position;
            isPlaceHolder = false;
            if (lblOptionText.Length < 1)
                isPlaceHolder = true;

            if (icon != null)
                picOption.Image = icon;
        }


        private void LINK_Click(object sender, EventArgs e)
        {

        }
    }
}
