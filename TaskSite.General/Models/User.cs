using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSite.General.Models
{
    public enum UserRole
    {
        User,
        Admin
    }

    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Имя обязательно")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Фамилия обязательна")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Отчество обязательно")]
        [Display(Name = "Отчество")]
        public string Middlename { get; set; }

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Недопустимый email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Логин обязателен")]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пароль обязателен")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Роль обязательна")]
        [Display(Name = "Роль")]
        public UserRole Role { get; set; }

        public string RoleName()
        {
            switch (Role)
            {
                case UserRole.User:
                    return "Пользователь";
                case UserRole.Admin:
                    return "Администратор";
                default:
                    return "Гость";
            }
        }

    }



}