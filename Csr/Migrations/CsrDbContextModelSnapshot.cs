﻿// <auto-generated />
using System;
using Csr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Csr.Migrations
{
    [DbContext(typeof(CsrDbContext))]
    partial class CsrDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Csr.Models.CT_PROJECT", b =>
                {
                    b.Property<string>("PROJECT_ID")
                        .HasColumnType("varchar(20)")
                        .HasComment("프로젝트ID");

                    b.Property<DateTime>("CREATE_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("CREATE_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("생성자");

                    b.Property<string>("MD_CUSTOMERCUSTOMER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("MODIFY_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("MODIFY_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("수정자");

                    b.Property<string>("PROJECT_NM")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasComment("프로젝트명");

                    b.Property<string>("REMARK")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("비고");

                    b.HasKey("PROJECT_ID");

                    b.HasIndex("MD_CUSTOMERCUSTOMER_ID");

                    b.ToTable("CT_PROJECT");

                    b.HasComment("CT_프로젝트");
                });

            modelBuilder.Entity("Csr.Models.MD_CUSTOMER", b =>
                {
                    b.Property<string>("CUSTOMER_ID")
                        .HasColumnType("varchar(20)")
                        .HasComment("고객사ID");

                    b.Property<DateTime>("CREATE_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("CREATE_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("생성자");

                    b.Property<string>("CUSTOMER_NM")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasComment("프로젝트명");

                    b.Property<string>("DEL_FG")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(1)")
                        .HasDefaultValue("N")
                        .HasComment("삭제여부");

                    b.Property<DateTime>("MODIFY_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("MODIFY_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("수정자");

                    b.Property<string>("REMARK")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("비고");

                    b.Property<DateTime>("VALID_FROM_DT")
                        .HasColumnType("datetime")
                        .HasComment("유효시작일");

                    b.Property<DateTime?>("VALID_TO_DT")
                        .HasColumnType("datetime")
                        .HasComment("유효종료일");

                    b.HasKey("CUSTOMER_ID");

                    b.ToTable("MD_CUSTOMER");

                    b.HasComment("MD_고객사");
                });

            modelBuilder.Entity("Csr.Models.MD_USER", b =>
                {
                    b.Property<string>("USER_ID")
                        .HasColumnType("varchar(20)")
                        .HasComment("사용자ID");

                    b.Property<DateTime>("CREATE_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("CREATE_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("생성자");

                    b.Property<DateTime>("MODIFY_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("MODIFY_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("수정자");

                    b.Property<string>("REMARK")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("비고");

                    b.Property<string>("USER_NM")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasComment("사용자명");

                    b.Property<byte[]>("USER_PW")
                        .IsRequired()
                        .HasColumnType("varbinary(100)")
                        .HasComment("사용자PW");

                    b.HasKey("USER_ID");

                    b.ToTable("MD_USER");

                    b.HasComment("MD_사용자");

                    b.HasData(
                        new
                        {
                            USER_ID = "A",
                            CREATE_DTTM = new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1270),
                            CREATE_USER_ID = "A",
                            MODIFY_DTTM = new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1279),
                            MODIFY_USER_ID = "A",
                            USER_NM = "홍길동1",
                            USER_PW = new byte[] { 65 }
                        },
                        new
                        {
                            USER_ID = "B",
                            CREATE_DTTM = new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1281),
                            CREATE_USER_ID = "A",
                            MODIFY_DTTM = new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1281),
                            MODIFY_USER_ID = "A",
                            USER_NM = "홍길동2",
                            USER_PW = new byte[] { 66 }
                        });
                });

            modelBuilder.Entity("Csr.Models.SYS_CODE", b =>
                {
                    b.Property<string>("SYS_CD_GROUP")
                        .HasColumnType("varchar(50)")
                        .HasComment("시스템코드그룹");

                    b.Property<string>("SYS_CD")
                        .HasColumnType("varchar(50)")
                        .HasComment("시스템코드");

                    b.Property<DateTime>("CREATE_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("CREATE_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("생성자");

                    b.Property<DateTime>("MODIFY_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("MODIFY_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("수정자");

                    b.Property<string>("REMARK")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("비고");

                    b.Property<decimal>("SORT_NO")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasComment("정렬순서");

                    b.Property<string>("SYS_CD_NM")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasComment("시스템코드명");

                    b.Property<string>("VALUE_1")
                        .HasColumnType("nvarchar(50)")
                        .HasComment("값1");

                    b.Property<string>("VALUE_2")
                        .HasColumnType("nvarchar(50)")
                        .HasComment("값2");

                    b.Property<string>("VALUE_3")
                        .HasColumnType("nvarchar(50)")
                        .HasComment("값3");

                    b.HasKey("SYS_CD_GROUP", "SYS_CD");

                    b.ToTable("SYS_CODE");

                    b.HasComment("SYS_시스템코드");
                });

            modelBuilder.Entity("Csr.Models.SYS_CODE_GROUP", b =>
                {
                    b.Property<string>("SYS_CD_GROUP")
                        .HasColumnType("varchar(50)")
                        .HasComment("코드그룹");

                    b.Property<DateTime>("CREATE_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("CREATE_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("생성자");

                    b.Property<DateTime>("MODIFY_DTTM")
                        .HasColumnType("datetime")
                        .HasComment("생성시간");

                    b.Property<string>("MODIFY_USER_ID")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasComment("수정자");

                    b.Property<string>("REMARK")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("비고");

                    b.Property<decimal>("SORT_NO")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasComment("정렬순서");

                    b.Property<string>("SYS_CD_GROUP_NM")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasComment("코드그룹명");

                    b.HasKey("SYS_CD_GROUP");

                    b.ToTable("SYS_CODE_GROUP");

                    b.HasComment("SYS_시스템코드_그룹");
                });

            modelBuilder.Entity("Csr.Models.CT_PROJECT", b =>
                {
                    b.HasOne("Csr.Models.MD_CUSTOMER", "MD_CUSTOMER")
                        .WithMany()
                        .HasForeignKey("MD_CUSTOMERCUSTOMER_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MD_CUSTOMER");
                });

            modelBuilder.Entity("Csr.Models.SYS_CODE", b =>
                {
                    b.HasOne("Csr.Models.SYS_CODE_GROUP", null)
                        .WithMany("SYS_CODE")
                        .HasForeignKey("SYS_CD_GROUP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Csr.Models.SYS_CODE_GROUP", b =>
                {
                    b.Navigation("SYS_CODE");
                });
#pragma warning restore 612, 618
        }
    }
}
