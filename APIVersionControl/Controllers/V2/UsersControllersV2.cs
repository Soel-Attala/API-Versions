using APIVersionControl.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIVersionControl.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}[controller]")]
    [ApiController]
    public class UsersControllersV2 : ControllerBase
    {
        private const string ApiTestURL = "https://dummyapi.io/data/v1/";

        private const string AppID = "64c1fa95be538df4e3395732";

        public readonly HttpClient _httpClient;

        public UsersControllersV2(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [MapToApiVersion("2.0")]
        [HttpGet(Name = "GetUserData")]
        public async Task<IActionResult> GetUserDataAsync()
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("app-id", AppID);

            var response = await _httpClient.GetStreamAsync(ApiTestURL);
            var userData = await JsonSerializer.DeserializeAsync<UserResponseData>(response);

            var users = userData?.data;


            return Ok(users);
        }

    }
}
