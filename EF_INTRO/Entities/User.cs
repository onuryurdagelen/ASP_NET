using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [MinLength(8),MaxLength(15)]
        public string Username { get; set; }

        [Column(TypeName= "nvarchar(20)")]
        public string Email { get; set; }

        public Customer Customer { get; set; } // One To One Relationship


        public List<Address> Addresses { get; set; } // Navigation property
    }
}
