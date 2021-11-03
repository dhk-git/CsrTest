using System.ComponentModel.DataAnnotations;

namespace Csr.Models
{
    public class User
    {
        [Key]
        [Required]
        public string? UserID { get; set; }
        [Required]
        public string? UserName {  get; set; }
    }
}
