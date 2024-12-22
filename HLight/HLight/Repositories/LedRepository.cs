using HLight.Context;
using HLight.Enums;
using HLight.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

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
                    l.id AS LedId, l.name, l.number_channel, l.type AS LedType, l.value
                    lc.id AS ChannelId, lc.channel_number, lc.type AS ChannelType, lc.led_id
                FROM led l
                LEFT JOIN led_channel lc ON l.id = lc.led_id", _context.Connection);

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

        public List<Led> GetLedsByUniverseId(int universeId)
        {
            var command = new MySqlCommand(@"
                SELECT 
                    l.id AS LedId, l.key, l.name, l.channel_begin, l.store_led_id, l.universe_id, l.position_x, l.position_y,
                    lc.id AS ChannelId, lc.channel_number, lc.type AS ChannelType, lc.led_id, lc.value,
                    s.id AS StoreLedId, s.name AS StoreLedName, s.number_channel, s.type AS StoreLedType
                FROM led l
                LEFT JOIN led_channel lc ON l.id = lc.led_id
                LEFT JOIN store_led s ON l.store_led_id = s.id", _context.Connection);

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
                        Key = Guid.Parse(reader.GetString("key")),
                        Name = reader.GetString("name"),
                        ChannelBegin = reader.GetInt32("channel_begin"),
                        StoreLedId = reader.GetInt32("store_led_id"),
                        UniverseId = reader.GetInt32("universe_id"),
                        PositionX = reader.GetInt32("position_x"),
                        PositionY = reader.GetInt32("position_y"),
                        StoreLed = new StoreLed
                        {
                            Id = reader.GetInt32("StoreLedId"),
                            Name = reader.GetString("StoreLedName"),
                            NumberChannel = reader.GetInt32("number_channel"),
                            Type = (LedType)reader.GetInt32("StoreLedType"),
                        },
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
                        LedId = reader.GetInt32("led_id"),
                        Value = reader.GetInt32("value")
                    };
                    led.Channels.Add(ledChannel);
                }
            }
            reader.Close();
            return leds;
        }

        public void InsertLed(Led led)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var insertLedCommand = new MySqlCommand(@"
                            INSERT INTO led 
                                (`key`, `name`, `channel_begin`, `store_led_id`, `universe_id`, `position_x`, `position_y`)
                            VALUES 
                                (@Key, @Name, @ChannelBegin, @StoreLedId, @UniverseId, @PositionX, @PositionY);
                            SELECT LAST_INSERT_ID();", connection, transaction);

                        insertLedCommand.Parameters.AddWithValue("@Key", led.Key.ToString());
                        insertLedCommand.Parameters.AddWithValue("@Name", led.Name);
                        insertLedCommand.Parameters.AddWithValue("@ChannelBegin", led.ChannelBegin);
                        insertLedCommand.Parameters.AddWithValue("@StoreLedId", led.StoreLedId);
                        insertLedCommand.Parameters.AddWithValue("@UniverseId", led.UniverseId);
                        insertLedCommand.Parameters.AddWithValue("@PositionX", led.PositionX);
                        insertLedCommand.Parameters.AddWithValue("@PositionY", led.PositionY);

                        var ledId = Convert.ToInt32(insertLedCommand.ExecuteScalar());
                        foreach (var channel in led.Channels)
                        {
                            channel.LedId = ledId; // Associer l'ID de la LED

                            var insertChannelCommand = new MySqlCommand(@"
                                INSERT INTO led_channel 
                                    (`type`, `channel_number`, `value`, `led_id`)
                                VALUES 
                                    (@Type, @ChannelNumber, @Value, @LedId)", connection, transaction);

                            insertChannelCommand.Parameters.AddWithValue("@Type", channel.Type);
                            insertChannelCommand.Parameters.AddWithValue("@ChannelNumber", channel.ChannelNumber);
                            insertChannelCommand.Parameters.AddWithValue("@Value", channel.Value);
                            insertChannelCommand.Parameters.AddWithValue("@LedId", channel.LedId);

                            insertChannelCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdatePosition(Guid key, int x, int y)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateLedCommand = new MySqlCommand(@"
                            UPDATE led 
                            SET position_x = @PositionX, position_y = @PositionY
                            WHERE `key` = @Key;", connection, transaction);

                        updateLedCommand.Parameters.AddWithValue("@PositionX", x);
                        updateLedCommand.Parameters.AddWithValue("@PositionY", y);
                        updateLedCommand.Parameters.AddWithValue("@Key", key.ToString());

                        updateLedCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdateChannelNumber(Guid key, int channel_number)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateLedCommand = new MySqlCommand(@"
                            UPDATE led 
                            SET channel_begin = @ChannelBegin
                            WHERE `key` = @Key;", connection, transaction);

                        updateLedCommand.Parameters.AddWithValue("@ChannelBegin", channel_number);
                        updateLedCommand.Parameters.AddWithValue("@Key", key.ToString());

                        updateLedCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdateName(Guid key, string name)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateLedCommand = new MySqlCommand(@"
                            UPDATE led 
                            SET name = @Name
                            WHERE `key` = @Key;", connection, transaction);

                        updateLedCommand.Parameters.AddWithValue("@Name", name);
                        updateLedCommand.Parameters.AddWithValue("@Key", key.ToString());

                        updateLedCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void DeleteLed(Guid key)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateLedCommand = new MySqlCommand(@"
                            DELETE FROM led WHERE `key` = @Key;", connection, transaction);

                        updateLedCommand.Parameters.AddWithValue("@Key", key.ToString());

                        updateLedCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public Led GetLedWithoutChannelByKey(Guid key)
        {
            var command = new MySqlCommand(@"
                SELECT * FROM led where `key` = @Key", _context.Connection);

            command.Parameters.AddWithValue("@Key", key.ToString());

            var reader = command.ExecuteReader();
            var led = new Led();

            while (reader.Read())
            {
                led = new Led
                {
                    Id = reader.GetInt32("id"),
                    Key = Guid.Parse(reader.GetString("key")),
                    Name = reader.GetString("name"),
                    ChannelBegin = reader.GetInt32("channel_begin"),
                    StoreLedId = reader.GetInt32("store_led_id"),
                    UniverseId = reader.GetInt32("universe_id"),
                    PositionX = reader.GetInt32("position_x"),
                    PositionY = reader.GetInt32("position_y"),
                    StoreLed = new StoreLed(),
                    Channels = new List<LedChannel>()
                };
            }
            reader.Close();
            return led;
        }
    }
}
