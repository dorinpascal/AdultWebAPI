using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Person
    {
        [Key] [JsonPropertyName("Id")] public int Id { get; set; }

        [JsonPropertyName("FirstName")]
        [Required]
        [StringLength(1000)]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        [Required]
        [StringLength(1000)]
        public string LastName { get; set; }

        [JsonPropertyName("HairColor")] public string HairColor { get; set; }
        [JsonPropertyName("EyeColor")] public string EyeColor { get; set; }

        [JsonPropertyName("Age")]
        [Range(1, 120, ErrorMessage = "Please enter a value bigger than {1} for Age Field")]
        public int Age { get; set; }

        [JsonPropertyName("Weight")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1} for Weight Field")]
        public float Weight { get; set; }

        [JsonPropertyName("Height")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1} for Height Field")]
        public int Height { get; set; }

        [JsonPropertyName("Sex")] public string Sex { get; set; }
    }
}