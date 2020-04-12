using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Aggregator_Service.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Order_Service.Controllers;

namespace Aggregator_Service.Controllers
{
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        private static string userServiceUrl = Environment.GetEnvironmentVariable("USER_SERVICE_URL");
        private static string orderServiceUrl = Environment.GetEnvironmentVariable("ORDER_SERVICE_URL");
        [HttpGet]
        [Route("{controller}/{id}")]
        public async Task<JsonResult> Get(int id)
        {
            if(userServiceUrl == null){
                userServiceUrl = "http://localhost";
            }
            if(orderServiceUrl == null){
                orderServiceUrl = "http://localhost";
            }
            try
            {
                OrderDetails orderDetails = new OrderDetails();

                var getUserTask = client.GetStreamAsync(userServiceUrl + "/user/1");
                UserDetail userDetails =
                        await JsonSerializer
                        .DeserializeAsync<UserDetail>(await getUserTask);


                var getOrdersTask = client.GetStreamAsync(orderServiceUrl + "/orders/1");
                orderDetails =
                       await JsonSerializer
                       .DeserializeAsync<OrderDetails>(await getOrdersTask);

                orderDetails.UserDetails = userDetails;

                return new JsonResult(orderDetails);
            }
            catch (Exception)
            {
                return new JsonResult("{'message':'something went wrong!'}");
            }

        }
    }
}