using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheQuest.Models
{
    public class Enemy
    {
        public Enemy()
        {
            this.Stats = new HashSet<Stat>();
        }
        [Key]
        public int EnemyId { get; set; }
        public string Name { get; set; }

        public ICollection<Stat> Stats { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Currency { get; set; }

        public int MapId { get; set; }

        public Map Map { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }
    }
}
