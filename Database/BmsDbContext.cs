using BuildingMaterialsEStore.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingMaterialsEStore.Database
{
    public class BmsDbContext:DbContext
    {
        public BmsDbContext(DbContextOptions<DbContext> options) : base(options) { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
