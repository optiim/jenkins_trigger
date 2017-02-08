using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1(string[] args)
        {

            int r, m1, m2, m3, t;
            float p;
            string n;
            Console.WriteLine("Enter Roll Number :");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name :");
            n = Console.ReadLine();
            Console.WriteLine("Subject1 : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject2 : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject3 : ");
            m3 = Convert.ToInt32(Console.ReadLine());
            t = m1 + m2 + m3;
            p = t / 3.0f;
            Console.WriteLine("Total : " + t);
            Console.WriteLine("Percentage : " + p);
            if (p >= 35 && p < 50)
            {
                Console.WriteLine("Result is C");
            }
            if (p >= 50 && p <= 60)
            {
                Console.WriteLine("Result is B");
            }
            if (p > 60 && p <= 80)
            {
                Console.WriteLine("Result is A");
            }
            if (p > 80 && p <= 100)
            {
                Console.WriteLine("Result is A+");
            }
            Console.ReadLine();
        }
      }
    }
