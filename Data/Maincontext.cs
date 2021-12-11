using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using product_backend.Models;

namespace product_backend.Data
{
    public class Maincontext: DbContext
    {
        public Maincontext(DbContextOptions<Maincontext> options):base(options)
        {

        }

        public DbSet<StatusEntity> statusEntity { get; set; }
        public DbSet<CategoryEntity> categoryEntity { get; set; }
        public DbSet<ProductEntity> productEntity { get; set; }
    }
}
