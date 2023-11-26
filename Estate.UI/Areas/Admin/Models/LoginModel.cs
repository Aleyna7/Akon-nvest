using System.ComponentModel.DataAnnotations;

namespace Estate.UI.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Boş Bırakılamz")]
        public string Username {  get; set; }
        [Required(ErrorMessage = "Boş Bırakılamz")]
        [DataType(DataType.Password,ErrorMessage ="Şifre Tipinde Değil")]
        public string Password { get; set; }
    }
}
