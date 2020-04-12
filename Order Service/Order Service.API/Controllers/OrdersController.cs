using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Order_Service.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private static OrderList orderList = new OrderList();

        public OrdersController(){
            //dummy order list object 
            orderList.Orders = new List<Order>();

            orderList.Orders.Add(new Order(1, 10.0, new DateTime(2020,03,30)));
            orderList.Orders.Add(new Order(2, 20.0, new DateTime(2020,03,31)));
        }

        [HttpGet]
        [Route("{controller}/{id}")]
        public JsonResult Get(int id){

            return new JsonResult(orderList);
        }
    }
}