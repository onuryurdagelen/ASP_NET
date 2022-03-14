using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_INTRO.Entities
{
    public class Customer
    {
        [Column("customer_id")]
        public int Id { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [NotMapped] // FullName property'sini veritabaninda kullanmak istemiyorsak bu keyword yazilir.
        public string FullName { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
