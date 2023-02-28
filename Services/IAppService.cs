using BlazorLoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLoginForm.Services
{
    public interface IAppService
    {
        Task<(bool isSuccess, string errorMessage)> RegisterUser(RegistrationModel registerModel);
    }
}
