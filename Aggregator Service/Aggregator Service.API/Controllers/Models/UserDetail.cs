using System.Text.Json.Serialization;

namespace Aggregator_Service.Controllers.Models
{
    public class UserDetail
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}