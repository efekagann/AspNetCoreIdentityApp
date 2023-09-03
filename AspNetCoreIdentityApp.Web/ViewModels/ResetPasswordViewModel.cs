using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ResetPasswordViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [Display(Name = "Yeni Şifre : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Girmiş olduğunuz şifreler eşleşmiyor!")]
        [Required(ErrorMessage = "Şifre Tekrar alanı boş bırakılamaz")]
        [Display(Name = "Yeni Şifre Tekrar : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]

        public string PasswordConfirm { get; set; }
    }
}
