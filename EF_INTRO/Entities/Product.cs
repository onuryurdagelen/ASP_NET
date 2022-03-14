using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_INTRO.Entities
{
    public class Product
    {

        //primary Key(Id,<type_name> Id)
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Id'nin otomatik artma sayisini iptal ederiz.
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity alani degistirilemez.
        public DateTime InsertedDate { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // Computed degistirilebilir ve eklenebilir alan demektir.
        public DateTime LastUpdetedDate { get; set; } = DateTime.Now;


        public List<ProductCategory> ProductCategories { get; set; }

    }
}
