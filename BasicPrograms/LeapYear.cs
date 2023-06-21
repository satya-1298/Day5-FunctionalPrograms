using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LeapYear
    {
        public  void year()
        {
            Console.WriteLine("Enter a year:");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0) && (y % 400 == 0) && (y != 100))
            {
                Console.WriteLine("It is leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}
