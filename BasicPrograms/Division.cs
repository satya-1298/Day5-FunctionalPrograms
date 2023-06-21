using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public  class Division
    {
        public void Math(int dividend, int divisor)
        {
            //Console.WriteLine("Enter a number ");
            //dividend=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a Number");
            //divisor=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a Number");
           

            int Quotient = dividend / divisor;
            int Reminder = dividend % divisor;
            Console.WriteLine("The Quotient is " + Quotient);
            Console.WriteLine("The Reminder is " + Reminder);
        }
    }
}
