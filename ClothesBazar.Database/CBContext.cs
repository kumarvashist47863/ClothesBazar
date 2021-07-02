using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothesBazar.Entities;

namespace ClothesBazar.Database
{
    class CBContext : DbContext
    {
        public CBContext() : base("ClothBazarConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
