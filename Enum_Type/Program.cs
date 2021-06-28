using System;
using Enum_Type.Entities;
using Enum_Type.Entities.Enums;

namespace Enum_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            Console.WriteLine(order);
            
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}