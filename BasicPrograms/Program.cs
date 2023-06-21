using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            int n;
            Console.WriteLine("Choose a option 1-flipcoin 2-LeadYear ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
                {
                    case 1:
                        Console.WriteLine("The Flip coin Program");
                        Flipcoin f = new Flipcoin();
                        f.Display();
                        break;
                    case 2:
                        Console.WriteLine("Lead Year");
                        LeapYear le = new LeapYear();
                        le.year();
                        break;
                    default:
                        Console.WriteLine("Entered Wrong choice");
                        break;
                }
               
            
            Console.ReadLine();
        }
    }
}
