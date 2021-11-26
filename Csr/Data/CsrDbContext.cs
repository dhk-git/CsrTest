using Csr.Models;
using Microsoft.EntityFrameworkCore;

namespace Csr.Data
{
    public class CsrDbContext : DbContext
    {
        public CsrDbContext(DbContextOptions<CsrDbContext> options) : base(options)
        {

        }

        public DbSet<SYS_CODE_GROUP> SYS_CODE_GROUP { get; set; }
        public DbSet<SYS_CODE> SYS_CODE { get; set; }
        public DbSet<MD_USER> MD_USER { get; set; }
        public DbSet<MD_CUSTOMER> MD_CUSTOMER { get; set; }
        public DbSet<CT_PROJECT> CT_PROJECT { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MD_CUSTOMER>()
                .Property(a => a.DEL_FG)
                .HasDefaultValue("N");
            
            modelBuilder.Entity<MD_CUSTOMER>()
                .Property(a => a.DEL_FG)
                .HasDefaultValue("N");
            modelBuilder.Entity<SYS_CODE>()
                .HasKey(a => new { a.SYS_CD_GROUP, a.SYS_CD });

            modelBuilder.Entity<MD_USER>().HasData(new MD_USER
            {
                USER_ID = "A",
                USER_PW = "A",
                USER_NM = "홍길동1",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "A",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "A"

            }, new MD_USER {
                USER_ID = "B",
                USER_PW = "B",
                USER_NM = "홍길동2",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "A",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "A"
            });
        }
    }
}
