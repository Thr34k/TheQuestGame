using System;
using System.Collections.Generic;
using System.Text;

namespace TheQuest.Models
{
    public class Map
    {
        public int MapId { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }

        public string Name { get; set; }

        public float Size { get; set; }

        public ICollection<Enemy> Enemies { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
