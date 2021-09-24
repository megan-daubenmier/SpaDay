using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "A user name is required.")]
        [StringLength(15, ErrorMessage = "Username must be between 5 and 15 characters in length.", MinimumLength = 5)]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "A password is required.")]
        [StringLength(20, ErrorMessage = "Password must be between 6 and 20 characters in length.", MinimumLength = 6)]
        [Compare("VerifyPassword", ErrorMessage = "Your passwords do not match!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please verify your password.")]
        public string VerifyPassword { get; set; }
    }
}
