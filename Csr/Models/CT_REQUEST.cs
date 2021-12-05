using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csr.Models
{
    [Table("CT_REQUEST"), Comment("CT_요청")]
    public class CT_REQUEST : ModelBase
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        [Comment("요청ID")]
        public int REQUEST_ID { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        [Comment("요청유형")]
        public string REQUEST_TYPE { get; set; }   //단순문의, 프로그램오류, 데이터수정

        [Column(TypeName = "varchar(50)")]
        [Comment("긴급도")]
        public string REQUEST_LEVEL { get; set; }   //


        [Column(TypeName = "date")]
        [Comment("요청일자")]
        public DateTime CREATE_DT { get; set; }

        [Comment("프로젝트ID")]
        [ForeignKey("PROJECT_ID")]
        public CT_PROJECT CT_PROJECT { get; set; }

        [Comment("사용자ID")]
        [Column(TypeName = "varchar(20)")]
        public MD_USER  MD_USER { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [Comment("제목")]
        public string REQUEST_TITLE { get; set; }
        
        [Column(TypeName = "nvarchar(max)")]
        [Comment("내용")]
        public string REQUEST_DETAIL { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Comment("요청상태")]
        public string REQUEST_STATUS { get; set; }

        [Comment("답변ID")]
        [Column(TypeName = "int")]
        public ICollection<CT_RESPONSE> CT_RESPONSE { get; set; }
    }
        
}
