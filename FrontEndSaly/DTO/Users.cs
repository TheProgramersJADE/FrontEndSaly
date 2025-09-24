using System.Text.Json.Serialization;

namespace FrontEndSaly.DTO
{
    public class Users
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("role_id")]
        public int Role_Id { get; set;}
    }
}
