using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
    [Table("CT_PROJECT"), Comment("CT_프로젝트")]
    public class CT_PROJECT : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(20)")]
        [Comment("프로젝트ID")]
        public string PROJECT_ID { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Comment("프로젝트명")]
        public string PROJECT_NM { get; set; }

        [Required]
        [Comment("고객사ID")]
        [Column(TypeName = "varchar(20)")]
        public string CUSTOMER_ID { get; set; }
    }
}
