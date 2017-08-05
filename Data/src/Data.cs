using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Data
{
    public static class DB
    {
        private const string DataString = "Data Source = DATA.sqlite; Version=3;";

        /// <summary>
        /// Connection to the database
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection GetDataCon()
        {
            try
            {
                return new SQLiteConnection(DataString);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: {0}", ex.Message);
            }
            return null;
        }

        public static void CreateDB()
        {
            SQLiteConnection con = GetDataCon();
            con.Open();

            string sql = "CREATE TABLE logins (id INTEGER PRIMARY KEY, website VARCHAR(255), url VARCHAR(255), user_id VARCHAR(255), password VARCHAR(255))";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Dispose();
        }

    }

    

    public class DataReader
    {
        public DataReader()
        {

        }

        /// <summary>
        /// Returns a list of logins from the database
        /// </summary>
        /// <returns></returns>
        public List<Login> GetLoginData()
        {

            SQLiteConnection tempDataCon = DB.GetDataCon();
            tempDataCon.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter(
                "SELECT id AS id," +
                "website AS website," +
                "url AS url," +
                "user_id," +
                "password FROM logins", tempDataCon);

            List<Login> logins = new List<Login>();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.Dispose();
            GC.Collect();
            foreach (DataRow row in dt.Rows)
            {
                logins.Add(new Login(
                    Convert.ToInt32(row["id"]),
                    row["website"].ToString(),
                    row["url"].ToString(),
                    row["user_id"].ToString(),
                    row["password"].ToString()
                    ));
            }
            tempDataCon.Dispose();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            return logins;
        }
    }

    public class DataWriter
    {
        public DataWriter()
        {

        }

        /// <summary>
        /// Insert a single login into the database
        /// </summary>
        /// <param name="login"></param>
        public void PublishLogin(Login login)
        {

            SQLiteConnection dataCon = DB.GetDataCon();
            dataCon.Open();
            string insertLoginsQuery = "INSERT INTO logins (website, url, user_id, password) " +
            "VALUES (@website, @url, @username, @password)";

            SQLiteCommand insertCmd = new SQLiteCommand(insertLoginsQuery, dataCon);

            insertCmd.Parameters.AddWithValue("@website", login.website);
            insertCmd.Parameters.AddWithValue("@url", login.url);
            insertCmd.Parameters.AddWithValue("@username", login.username);
            insertCmd.Parameters.AddWithValue("@password", login.password);

            insertCmd.ExecuteNonQuery();
            insertCmd.Dispose();
            dataCon.Dispose();

            Data.FileIO.EncryptDatabase(FileIO.MASTER_PASSWORD);
        }

        /// <summary>
        /// Insert imported data into the database
        /// </summary>
        /// <param name="importedLogins"></param>
        public void PublishImportedData(List<Login> importedLogins)
        {
            SQLiteConnection dataCon = DB.GetDataCon();
            dataCon.Open();
            foreach (Login login in importedLogins)
            {
                string insertLoginsQuery = "INSERT INTO Logins (website, url, user_id, password) " +
                "VALUES (@website, @url, @username, @password)";

                SQLiteCommand insertCmd = new SQLiteCommand(insertLoginsQuery, dataCon);
                insertCmd.Parameters.AddWithValue("@website", login.website);
                insertCmd.Parameters.AddWithValue("@url", login.url);
                insertCmd.Parameters.AddWithValue("@username", login.username);
                insertCmd.Parameters.AddWithValue("@password", login.password);

                insertCmd.ExecuteNonQuery();
                insertCmd.Dispose();
            }
            dataCon.Dispose();
            //add the sqlite to encryted file
            Data.FileIO.EncryptDatabase(FileIO.MASTER_PASSWORD);
        }
    }
}