namespace Data
{
    /// <summary>
    /// Serializable class for managing user logins
    /// </summary>
    [System.Serializable]
    public class Login
    {
        public int id;
        public string website;
        public string url;
        public string username;
        public string password;

        public Login()
        {

        }

        public Login(int id, string website, string url, string username, string password)
        {
            this.id = id;
            this.website = website;
            this.url = url;
            this.username = username;
            this.password = password;
        }
    }
}
