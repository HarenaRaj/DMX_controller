using System;
using System.Collections.Generic;

namespace HLight.Models
{
    public class Led
    {
        public int Id { get; set; }
        public Guid Key { get; set; }
        public string Name { get; set; }
        public int ChannelBegin { get; set; }
        public List<LedChannel> Channels { get; set; }
        public int StoreLedId { get; set; }
        public StoreLed StoreLed { get; set; }
        public int UniverseId { get; set; }
        public Universe Universe { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
