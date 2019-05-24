using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmolPaws.Models
{
    public class Animal
    {
        //Date ve image ekle
        public int AnimalId { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the amount of donate needed")]
        public int DonateNeeded { get; set; }
        public int CurrentMoney { get; set; }
        public string Desc { get; set; }
        public int UserId { get; set; }
        public string ImgPath { get; set; }
        public DateTime Datetime {get; set;}
        
    }
}
