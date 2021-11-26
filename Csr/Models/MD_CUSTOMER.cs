using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
    [Table("MD_CUSTOMER"), Comment("MD_고객사")]
    public class MD_CUSTOMER : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(20)")]
        [Comment("고객사ID")]
        public string CUSTOMER_ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Comment("프로젝트명")]
        public string CUSTOMER_NM { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        [Comment("유효시작일")]
        public DateTime VALID_FROM_DT { get; set; }
        
        [Column(TypeName = "datetime")]
        [Comment("유효종료일")]
        public DateTime? VALID_TO_DT { get; set; }

        [Required]
        [Column(TypeName = "char(1)")]
        [Comment("삭제여부")]
        public string DEL_FG { get; set; }

    }
}
