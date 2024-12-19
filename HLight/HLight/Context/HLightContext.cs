using MySql.Data.MySqlClient;

namespace HLight.Context
{
    public sealed class HLightContext
    {
        public MySqlConnection Connection { get; set; }
        public HLightContext() 
        {
            Connection = new MySqlConnection("server=localhost;port=3306;database=hLightDb;user id=root;password=s6i9iS7w4K3MYu;");
            Connection.Open();
        }

        private static HLightContext _instance;

        public static HLightContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HLightContext();
            }
            return _instance;
        }
    }
}
