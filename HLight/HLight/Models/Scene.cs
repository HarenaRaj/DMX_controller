using System.Collections.Generic;

namespace HLight.Models
{
    public class Scene
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public List<Led> Leds { get; set; }
        public int IdGroup { get; set; }
        public Group Group { get; set; }
    }
}
