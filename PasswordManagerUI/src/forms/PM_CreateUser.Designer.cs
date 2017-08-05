namespace PasswordManagerUI.Forms
{
    partial class PM_CREATEUSER
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMasterPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblMasterPassword = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtMasterPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(110, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(71, 30);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMasterPasswordRepeat
            // 
            this.txtMasterPasswordRepeat.Location = new System.Drawing.Point(31, 140);
            this.txtMasterPasswordRepeat.Name = "txtMasterPasswordRepeat";
            this.txtMasterPasswordRepeat.PasswordChar = '*';
            this.txtMasterPasswordRepeat.Size = new System.Drawing.Size(229, 20);
            this.txtMasterPasswordRepeat.TabIndex = 4;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.BackColor = System.Drawing.SystemColors.Control;
            this.lblResponse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.ForeColor = System.Drawing.Color.Red;
            this.lblResponse.Location = new System.Drawing.Point(24, 178);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 20);
            this.lblResponse.TabIndex = 5;
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMasterPassword
            // 
            this.lblMasterPassword.AutoSize = true;
            this.lblMasterPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterPassword.Location = new System.Drawing.Point(47, 78);
            this.lblMasterPassword.Name = "lblMasterPassword";
            this.lblMasterPassword.Size = new System.Drawing.Size(0, 20);
            this.lblMasterPassword.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(41, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(131, 20);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Create a Database";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMasterPassword
            // 
            this.txtMasterPassword.Location = new System.Drawing.Point(31, 114);
            this.txtMasterPassword.Name = "txtMasterPassword";
            this.txtMasterPassword.PasswordChar = '*';
            this.txtMasterPassword.Size = new System.Drawing.Size(229, 20);
            this.txtMasterPassword.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(264, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PM_CREATEUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMasterPassword);
            this.Controls.Add(this.txtMasterPasswordRepeat);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblMasterPassword);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PM_CREATEUSER";
            this.Text = "Create a PM database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtMasterPasswordRepeat;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblMasterPassword;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtMasterPassword;
        private System.Windows.Forms.Button btnClose;
    }
}