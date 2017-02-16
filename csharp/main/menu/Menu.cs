using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.main.classwork.lesson4;


namespace csharp.main.menu
{
    class Menu
    {
        public void Menu3() {
            Console.WriteLine("This Menu for lesson4. You could cause one of three prorgam ");
            Console.WriteLine("1. What ciclr area is bigger? ");
            Console.WriteLine("2. What number is bigger? ");
            Console.WriteLine("3. Does this triangle right?  ");
            Console.WriteLine(" Please enter the number of menu:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) {
                CircleArea circle = new CircleArea();
                circle.CalculateBigger();
                }
           else if (n == 2) {
                NumberIsBigger number = new NumberIsBigger();
                number.CalculateBigger();
                    }
           else if (n== 3)
            {
                RightTriangle tr = new RightTriangle();
                tr.Tringlecalculation();
            }
            else
            {
                Console.WriteLine("You enter unavalable section.");
                Console.ReadLine();

            }

        }
        

    }
}
