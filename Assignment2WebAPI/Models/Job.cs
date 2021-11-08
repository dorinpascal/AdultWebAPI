using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class Job

    {
        [Key]
        [JsonPropertyName("Id")] public int id { get; set; }
        [JsonPropertyName("JobTitle")] public string JobTitle { get; set; }
        [JsonPropertyName("Salary")] public int Salary { get; set; }
    }
}