using Csr.Models;
using Microsoft.EntityFrameworkCore;

namespace Csr.Data
{
    public class CsrDbContext : DbContext
    {
        public CsrDbContext(DbContextOptions<CsrDbContext> options) : base(options)
        {

        }

        public DbSet<User>? Users {  get; set; } 
    }
}
