using System.ComponentModel.DataAnnotations;

namespace 期末.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "請輸入名字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入 Email")]
        [EmailAddress(ErrorMessage = "Email 格式不正確")]
        public string Email { get; set; }
    }
}
