using System;
using System.Collections.Generic;
using System.Text;

namespace EF_INTRO.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string  Fullname { get; set; }
        public string  Title { get; set; }
        public string Body { get; set; }

        public User User { get; set; } // Navigation property
        public int UserId { get; set; } // UserId propertisine yazmaya gerek yoktur.
                                        //int => null, 1, 2, 3, 4
                                        // User classinda bir instance olusturursak otomatik olarak UserId ile Address tablosunun Id'si iliskilendirilir.

    }
}
