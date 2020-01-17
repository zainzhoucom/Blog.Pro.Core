using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.Manage.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [DisplayName("账号")]
        public string account { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [DisplayName("密码")]
        public string checkPass { get; set; }
    }
}
