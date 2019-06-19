using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TheQuest.Models
{
    public class Stats
    {
        [Key]
        public int StatId { get; set; }

        public int Strength { get; set; }

        public int Defence { get; set; }

        public int Stamina { get; set; }

        public int Dexterity { get; set; }

        public int Intelligence { get; set; }

    }
}
