using System;
namespace Shipping
{
    class Program
    {
        //entry point of application
        public static void Main()
        {
            Order pro = new Order();
            pro.AddOrder();
            pro.DisplayOrderDetails();
            Console.ReadKey();
        }
    }
}