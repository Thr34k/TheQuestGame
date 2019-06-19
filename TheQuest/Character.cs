using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheQuest.Models
{
    public class Character
    {
        public Character()
        {
            this.Stats = new HashSet<Stats>();
            this.Friends = new HashSet<Character>();
            this.Items = new HashSet<Item>();
        }

        [Key]
        public int CharacterId { get; set; }

        public string CharacterName { get; set; }

        public int Level { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Stat> Stats { get; set; }
        public ICollection<Character> Friends { get; set; }

        public ICollection<Item> Items { get; set; }

        public int Currency { get; set; }
    }
}
