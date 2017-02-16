using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson4
{
    public class NumberIsBigger
    {
        public void CalculateBigger() {
            Console.WriteLine("Enter first number = ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number = ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            if (r1 > r2) {
                Console.WriteLine("First number is bigger");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Second number is bigger");
                Console.ReadLine();
            }
        }
    }
}
