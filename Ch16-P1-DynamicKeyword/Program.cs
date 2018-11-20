﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch16_P1_DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // dynamic d = "hello";
            // Console.WriteLine(d.GetType());
            //// d++;
            // d = 12;
            // d++;
            // Console.WriteLine(d.GetType());

            // ImplicitlyTypedVariable();
            //UseObjectVarible();
            //PrintThreeStrings();
            //ChangeDynamicDataType();
            InvokeMembersOnDynamicData();

            Console.ReadLine();
        }

        private static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";
            Console.WriteLine(textData1.ToUpper());
            // You would expect compiler errors here!
            // But they compile just fine.
            Console.WriteLine(textData1.toupper());
            Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
        }

        private static void ImplicitlyTypedVariable()
        {
            // a is of type List<int>.
            var a = new List<int> { 90 };
            // This would be a compile-time error!
           // a = "Hello";
        }

        static void UseObjectVarible()
        {
            // Assume we have a class named Person.
            object o = new Person() { FirstName = "Mike", LastName = "Larson" };
            // Must cast object as Person to gain access
            // to the Person properties.
            Console.WriteLine("Person's first name is {0}", ((Person)o).FirstName);
        }

        static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "From";
            dynamic s3 = "Minneapolis";
            Console.WriteLine("s1 is of type: {0}", s1.GetType());
            Console.WriteLine("s2 is of type: {0}", s2.GetType());
            Console.WriteLine("s3 is of type: {0}", s3.GetType());
        }
        static void ChangeDynamicDataType()
        {
            // Declare a single dynamic data point
            // named "t".
            dynamic t = "Hello!";
            Console.WriteLine("t is of type: {0}", t.GetType());
            t = false;
            Console.WriteLine("t is of type: {0}", t.GetType());
            t = new List<int>();
            Console.WriteLine("t is of type: {0}", t.GetType());
        }
    }
}
