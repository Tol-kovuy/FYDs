﻿using System.ComponentModel.DataAnnotations;

namespace FYD_s.Domain.ViewModels.Account
{
    public class ChangePasswordViewModel
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [MinLength(5, ErrorMessage = "Пароль должен быть больше или равен 5 символов")]
        public string NewPassword { get; set; }
    }
}
