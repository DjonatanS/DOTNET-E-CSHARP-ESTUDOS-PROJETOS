using System;
using TiposEnumerados.Entities;
using TiposEnumerados.Entities.Enums;

namespace TiposEnumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando Class Order
            Order order = new Order {
                Id = 24,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Conversão do OrderStatus para String

            //Converter Enum 
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
