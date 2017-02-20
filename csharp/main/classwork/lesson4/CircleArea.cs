using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson4
{
    public class CircleArea
    {
        public const double PI = 3.14159d;
       public int CalculateBigger(int r1, int r2) {
            //Console.WriteLine("Enter Radiuos1 = ");
        //double r1 = Convert.ToDouble(Console.ReadLine());
           //// Console.WriteLine("Enter Radious2 = ");
            //double r2 = Convert.ToDouble(Console.ReadLine());
            double area1 = PI * r1 * r1;
            double area2 = PI * r2 * r2;
            if (area1 > area2) {
                return 1;
            }
            else {
               return 2;
            }
      }
    }
}
