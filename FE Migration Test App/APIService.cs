using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FE_Migration_Test_App
{
    public class APIService
    {
        private string BaseUrl = "";
        private string LoginUrl = "https://test.salesforce.com";
        private readonly HttpClient _client;

        public APIService(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> Login()
        {
            var query = new Dictionary<string, string>
            {
                ["grant_type"] = "password",
                ["client_id"] = "3MVG973QtA4.tpvmGIsm1S6VuSYX4amnwN0GPBrZx_Gh9vTdJVvJVivSfejHTlR1Hrg4DcHXrYJQqKaVUd13d",
                ["client_secret"] = "A5581EE496691EBA12A57B6930B3717286861075783680E1C38F7B75F6ACFD85",
                ["username"] = "makabir@relisource.com.nmefmazed",
                ["password"] = "Relis0urce"
            };

            var httpResponse = await _client.GetAsync(QueryHelpers.AddQueryString(LoginUrl + "/services/oauth2/token", query));

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve data");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine("response: " + content);
            //var tasks = JsonConvert.DeserializeObject<string>(content);

            return "";
        }

        /*public async Task<Todo> GetTodoAsync(int id)
        {
            var httpResponse = await _client.GetAsync($"{BaseUrl}{id}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var todoItem = JsonConvert.DeserializeObject<Todo>(content);

            return todoItem;
        }

        public async Task<Todo> CreateTodoAsync(Todo task)
        {
            var content = JsonConvert.SerializeObject(task);
            var httpResponse = await _client.PostAsync(BaseUrl, new StringContent(content, Encoding.Default, "application/json"));

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot add a todo task");
            }

            var createdTask = JsonConvert.DeserializeObject<Todo>(await httpResponse.Content.ReadAsStringAsync());
            return createdTask;
        }

        public async Task<Todo> UpdateTodoAsync(Todo task)
        {
            var content = JsonConvert.SerializeObject(task);
            var httpResponse = await _client.PutAsync($"{BaseUrl}{task.Id}", new StringContent(content, Encoding.Default, "application/json"));

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot update todo task");
            }

            var createdTask = JsonConvert.DeserializeObject<Todo>(await httpResponse.Content.ReadAsStringAsync());
            return createdTask;
        }

        public async Task DeleteTodoAsync(int id)
        {
            var httpResponse = await _client.DeleteAsync($"{BaseUrl}{id}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot delete the todo item");
            }
        }*/
    }
}
