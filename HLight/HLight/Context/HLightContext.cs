using MySql.Data.MySqlClient;
using System;

namespace HLight.Context
{
    public sealed class HLightContext : IDisposable
    {
        public MySqlConnection Connection
        {
            get
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    if (_connection.IsDisposed)
                    {
                        _connection = new MySqlConnection(_connectionString);
                    }
                    _connection.Open();
                }
                return _connection;
            }
        }
        private MySqlConnection _connection;
        private string _connectionString = "server=localhost;port=3306;database=hLightDb;user id=root;password=s6i9iS7w4K3MYu;";
        public HLightContext() 
        {
            _connection = new MySqlConnection(_connectionString);
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

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
