using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Project.Models
{
    public class BlogContext : DbContext
    {
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=BlogDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
