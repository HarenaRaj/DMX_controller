using System.Collections.Generic;

namespace HLight.Models
{
    public class Animation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<List<Channel>> Channels { get; set; }
    }
}
