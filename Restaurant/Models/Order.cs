using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Consumeable
    {
        public int id { get; set; }
        public bool isReady { get; set; }
    }

    public class Order
    {
        public int id { get; set; }
        public int tableId { get; set; }
        public List<Consumeable> foodIds { get; set; }  // tussentabel
        public List<Consumeable> drinkIds { get; set; } // tussentabel
        public int totalPrice { get; set; }
        public bool completed { get; set; }
    }
}
