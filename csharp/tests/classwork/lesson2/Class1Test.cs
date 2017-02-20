using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.tests
{
    
    class Class1Test
    {
        Class1 mathfunc;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            mathfunc = new Class1();
        }

        static object[][] multiplyData = {
        new object[] { 12, 3, 36, true },
        new object[] { 12, 2, 24, true },
        new object[] { 12, 2, 21, false },
        };

        static object[][] divisionData = {
        new object[] { 12, 3, 4 },
        new object[] { 10, 4, 2.5 }
        };

        static object[][] additionData = {
        new object[] { 12, 12, 24 },
        new object[] { -2, 4, 2 }
        };

        static object[][] substractionData = {
        new object[] { 12, 12, 0 },
        new object[] { -2, -4, 2 }
        };
        
        [Test, TestCaseSource("multiplyData")]
        public void Multiply(int a, int b, int expected, bool booleanResult) {
            Assert.AreEqual(booleanResult,expected == mathfunc.Multiply(a,b));
        }

        [Test, TestCaseSource("additionData")]
        public void Multiply2(int a, int b,int expected)
        {
            
            Assert.AreNotEqual(expected, mathfunc.Multiply(a, b));
        }

        [Test, TestCaseSource("additionData")]
        public void Addition1(int a, int b, int expected)
        {
            
            Assert.AreEqual(expected, mathfunc.Addition(a, b));
        }
        [Test, TestCaseSource("substractionData")]
        public void Subtraction(int a, int b, int expected)
        {
           
            Assert.AreEqual(expected, mathfunc.Substraction(a, b));
        }
        [Test, TestCaseSource("divisionData")]
        [Ignore("because I can")]
        public void Division()
        {
            int a = 3;
            int b = 2;
            double expected = 1.5d;
            Class1 mathfunc = new Class1();
            Assert.AreEqual(expected, mathfunc.Division(a, b),0.00001d);
        }
    }
}
