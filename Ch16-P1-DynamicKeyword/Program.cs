﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            //InvokeMembersOnDynamicData();

            //UsingDynamicClass();

            #region Limitation of a dynamic keyword

            //dynamic a = GetDynamicObject();

            //a.Method(arg => Console.WriteLine(arg));

            //dynamic a = GetDynamicObject();

            //var result = from d in a
            //             select a;

            #endregion

            Console.ReadLine();
        }

        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                // Get metadata for the Minivan type.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Create the Minivan on the fly.
                object obj = Activator.CreateInstance(miniVan);
                // Get info for TurboBoost.
                MethodInfo mi = miniVan.GetMethod("TurboBoost");
                // Invoke method ("null" for no parameters).
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void InvokeMethodWithDynamicKeyword(Assembly asm)
        {
            try
            {
                // Get metadata for the Minivan type.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Create the Minivan on the fly and call method!
                dynamic obj = Activator.CreateInstance(miniVan);
                obj.TurboBoost();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static dynamic GetDynamicObject()
        {
            dynamic d = 1;
            return d;
        }

        private static void UsingDynamicClass()
        {
            VeryDynamicClass dynamicClass = new VeryDynamicClass();

            dynamic number = 1.3;

            dynamicClass.DynamicMethod(number);

        }

        private static void InvokeMembersOnDynamicData()
        {
            //dynamic textData1 = "Hello";
            //Console.WriteLine(textData1.ToUpper());
            //// You would expect compiler errors here!
            //// But they compile just fine.
            //Console.WriteLine(textData1.toupper());
            //Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));

            dynamic textData1 = "Hello";
            try
            {
                Console.WriteLine(textData1.ToUpper());
                Console.WriteLine(textData1.toupper());
                Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
