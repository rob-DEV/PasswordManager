using System;
using System.Drawing;
using System.Windows.Forms;
using PasswordManagerUI.UserControls;

namespace PasswordManagerUI.Forms
{
    public partial class MAIN : Form
    {
        //references to UI elements
        private LoginsList loginsPanel;
        private PasswordsViewPanel passwordsPanel;

        #region UI
        /// <summary>
        /// Instantiates the UI for main and assigns them to their respective Controls
        /// </summary>
        private void init()
        {
            loginsPanel = new LoginsList(this);
            splitContainer.Panel1.Controls.Add(loginsPanel);
            passwordsPanel = new PasswordsViewPanel();
            splitContainer.Panel2.Controls.Add(passwordsPanel);
        }

        /// <summary>
        /// Updates the Login details view panel with the currently selected Login Record
        /// </summary>
        /// <param name="currentLogin"></param>
        public void SetCurrentLoginDetails(Data.Login currentLogin)
        {
            passwordsPanel.SetCurrentLogin(currentLogin);
        } 
        #endregion

        public MAIN()
        {
            InitializeComponent();
            this.CenterToScreen();
            init();
            //form closing 
            this.FormClosing += Exit;
        }

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            //context sub menu
            lblMenu.ContextMenu = new ContextMenu();
            lblMenu.ContextMenu.MenuItems.Add(new MenuItem("Create Login", OpenLoginCreationForm));
            lblMenu.ContextMenu.MenuItems.Add(new MenuItem("Password Importer", OpenPasswordImporter));

            panLeftSideBar.Controls.
                Add(new ucPanelOptions("", new Point(0, 0), this));
            panLeftSideBar.Controls.
                Add(new ucPanelOptions("Logins", new Point(0, 40), this, Properties.Resources.padlock));
            panLeftSideBar.Controls.
                Add(new ucPanelOptions("Notes", new Point(0, 80), this, Properties.Resources.notepad));
            panLeftSideBar.Controls.
                Add(new ucPanelOptions("Applications", new Point(0, 120), this, Properties.Resources.app));
            panLeftSideBar.Controls.
                Add(new ucPanelOptions("Contacts", new Point(0, 160), this, Properties.Resources.contacts));
        }
        private void lblMenu_Click(object sender, EventArgs e)
        {
            Label menuLbl = sender as Label;
            menuLbl.ContextMenu.Show(menuLbl, new Point(50,10));
        }

        /// <summary>
        /// Opens the password import form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPasswordImporter(object sender, EventArgs e)
        {
            IMPORTPASSWORDS passwordImportForm = new IMPORTPASSWORDS();
            passwordImportForm.ShowDialog();
        }

        /// <summary>
        /// Opens the login creation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLoginCreationForm(object sender, EventArgs e)
        {
            CREATELOGIN loginCreationForm = new CREATELOGIN();
            loginCreationForm.ShowDialog();
        }
        private void Exit(object sender, FormClosingEventArgs e)
        {
            loginsPanel.Dispose();
            passwordsPanel.Dispose();
            Data.FileIO.DeleteTempDataFiles();
        } 
        #endregion

        #region MenuStrip
        private void menuRefreshBtn_Click(object sender, EventArgs e)
        {
            loginsPanel.GetLogins();
        }

        private void menuFile_Click(object sender, EventArgs e)
        {
            ToolBarButton fileMenuBtn = sender as ToolBarButton;
            //fileMenuBtn.
        }
        #endregion
    }
}
