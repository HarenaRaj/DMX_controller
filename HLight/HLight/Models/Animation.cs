using System.Collections.Generic;

namespace HLight.Models
{
    public class Animation
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Fader { get; set; }
        public List<Scene> Scenes { get; set; }
    }
}
