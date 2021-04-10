using ExcelentTaste.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelentTaste.Data
{
    class ExcelentTasteDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        /* Voor de Opdracht
        public DbSet<Order> Orders { get; set; }
        public DbSet<BarOrder> BarOrders { get; set; }
        public DbSet<CookOrder> CookOrders { get; set; }
        public DbSet<Reservering> Reservations { get; set; }
        */

    }
}
