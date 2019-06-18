using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheQuest.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public string Name { get; set; }

        public int StatsId { get; set; }

        public Stats Stats { get; set; }

        public int LevelReq { get; set; }
    }
}
