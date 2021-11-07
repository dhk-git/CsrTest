using Csr.Models;
using Microsoft.EntityFrameworkCore;

namespace Csr.Data
{
    public class CsrDbContext : DbContext
    {
        public CsrDbContext(DbContextOptions<CsrDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = "A",
                Password = "A",
                UserName = "홍길동1"

            }, new User {
                UserID = "B",
                Password = "B",
                UserName = "홍길동2"
            });
        }
    }
}
