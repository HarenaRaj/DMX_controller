using HLight.Context;
using HLight.Enums;
using HLight.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace HLight.Repositories
{
    public sealed class StoreLedRepository
    {
        private HLightContext _context;
        public StoreLedRepository()
        {
            _context = HLightContext.GetInstance();
        }

        private static StoreLedRepository _instance;

        public static StoreLedRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StoreLedRepository();
            }
            return _instance;
        }

        public List<StoreLed> GetStoreLeds()
        {
            
            var command = new MySqlCommand(@"
                SELECT 
                    sl.id AS LedId, sl.name, sl.number_channel, sl.type AS LedType,
                    slc.id AS ChannelId, slc.channel_number, slc.type AS ChannelType, slc.store_led_id
                FROM store_led sl
                LEFT JOIN store_led_channel slc ON sl.id = slc.store_led_id", _context.Connection);

            var reader = command.ExecuteReader();
            var storeLeds = new List<StoreLed>();

            while (reader.Read())
            {
                var storeLed = storeLeds.FirstOrDefault(x => x.Id == reader.GetInt32("LedId"));
                if (storeLed == null)
                {
                    storeLed = new StoreLed
                    {
                        Id = reader.GetInt32("LedId"),
                        Name = reader.GetString("name"),
                        NumberChannel = reader.GetInt32("number_channel"),
                        Type = (LedType)reader.GetInt32("LedType"),
                        Channels = new List<StoreLedChannel>()
                    };
                    storeLeds.Add(storeLed);
                }

                if (!reader.IsDBNull(reader.GetOrdinal("ChannelId")))
                {
                    var storeLedChannel = new StoreLedChannel
                    {
                        Id = reader.GetInt32("ChannelId"),
                        ChannelNumber = reader.GetInt32("channel_number"),
                        Type = (ChannelType)reader.GetInt32("ChannelType"),
                        StoreLedId = reader.GetInt32("store_led_id"),
                    };
                    storeLed.Channels.Add(storeLedChannel);
                }
            }
            reader.Close();
            
            return storeLeds;
        }
    }
}
