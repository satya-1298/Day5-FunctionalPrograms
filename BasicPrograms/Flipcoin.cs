using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Flipcoin
    {
        public void Display()
        {
            Random r = new Random();
            int flip = r.Next(3);
            Console.WriteLine(flip);    
            if (flip == 0) 
            {
                Console.WriteLine("It's Head");
            }
            else
            {
                Console.WriteLine("It's Tail");
            }

        }
    }
}
