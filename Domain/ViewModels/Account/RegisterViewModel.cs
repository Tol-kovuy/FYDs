using System.ComponentModel.DataAnnotations;

namespace FYD_s.Domain.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Вкажить Ім'я")]
        [MaxLength(20, ErrorMessage = "Ім'я повінно мати довжину менше 20 символів")]
        [MinLength(3, ErrorMessage = "Ім'я повінно мати довжину більше 3 символів")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Вкажить пароль")]
        [MinLength(6, ErrorMessage = "Пароль повінен мати довжину більш 6 символів")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "ППідтвердіть пароль")]
        [Compare("Password", ErrorMessage = "Паролі не співпадают")]
        public string PasswordConfirm { get; set; }
    }
}
