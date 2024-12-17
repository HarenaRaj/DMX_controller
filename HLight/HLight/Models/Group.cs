using System;
using System.Collections.Generic;

namespace HLight.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Led> Leds { get; set; }
        public List<Scene> Scenes { get; set; }
    }
}
