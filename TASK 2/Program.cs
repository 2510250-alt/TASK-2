
using System;
using System.Collections.Generic;

namespace TASK_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            List<Discount> discounts = new List<Discount>
            {
                new StudentDiscount(),
                new SeasonalDiscount(),
                new PremiumMemberDiscount()
            };

            foreach (Discount discount in discounts)
            {
                double amount = discount.CalculateDiscount(price);
                double finalPrice = price - amount;

                Console.WriteLine("\nDiscount: " + discount.GetType().Name);
                Console.WriteLine("Discount Amount: " + amount);
                Console.WriteLine("Final Price: " + finalPrice);
            }
        }
    }
}
