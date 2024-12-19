using HLight.Context;
using HLight.Enums;
using HLight.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace HLight.Repositories
{
    public sealed class LedRepository
    {
        private HLightContext _context;
        public LedRepository()
        {
            _context = HLightContext.GetInstance();
        }

        private static LedRepository _instance;

        public static LedRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LedRepository();
            }
            return _instance;
        }

        public List<Led> GetLeds()
        {
            var command = new MySqlCommand(@"
                SELECT 
                    sl.id AS LedId, sl.name, sl.number_channel, sl.type AS LedType,
                    slc.id AS ChannelId, slc.channel_number, slc.type AS ChannelType, slc.store_led_id
                FROM store_led sl
                LEFT JOIN store_led_channel slc ON sl.id = slc.store_led_id", _context.Connection);

            var reader = command.ExecuteReader();
            var leds = new List<Led>();

            while (reader.Read())
            {
                var led = leds.FirstOrDefault(x => x.Id == reader.GetInt32("LedId"));
                if (led == null)
                {
                    led = new Led
                    {
                        Id = reader.GetInt32("LedId"),
                        Name = reader.GetString("name"),
                        Channels = new List<LedChannel>()
                    };
                    leds.Add(led);
                }

                if (!reader.IsDBNull(reader.GetOrdinal("ChannelId")))
                {
                    var ledChannel = new LedChannel
                    {
                        Id = reader.GetInt32("ChannelId"),
                        ChannelNumber = reader.GetInt32("channel_number"),
                        Type = (ChannelType)reader.GetInt32("ChannelType"),
                        LedId = reader.GetInt32("store_led_id"),
                    };
                    led.Channels.Add(ledChannel);
                }
            }
            reader.Close();
            return leds;
        }
    }
}
