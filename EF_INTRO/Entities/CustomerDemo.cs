using System;
using System.Collections.Generic;
using System.Text;

namespace EF_INTRO.Entities
{
    public class CustomerDemo
    {
        public CustomerDemo()
        {
            Orders = new List<OrderDemo>();
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int OrderCount { get; set; }

        public List<OrderDemo> Orders { get; set; }
    }
}
