using HLight.Context;
using HLight.Models;
using MySql.Data.MySqlClient;

namespace HLight.Repositories
{
    public sealed class UniverseRepository
    {
        private HLightContext _context;
        public UniverseRepository()
        {
            _context = HLightContext.GetInstance();
        }

        private static UniverseRepository _instance;

        public static UniverseRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UniverseRepository();
            }
            return _instance;
        }

        public Universe GetStoreUniverse(int id)
        {
            
            var command = new MySqlCommand($@"SELECT * FROM universe where id = {id}", _context.Connection);

            var reader = command.ExecuteReader();
            var universe = new Universe();

            while (reader.Read())
            {
                universe.Id = reader.GetInt32("Id");
                universe.Name = reader.GetString("name");
            }
            reader.Close();
            
            return universe;
        }
    }
}
