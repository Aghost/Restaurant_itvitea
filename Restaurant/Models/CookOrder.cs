using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class CookOrder
    {
        public int id { get; set; }
        public int tableId { get; set; }
        public int foodId { get; set; }
    }
}
