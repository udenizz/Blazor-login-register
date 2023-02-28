using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace BlazorLoginForm.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Lütfen isminizi giriniz")]
        public string fname { get; set; }
        [Required(ErrorMessage = "Lütfen soyisminizi giriniz")]
        public string lname { get; set; }
        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        public string email { get; set; }
        [Required(ErrorMessage = "Lütfen şifresinizi giriniz")]
        public string password { get; set; }
        [Required]
        public string number{ get; set; }
    }
}
