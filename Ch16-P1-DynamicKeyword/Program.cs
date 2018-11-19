using System;
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
            dynamic d = "hello";
            Console.WriteLine(d.GetType());
           // d++;

            d = 12;

            d++;
            Console.WriteLine(d.GetType());
            Console.ReadLine();
        }
    }
}
