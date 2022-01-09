using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [Required(ErrorMessage = "Full Name is required")]
        [MinLength(4, ErrorMessage = "Must be 4-30 characters")]
        [MaxLength(30, ErrorMessage = "Max Full Name Length is 30 characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(40, ErrorMessage = "Max Email Length is 40 characters")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
    }
}
