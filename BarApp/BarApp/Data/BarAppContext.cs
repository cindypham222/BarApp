using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BarApp.Models
{
    public class BarAppContext : DbContext
    {
        public BarAppContext (DbContextOptions<BarAppContext> options)
            : base(options)
        {
        }

        public DbSet<BarApp.Models.orderDrinks> orderDrinks { get; set; }
    }
}
