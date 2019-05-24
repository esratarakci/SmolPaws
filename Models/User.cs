using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmolPaws.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your e-mail")]
        public string EMail {get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
