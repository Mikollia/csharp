using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson_6
{
    public class L6Askuser
    {
        public void Asuser() {
            Console.WriteLine( "Enter number a" );
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( "Enter number b" );
            double b = Convert.ToDouble(Console.ReadLine());


            do
            {

                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                a = a - 1;
            } while (a >= b);
               
            Console.ReadLine();
            }
        public void Shownumber()
        { for (int i=0; i < 11; i = i + 2)
            {
                Console.Write(" " + i);
                
            }

        }
    }
    

    }

