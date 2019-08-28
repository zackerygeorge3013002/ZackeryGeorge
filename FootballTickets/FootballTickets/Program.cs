using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //var declaration
            int quan;
            string item;
            double price, subtotal;
            const double tax = .085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            item = Console.ReadLine();
            
            Console.WriteLine("How many "+item+"'s do you want to buy?");
            quan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price for each " + item + "?");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("\t Your subtotal for your bill is " + (price * quan).ToString("C2"));
            Console.WriteLine("\t Your sales tax for your bill is " + (tax * (price * quan)).ToString("C2"));
            Console.WriteLine("\t Your total for your bill is " + ((tax * (price * quan)) + (price * quan)).ToString("C2"));

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();


        }
    }
}
