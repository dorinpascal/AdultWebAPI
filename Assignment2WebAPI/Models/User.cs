using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        [Key] [JsonPropertyName("id")] public int id { get; set; }
        [JsonPropertyName("UserName")] public string UserName { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
        [JsonPropertyName("Level")] public string Level { get; set; }
    }
}