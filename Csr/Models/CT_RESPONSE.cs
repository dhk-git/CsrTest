using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
    [Table("CT_RESPONSE"), Comment("CT_답변")]
    public class CT_RESPONSE : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        [Comment("답변ID")]
        public int RESPONSE_ID { get; set; }

        [Comment("사용자ID")]
        [Column(TypeName = "varchar(20)")]
        public MD_USER USER_ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Comment("제목")]
        public string RESPONSE_TITLE { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        [Comment("내용")]
        public string RESPONSE_DETAIL { get; set; }
        
        [Column(TypeName = "datetime")]
        [Comment("시작일시")]
        public DateTime FROM_DTTM { get; set; }
        
        [Column(TypeName = "datetime")]
        [Comment("종료일시")]
        public DateTime TO_DTTM { get; set; }

        [Column(TypeName = "int")]
        [Comment("실투입공수")]
        [Precision(5, 2)]
        public decimal MAN_HOUR { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Comment("답변상태")]
        public string RESPONSE_STATUS { get; set; }

    }
}
