using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.main.menu;
using csharp.main.classwork.lesson4;
using NUnit.Framework;



namespace csharp.tests.homework.Lesson5
{
    class MenuTestDDU
    {
        Menu menu1;
        CircleArea ciclearea1;
        NumberIsBigger num1;
        RightTriangle triangl1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            menu1 = new Menu();
            ciclearea1 = new CircleArea();
            num1 = new NumberIsBigger();
            triangl1 = new RightTriangle();
        }
        static object[][] cicleAreaData = {
       new object[] { 5, 3, 1 },
       new object[] { 2, 5, 2 },
       new object[] { 12, 2, 2 }
        };

        static object[][] TriangleData = {
        new object[] { 3, 4, 5 , "This triangle is right" ,true },
        new object[] { 2, 5, 2 , "This triangle is not right, or not triangle" , true },
        new object[] { 12, 2, 8 , "This triangle is right" , false}
        };

        [Test, TestCaseSource("cicleAreaData")]
          public void Circle(int a, int b, int expected) {
            // Arrange circleBlahBlah = new ()

            // Act circleBlahBlah.Act(4)

            // Assert 


            Assert.AreEqual(expected, ciclearea1.CalculateBigger(a, b));
            }

        [Test, TestCaseSource("TriangleData")]       
        public void Triangle(double a, double b, double c, string expected, bool booleanResult)
        {
            Assert.AreEqual(booleanResult, expected == triangl1.Tringlecalculation(a,b,c));
        }

        [Test]
        [Ignore("Class Menu is not ready for testing")]
        public void Menutest()
        {
            menu1.Menu3();
        }
    }
}
