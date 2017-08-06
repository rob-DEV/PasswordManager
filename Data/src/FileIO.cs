using System;
using System.Diagnostics;
using System.IO;

namespace Data
{
    public class FileIO
    {
        /// <summary>
        /// The encrypted file containing user data
        /// </summary>
        public const string ENC_DATA_FILE = "DATA.enc";

        /// <summary>
        /// The db of user info which is only available when the password manager
        /// is unlocked with the master password
        /// </summary>
        public const string DNC_DATA_FILE = "DATA.sqlite";

        /// <summary>
        /// The password of the db which is only available when the password manager
        /// is unlocked with the master password (timed out)
        /// </summary>
        public static string MASTER_PASSWORD = "";

        public static ValidationResponse ValidateMasterPassword(string password)
        {
            if (isFirstTimeUser())
            {
                return ValidationResponse.NewUser;
            }
            else
            {
                if (DecryptDatabase(password))
                {
                    MASTER_PASSWORD = password;
                    return ValidationResponse.Accepted;
                }
                else
                {
                    return ValidationResponse.Refused;
                }
            }
                
        }
        /// <summary>
        /// Checks to see whether an encrypted database exists
        /// this then determines if the user is using the PM for the first time
        /// </summary>
        /// <returns></returns>

        public static bool isFirstTimeUser()
        {
            if (File.Exists(ENC_DATA_FILE))
                return false;
            else
                return true;
        }

        public static void CreateAndEncryptDatabase(string pass)
        {
            using(FileStream fs = new FileStream(DNC_DATA_FILE, FileMode.Create))
            {
                fs.Dispose();
            }
            DB.CreateDB();
            EncryptDatabase(pass);
        }

        /// <summary>
        /// Attempts to decrypt the file
        /// </summary>
        /// <param name="PASS"></param>
        /// <returns></returns>
        private static bool DecryptDatabase(string PASS)
        {

            if (Security.Security.DecryptFile(ENC_DATA_FILE, PASS, DNC_DATA_FILE))
            {
                MASTER_PASSWORD = PASS;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Updates the encrypted file with the temporary db
        /// </summary>
        public static void EncryptDatabase(string pass)
        {
            Security.Security.EncryptFile(DNC_DATA_FILE, pass);
            MASTER_PASSWORD = pass;
        }

        /// <summary>
        /// Necessary cleanup to ensure unlocked password are not left on disk
        /// refactor - manage all in memory
        /// </summary>
        public static void DeleteTempDataFiles()
        {
            //delete the file after the process has closed
            if (File.Exists(DNC_DATA_FILE))
            {
                string pathToFile = new DirectoryInfo(DNC_DATA_FILE).FullName;
                Console.WriteLine(pathToFile);
                Process.Start("cmd.exe", "/C DEL /Q /F \"DATA.sqlite\"");
                Process.Start("cmd.exe", "/C DEL /Q /F \"DATA.dat\"");
            }
        }
    }

    public enum ValidationResponse
    {
        Accepted, Refused, NewUser
    }
}
