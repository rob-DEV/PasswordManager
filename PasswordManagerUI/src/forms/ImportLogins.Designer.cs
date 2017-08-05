namespace PasswordManagerUI.Forms
{
    partial class IMPORTPASSWORDS
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
            this.btnImport = new System.Windows.Forms.Button();
            this.lblPathToFile = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(102, 79);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(132, 27);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import a File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblPathToFile
            // 
            this.lblPathToFile.AutoSize = true;
            this.lblPathToFile.Location = new System.Drawing.Point(12, 59);
            this.lblPathToFile.Name = "lblPathToFile";
            this.lblPathToFile.Size = new System.Drawing.Size(0, 13);
            this.lblPathToFile.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(9, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(319, 48);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Choose a CSV file to import from\r\nColumn Structure:\r\n(DISPLAY_NAME, URL, USERNAME" +
    ". PASSWORD)";
            // 
            // IMPORTLOGINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 131);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblPathToFile);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "IMPORTLOGINFORM";
            this.Text = "PasswordImporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblPathToFile;
        private System.Windows.Forms.Label lblHeader;
    }
}