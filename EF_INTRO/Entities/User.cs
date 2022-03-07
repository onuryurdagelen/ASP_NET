using System;
using System.Collections.Generic;
using System.Text;

namespace EF_INTRO.Entities
{
    public class User
    {
        public User()
        {
            this.Addresses = new List<Address>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public List<Address> Addresses { get; set; } // Navigation property
    }
}
