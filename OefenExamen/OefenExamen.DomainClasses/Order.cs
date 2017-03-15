using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenExamen.DomainClasses
{
    
    public class Order
    {
       
        public Products product { get; set; }
        public int quantity { get; set; }

        public Order(Products product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

    }
}
