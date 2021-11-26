using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
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

}
