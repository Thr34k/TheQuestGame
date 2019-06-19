using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheQuest.Models
{
    public class User
    {
        public User()
        {
            this.Characters = new HashSet<Character>();
        }

        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public OnlineStatus Online { get; set; }

        public string LastOnline { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}
