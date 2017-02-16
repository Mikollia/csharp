using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson4
{
    class RightTriangle
    {
        public void Tringlecalculation() {
            Console.WriteLine("Enter first side of triangle = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side of triangle = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side of triangle = ");
            double c = Convert.ToDouble(Console.ReadLine());
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;
            if ((a2 == (b2 + c2)) || (b2 == (a2 + c2)) || (c2 == (a2+b2))) {
                Console.WriteLine("This triangle is right");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("This triangle is not right, or not triangle");
                Console.ReadLine();
            }
        }
        

    }
}
