using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson4
{
    class RightTriangle
    {
        public string Tringlecalculation(double a, double b, double c) {
            //Console.WriteLine("Enter first side of triangle = ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter second side of triangle = ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter third side of triangle = ");
            //double c = Convert.ToDouble(Console.ReadLine());
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;
            if ((a2 == (b2 + c2)) || (b2 == (a2 + c2)) || (c2 == (a2+b2))) {
               return "This triangle is right";
               
            }
            else {
                return "This triangle is not right, or not triangle";
                
            }
        }
        

    }
}
