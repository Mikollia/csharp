using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.tests
{
    [TestFixture]
    class Class1Test
    {
        [Test]
        public void Multiply() {
            int a = 2;
            int b = 2;
            int expected = 4;
            Class1 mathfunc = new Class1();
            Assert.AreEqual(expected,mathfunc.Multiply(a,b));
        }

        [Test]
        public void Multiply2()
        {
            int a = 0;
            int b = 3;
            int expected = 1;
            Class1 mathfunc = new Class1();
            Assert.AreNotEqual(expected, mathfunc.Multiply(a, b));
        }

        [Test]
        public void Addition1()
        {
            int a = 2;
            int b = 2;
            int expected = 4;
            Class1 mathfunc = new Class1();
            Assert.AreEqual(expected, mathfunc.Addition(a, b));
        }
        [Test]
        public void Subtraction()
        {
            int a = 3;
            int b = 2;
            int expected = 1;
            Class1 mathfunc = new Class1();
            Assert.AreEqual(expected, mathfunc.Substraction(a, b));
        }
        [Test]
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
