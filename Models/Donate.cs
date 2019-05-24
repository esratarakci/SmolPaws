using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmolPaws.Models
{
    public class Donate
    {
        //date ekle
        public int DonateId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your credit card information")]
        public string CreditCard { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your donation")]
        public int Donation { get; set; }
    }
}
