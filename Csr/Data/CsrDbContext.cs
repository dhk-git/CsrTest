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
        public DbSet<CT_REQUEST> CT_REQUEST { get; set; }
        public DbSet<CT_RESPONSE> CT_RESPONSE { get; set; }

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


            //포린키 지정
            modelBuilder.Entity<CT_RESPONSE>()
                .HasOne<CT_REQUEST>()
                .WithMany()
                .HasForeignKey(p => p.REQUEST_ID);


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

            //시스템 코드 그룹
            modelBuilder.Entity<SYS_CODE_GROUP>().HasData(new SYS_CODE_GROUP {
                SYS_CD_GROUP = "REQUEST_TYPE",
                SYS_CD_GROUP_NM = "요청유형",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "admin",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "admin",
                SORT_NO = 1
            });

            //시스템 코드 - 요청유형
            modelBuilder.Entity<SYS_CODE>().HasData(new SYS_CODE
            {
                SYS_CD_GROUP = "REQUEST_TYPE",
                SYS_CD = "Question",
                SYS_CD_NM = "단순문의",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "admin",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "admin",
                SORT_NO = 1
            });
            modelBuilder.Entity<SYS_CODE>().HasData(new SYS_CODE
            {
                SYS_CD_GROUP = "REQUEST_TYPE",
                SYS_CD = "ProgramError",
                SYS_CD_NM = "프로그램오류",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "admin",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "admin",
                SORT_NO = 1
            });
            modelBuilder.Entity<SYS_CODE>().HasData(new SYS_CODE
            {
                SYS_CD_GROUP = "REQUEST_TYPE",
                SYS_CD = "ModifyData",
                SYS_CD_NM = "데이터수정",
                CREATE_DTTM = DateTime.Now,
                CREATE_USER_ID = "admin",
                MODIFY_DTTM = DateTime.Now,
                MODIFY_USER_ID = "admin",
                SORT_NO = 1
            });


        }
    }
}
