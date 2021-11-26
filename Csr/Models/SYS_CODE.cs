using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
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
