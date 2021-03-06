﻿using csharp.Properties;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp.tests.classwork.lesson5
{
     [TestFixture]

        class TestCaseWithPreconditions
        {

            private string INPUT_DATA = Resources.PathToRecources + "input.txt" ;

            private string EXPECTED_RESULTS = Resources.PathToRecources + "expected.txt";

            private static int[] inputData = null;

            private static int[] expectedResults = null;

            [OneTimeSetUp] // input data the same for all tests

            public void OneTimeSetUp()
            {

                expectedResults = ReadRowOfIntegers(EXPECTED_RESULTS);
            }

            [SetUp]

            public void SetUp()
            {

                inputData = ReadRowOfIntegers(INPUT_DATA);
            }

            [Test]

            public void FirstTest()
            {

                Console.WriteLine("Simple sorting test");

                Array.Sort(inputData);

                Assert.AreEqual(expectedResults, inputData);
            }

            [Test, Timeout(1000)]

            public void InfinityTest()
            {

                while (true) ;
            }

            [Test, Timeout(1000)]

            [Ignore("This test is not ready yet")]

            public void ThisTestIsNotReadyYet() { }

            [TearDown]

            public void TearDown()
            {

                inputData = null;
            }

            [OneTimeTearDown]

            public void OneTimeTearDown()
            {

                expectedResults = null;
            }

            public static int[] ReadRowOfIntegers(string fileName)
            {

                int counter = 0;

                int[] intArray;

                string[] stringArray = new string[100];

                string line;

                // Read the file and display it line by line.

                System.IO.StreamReader file = new System.IO.StreamReader(fileName);

                while ((line = file.ReadLine()) != null)
                {

                    stringArray[counter] = line;

                    counter++;
                }

                file.Close();

                // Suspend the screen.

                string[] splittedString = stringArray[0].Split(',');

                intArray = new int[splittedString.Length];

                for (int i = 0; i < splittedString.Length; i++)
                {

                    intArray[i] = Convert.ToInt32(splittedString[i]);
                }

                return intArray;

            }

        }
    }

