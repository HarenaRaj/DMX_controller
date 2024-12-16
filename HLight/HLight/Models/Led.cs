using System;
using System.Collections.Generic;

namespace HLight.Models
{
    public class Led
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ChannelBegin { get; set; }
        public List<Channel> Channels { get; set; }
        public int IdStoreLed { get; set; }
        public StoreLed StoreLed { get; set; }
    }
}
