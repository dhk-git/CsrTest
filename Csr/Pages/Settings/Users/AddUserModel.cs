using System.ComponentModel.DataAnnotations;

namespace Csr.Pages.Settings.Users
{
    public class AddUserModel
    {
        [Required]
        [Display(Name = "사용자ID")]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string UserID { get; set; }
        [Required]
        [Display(Name = "패스워드")]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string UserPW { get; set; }
        [Required]
        [Display(Name = "사용자명")]
        public string UserNm { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "업체ID")]
        public string CustomerID { get; set; }
    }
}
