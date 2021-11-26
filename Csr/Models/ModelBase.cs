using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
    public class ModelBase
    {
        [Column(TypeName = "nvarchar(200)")]
        [Comment("비고")]
        public string REMARK { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Comment("생성자")]
        public string CREATE_USER_ID { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        [Comment("생성시간")]
        public DateTime CREATE_DTTM { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Comment("수정자")]
        public string MODIFY_USER_ID { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        [Comment("생성시간")]
        public DateTime MODIFY_DTTM { get; set; }
    }
}
