using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class PrimitiveConvertor
    {
        
        public char FloatToChar (float fl1)
        {
            //char ch2 = 'a';
            //ch2 = (char) fl1;
            Console.WriteLine( "Input float value is" + fl1
            + " Output char value is " + (char) fl1);
            return (char) fl1;
        }
        public char IntToChar(int int1)
        {
            Console.WriteLine("Input Int value is " + int1
            + " Output char value is " + (char) int1);
            return (char) int1;
        }
        public int CharToInt(char ch1)
        {
            Console.WriteLine( " Input char value is " + ch1
            + " Output Int value is " + (int) ch1);
            return (int) ch1;
        }
    }
}
