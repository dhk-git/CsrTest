using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
    [Table("MD_USER"), Comment("MD_사용자") ]
    public class MD_USER : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(20)")]
        [Comment("사용자ID")]
        public string USER_ID { get; set; }
        
        [Required]
        [Column(TypeName = "varbinary(100)")]
        [Comment("사용자PW")]
        public string USER_PW { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Comment("사용자명")]
        public string USER_NM {  get; set; }
        
    }

    [Table("SYS_CODE_GROUP"), Comment("SYS_시스템코드_그룹")]
    public class SYS_CODE_GROUP : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Comment("코드그룹")]
        public string SYS_CD_GROUP { get; set; }

        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Comment("코드그룹명")]
        public string SYS_CD_GROUP_NM { get; set; }

        [Precision(5, 2)]
        [Comment("정렬순서")]
        public decimal SORT_NO { get; set; }

        public ICollection<SYS_CODE> SYS_CODE { get; set; }
    }
    [Table("SYS_CODE"), Comment("SYS_시스템코드")]
    public class SYS_CODE : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Comment("시스템코드그룹")]
        public string SYS_CD_GROUP { get; set; }
        [Key]
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Comment("시스템코드")]
        public string SYS_CD { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Comment("시스템코드명")]
        public string SYS_CD_NM { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Comment("값1")]
        public string VALUE_1 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Comment("값2")]
        public string VALUE_2 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Comment("값3")]
        public string VALUE_3 { get; set; }

        [Precision(5, 2)]
        [Comment("정렬순서")]
        public decimal SORT_NO { get; set; }
    }

}
