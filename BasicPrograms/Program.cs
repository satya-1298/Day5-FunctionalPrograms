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
            Console.WriteLine("Choose a option 1-flipcoin, 2-LeadYear ,3-PowerOfTwo " +
                "4-Harmonic Number ,5-FactorofNumber, 6-Division");
            int choice = Convert.ToInt32(Console.ReadLine());
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
                    le.Year();
                    break;
                case 3:
                    Console.WriteLine("Power of two Program");
                    Power power = new Power();
                    power.Oftwo();
                    break;
                case 4:
                    Console.WriteLine("Harmonic Series Program");
                    Harmonic h = new Harmonic();
                    h.Series();
                    break;
                case 5:
                    Console.WriteLine("FactorsofNumber Program");
                    Factors factors = new Factors();
                    factors.Ofnumber();
                    break;
                case 6:
                    Console.WriteLine("Division Program");
                    Division division = new Division();
                    division.Math(33, 2);
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }


            Console.ReadLine();
        }
    }
}
