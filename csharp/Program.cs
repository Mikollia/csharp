using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
            
            static void Main(string[] args)
            {
            float fl1 = 6.56f;
            char ch1 = 'r';
            int int1 = 45;
            PrimitiveConvertor primitconv = new PrimitiveConvertor();
            primitconv.FloatToChar(fl1);
            primitconv.IntToChar(int1);
            primitconv.CharToInt(ch1);
            Console.ReadLine();
        }
       }
}
