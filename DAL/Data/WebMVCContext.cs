using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL.Data
{
    public class WebMVCContext : DbContext
    {
        public WebMVCContext (DbContextOptions<WebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DAL.Models.Product> Product { get; set; } = default!;
    }
}
