namespace PasswordManagerUI.UserControls
{
    partial class LoginsList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpLoginHolder = new System.Windows.Forms.GroupBox();
            this.panLogins = new System.Windows.Forms.Panel();
            this.grpLoginHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginHolder
            // 
            this.grpLoginHolder.Controls.Add(this.panLogins);
            this.grpLoginHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoginHolder.Location = new System.Drawing.Point(4, 4);
            this.grpLoginHolder.Name = "grpLoginHolder";
            this.grpLoginHolder.Size = new System.Drawing.Size(636, 659);
            this.grpLoginHolder.TabIndex = 0;
            this.grpLoginHolder.TabStop = false;
            this.grpLoginHolder.Text = "Logins";
            // 
            // panLogins
            // 
            this.panLogins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panLogins.AutoScroll = true;
            this.panLogins.BackColor = System.Drawing.Color.White;
            this.panLogins.Location = new System.Drawing.Point(6, 21);
            this.panLogins.Name = "panLogins";
            this.panLogins.Size = new System.Drawing.Size(624, 610);
            this.panLogins.TabIndex = 0;
            // 
            // LoginsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpLoginHolder);
            this.Name = "LoginsList";
            this.Size = new System.Drawing.Size(645, 666);
            this.grpLoginHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginHolder;
        private System.Windows.Forms.Panel panLogins;
    }
}
