using csharp.main.classwork.lesson4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.main.menu;
using csharp.main.classwork.lesson_6;

namespace csharp
{
    class Program
    {
            
            static void Main(string[] args)
            {
            L6Askuser user = new L6Askuser();
            user.Shownumber();
            Console.ReadLine();
            int a = 1;
            Console.WriteLine("Original a =" + a);
            Console.WriteLine("Post-increment  a =" + a++);
            Console.WriteLine("after post-increment  a =" + a);
            Console.WriteLine("Pre-increment  a =" + ++a);
            Console.WriteLine("after pre-increment  a =" + a);
            Console.ReadLine();
        }
        
       }
}
