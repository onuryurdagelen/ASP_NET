using System;
using System.Collections.Generic;
using System.Text;

namespace EF_INTRO.Entities
{
    public class OrderDemo
    {
        public OrderDemo()
        {
            Products = new List<ProductDemo>();
        }
        public int OrderId { get; set; }
        public decimal Total { get; set; }

        public string OrderName { get; set; }

        public List<ProductDemo> Products { get; set; }

    }
}
