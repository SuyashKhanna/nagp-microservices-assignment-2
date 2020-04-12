using System.Collections.Generic;
using System.Text.Json.Serialization;
using Aggregator_Service.Controllers.Models;
using Order_Service.Controllers;

namespace Aggregator_Service.Controllers
{
    public class OrderDetails
    {
        public UserDetail UserDetails { get; set; }
        
        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set;}
    }
}