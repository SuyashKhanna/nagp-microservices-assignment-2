using System;
namespace Order_Service.Controllers
{
    public class Order
    {
        public int OrderId { get; set; }

        public double OrderAmount { get; set; } 

        public DateTime OrderDate { get; set; }

        public Order(int orderId,double amount, DateTime orderDate){
            this.OrderId = orderId;
            this.OrderAmount = amount;
            this.OrderDate = orderDate;
        }
    }
}