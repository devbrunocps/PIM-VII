using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StreamingPlatformClient.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserLoginResponse> Login(UserLogin userLogin)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5000/api/auth/login", userLogin);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<UserLoginResponse>();
        }

        public async Task<UserRegisterResponse> Register(UserRegister userRegister)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5000/api/auth/register", userRegister);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<UserRegisterResponse>();
        }
    }

    public class UserLoginResponse
    {
        public string Token { get; set; }
    }

    public class UserRegisterResponse
    {
        // Adicione propriedades conforme necessário
    }
}

