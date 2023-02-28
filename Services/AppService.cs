using BlazorLoginForm.Models;
using Newtonsoft.Json;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace BlazorLoginForm.Services
{

    public class AppService : IAppService
    {

        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        private string _baseUrl = "http://10.0.2.2";

        public async Task<(bool isSuccess, string errorMessage)> RegisterUser(RegistrationModel registerModel)
        {
            string errorMessage = string.Empty;
            bool isSuccess = false;
            using (var client = new HttpClient()) {

                var url = $"{_baseUrl}{APIs.RegisterUser}";

                var serialzedStr = JsonConvert.SerializeObject(registerModel);

                var response = await client.PostAsync(url, new StringContent(serialzedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode) {

                    isSuccess = true;
                }
                else
                {
                    errorMessage = await response.Content.ReadAsStringAsync();
                }
            }
            return (isSuccess, errorMessage);
        }

        HttpClient _client2;
        public List<RegisteredModels> Items { get; set; }

        public AppService()
        {
            _client2 = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }


    }

}
