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
            //MD_CUSTOMER 기본값지정
            modelBuilder.Entity<MD_CUSTOMER>()
                .Property(a => a.DEL_FG)
                .HasDefaultValue("N");

            //SYS_CODE 복합키 지정
            modelBuilder.Entity<SYS_CODE>()
                .HasKey(a => new { a.SYS_CD_GROUP, a.SYS_CD });

            //MD_USER enum을 문자로 저장
            modelBuilder.Entity<MD_USER>()
                .Property(a => a.USER_ROLE)
                .HasConversion(
                    v => v.ToString(),
                    v => (UserRole)Enum.Parse(typeof(UserRole), v));


            //사용자 시드데이터
            modelBuilder.Entity<MD_USER>().HasData(new MD_USER
            {
                USER_ID = "admin",
                USER_PW = "admin1",
                USER_NM = "admin",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "A",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "A",
                USER_ROLE = UserRole.Admin
            });
        }
    }
}
