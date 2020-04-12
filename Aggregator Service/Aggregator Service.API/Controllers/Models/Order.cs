using System;
using System.Text.Json.Serialization;

namespace Order_Service.Controllers
{
    public class Order
    {
        [JsonPropertyName("orderId")]
        public int OrderId { get; set; }

        [JsonPropertyName("orderAmount")]
        public double OrderAmount { get; set; } 

        [JsonPropertyName("orderDate")]
        public DateTime OrderDate { get; set; }

    }
}