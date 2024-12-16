using HLight.Enums;
using System.Collections.Generic;

namespace HLight.Models
{
    public class Led
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberChannel { get; set; }
        public List<Channel> Channels { get; set; }
        public int ChannelBegin { get; set; }
        public LedType Type { get; set; }
    }
}
