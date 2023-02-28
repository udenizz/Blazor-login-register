using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLoginForm.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        public string email { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }

    }
}
