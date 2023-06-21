using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Even
    {
        public  void Odd()
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int r = n % 2;
            if (r == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
        }
    }
}
