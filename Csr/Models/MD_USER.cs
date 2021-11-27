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
        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Comment("권한")]
        public UserRole USER_ROLE { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Developer,
        CustomerUser
    }

}
