using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.ViewModels;

public class RegisterViewModel
{
    [Display(Name = "Адрес электронной почты")]
    [Required(ErrorMessage = "Требуется адрес электронной почты")]
    public string EmailAddress { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Display(Name = "Подтвердите пароль")]
    [Required(ErrorMessage = "Требуется подтвердить пароль")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Пароль не совпадает")]
    public string ConfirmPassword { get; set; }
}
