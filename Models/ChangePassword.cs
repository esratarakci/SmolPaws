using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmolPaws.Models
{
    public class ChangePassword
    {
        [Required(ErrorMessage = "Please enter your old password")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Please enter new password")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Please enter new password again")]
        [Compare("NewPassword",ErrorMessage = "Passwords Do Not Match")]
        public string NewPassword2 { get; set; }
    }
}
