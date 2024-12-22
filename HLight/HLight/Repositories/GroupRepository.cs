using HLight.Context;
using HLight.Enums;
using HLight.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HLight.Repositories
{
    public sealed class GroupRepository
    {
        private HLightContext _context;
        private LedRepository _ledRepository;
        public GroupRepository()
        {
            _context = HLightContext.GetInstance();
            _ledRepository = LedRepository.GetInstance();
        }

        private static GroupRepository _instance;

        public static GroupRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GroupRepository();
            }
            return _instance;
        }

        public List<Group> GetGroups()
        {
            var command = new MySqlCommand(@"
                SELECT * FROM `group`", _context.Connection);

            var reader = command.ExecuteReader();
            var groups = new List<Group>();

            while (reader.Read())
            {
                var group = new Group
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Key = Guid.Parse(reader.GetString("key")),
                    Leds = new List<Led>()
                };
                groups.Add(group);
            }
            reader.Close();
            return groups;
        }

        public Group GetGroupByKey(Guid key)
        {
            var command = new MySqlCommand(@"
                SELECT * FROM `group` where `key` = @Key", _context.Connection);

            command.Parameters.AddWithValue("@Key", key.ToString());

            var reader = command.ExecuteReader();
            var group = new Group();

            while (reader.Read())
            {
                group.Id = reader.GetInt32("id");
                group.Name = reader.GetString("name");
                group.Key = Guid.Parse(reader.GetString("key"));
                group.Leds = new List<Led>();
            }
            reader.Close();
            return group;
        }

        public void InsertGroup(Group group)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var insertGroupCommand = new MySqlCommand(@"
                            INSERT INTO `group` (`key`, `name`) VALUES (@Key, @Name)", connection, transaction);

                        insertGroupCommand.Parameters.AddWithValue("@Name", group.Name);
                        insertGroupCommand.Parameters.AddWithValue("@Key", group.Key.ToString());
                        insertGroupCommand.ExecuteNonQuery();
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
                            UPDATE `group` 
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

        public void DeleteGroup(Guid key)
        {
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateLedCommand = new MySqlCommand(@"
                            DELETE FROM `group` WHERE `key` = @Key;", connection, transaction);

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

        public void AddLed(Guid groupKey, Guid ledKey)
        {
            var group = this.GetGroupByKey(groupKey);
            var led = _ledRepository.GetLedWithoutChannelByKey(ledKey);
            using (var connection = _context.Connection)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var insertGroupCommand = new MySqlCommand(@"
                            INSERT INTO `led_group` (`led_id`, `group_id`) VALUES (@LedId, @GroupId)", connection, transaction);

                        insertGroupCommand.Parameters.AddWithValue("@LedId", led.Id);
                        insertGroupCommand.Parameters.AddWithValue("@GroupId", group.Id);
                        insertGroupCommand.ExecuteNonQuery();
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

        public List<Led> GetLedInGroup(Guid groupKey)
        {
            var command = new MySqlCommand(@"
                SELECT * FROM led", _context.Connection);

            var reader = command.ExecuteReader();
            var leds = new List<Led>();

            while (reader.Read())
            {
                var led = new Led
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Key = Guid.Parse(reader.GetString("key"))
                };
                leds.Add(led);
            }
            reader.Close();
            return leds;
        }
    }
}
