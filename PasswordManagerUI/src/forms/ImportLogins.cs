using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Data;

namespace PasswordManagerUI.Forms
{
    public partial class IMPORTPASSWORDS : Form
    {
        public IMPORTPASSWORDS()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportCSV();
        }

        private void ImportCSV()
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "CSV files (.csv) | *.csv| All files (*.*)|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                lblPathToFile.Text = diag.FileName;
                string pathToFile = diag.FileName;

                if (pathToFile.Length > 1)
                {
                    List<Login> logins = new List<Login>();
                    try
                    {
                        //read in the csv file and add it to a list of logins
                        using (StreamReader reader = new StreamReader(pathToFile))
                        {
                            while (!reader.EndOfStream)
                            {
                                string currentLine = reader.ReadLine();
                                string[] values = currentLine.Split(',');

                                logins.Add(new Login(-1, values[0], values[1], values[2], values[3]));
                            }
                        }
                        if (logins.Count < 1)
                            return;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("ERROR: " + ex.Message);
                    }

                    DataWriter dw = new DataWriter();
                    dw.PublishImportedData(logins);
                }

            }
        }
    }
}
