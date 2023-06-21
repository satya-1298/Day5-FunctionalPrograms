using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Harmonic
    {
       
            public  void Series()
            {
                int n;
                Console.WriteLine("Enter a number");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("1/{0} + ", i);
                }
            }
        
    }
}
