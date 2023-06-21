using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public  class Swap
    {
        public void TwoNumbers(int a,int b)
        {
            //Console.WriteLine("Enter a number ");
            //a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a Number");
            //b=Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("value before swaping a = " + a + " b = " + b);
            int n = a * b;
            a = n / a;
            b = n / b;

            Console.WriteLine("value after swaping a = " + a + " b = " + b);
        

        }
    }
}
