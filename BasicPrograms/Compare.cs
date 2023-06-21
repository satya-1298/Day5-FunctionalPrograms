using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Compare
    {
        public void Numbers()
        {


            Console.WriteLine("Enter first number n1 = ");
            int One = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  second number n2 = ");
            int Two = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number n3 = ");
            int Three = int.Parse(Console.ReadLine());
            if (One > Two)
            {
                if (One > Three)
                {
                    Console.WriteLine("largest is first = " + One);
                }
                else
                {
                    Console.WriteLine("largest is Third = "+Three);
                }

            }
            else if (Two>Three)
            {
                Console.WriteLine("largest is Second = "+Two);

            }
            else
            {
                Console.WriteLine("largest is Third = "+Three);
            }

        } 
        
    }
}
