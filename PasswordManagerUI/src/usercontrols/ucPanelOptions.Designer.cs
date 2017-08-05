namespace PasswordManagerUI.UserControls
{
    partial class ucPanelOptions
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
            this.picOption = new System.Windows.Forms.PictureBox();
            this.lblOption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            this.SuspendLayout();
            // 
            // picOption
            // 
            this.picOption.Location = new System.Drawing.Point(7, 8);
            this.picOption.Name = "picOption";
            this.picOption.Size = new System.Drawing.Size(25, 25);
            this.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOption.TabIndex = 0;
            this.picOption.TabStop = false;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(38, 12);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(61, 16);
            this.lblOption.TabIndex = 1;
            this.lblOption.Text = "lblOption";
            this.lblOption.Click += new System.EventHandler(this.LINK_Click);
            // 
            // ucPanelOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.picOption);
            this.Name = "ucPanelOption";
            this.Size = new System.Drawing.Size(123, 40);
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOption;
        private System.Windows.Forms.Label lblOption;
    }
}
