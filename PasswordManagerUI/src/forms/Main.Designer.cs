namespace PasswordManagerUI.Forms
{
    partial class MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panLeftSideBar = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.menuFile = new System.Windows.Forms.ToolStripLabel();
            this.menuRefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.panLeftSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLeftSideBar
            // 
            this.panLeftSideBar.Controls.Add(this.lblMenu);
            this.panLeftSideBar.Location = new System.Drawing.Point(0, 26);
            this.panLeftSideBar.Name = "panLeftSideBar";
            this.panLeftSideBar.Size = new System.Drawing.Size(123, 643);
            this.panLeftSideBar.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(27, 12);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(66, 25);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(125, 27);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Size = new System.Drawing.Size(962, 642);
            this.splitContainer.SplitterDistance = 642;
            this.splitContainer.TabIndex = 2;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuRefreshBtn});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1084, 25);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "toolStrip1";
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(25, 22);
            this.menuFile.Text = "File";
            this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
            // 
            // menuRefreshBtn
            // 
            this.menuRefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuRefreshBtn.Image = global::PasswordManagerUI.Properties.Resources.refresh;
            this.menuRefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRefreshBtn.Name = "menuRefreshBtn";
            this.menuRefreshBtn.Size = new System.Drawing.Size(23, 22);
            this.menuRefreshBtn.Text = "toolStripButton1";
            this.menuRefreshBtn.Click += new System.EventHandler(this.menuRefreshBtn_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 671);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panLeftSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panLeftSideBar.ResumeLayout(false);
            this.panLeftSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panLeftSideBar;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripLabel menuFile;
        private System.Windows.Forms.ToolStripButton menuRefreshBtn;
    }
}

