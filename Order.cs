using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Shipping
{

   public class Order
    {
        //Properties
        int ProductID;
        string ProductName;
        int MRPRate;
        float Discount;
        float Gst=13.2f;
        int Total;
        float AfterDiscount;
        int Count;
        float FinalTotal;
        //Methods
        public void AddOrder()
        {

            Console.WriteLine("Enter ProductID : ");
            ProductID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ProductName");
            ProductName = Console.ReadLine();

            Console.WriteLine("Enter MRPRate : ");
            MRPRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Discount: ");
            Discount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many products do you want to Buy: ");
            Count = Convert.ToInt32(Console.ReadLine());
            Total = MRPRate * Count;
            AfterDiscount = Total - (Total * Discount / 100);
            FinalTotal = (AfterDiscount * Gst) / 100;


            Console.WriteLine($"You have to pay amount is: {FinalTotal} ");
            Console.WriteLine("------------------");

            Console.WriteLine("Thank You For Shopping with US!");

        }
        public void DisplayOrderDetails()

        {
            Total = MRPRate * Count;
            Console.WriteLine($"{Total} {AfterDiscount}{FinalTotal}");
            
        }


    }
}

        
    