using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch16_P1_DynamicKeyword
{
    class VeryDynamicClass
    {
        // A dynamic field.
        private static dynamic myDynamicField;
        // A dynamic property.
        public dynamic DynamicProperty { get; set; }
        // A dynamic return type and a dynamic parameter type.
        public dynamic DynamicMethod(dynamic dynamicParam)
        {
            Console.WriteLine(" Dynamic Method Invoked ");
            // A dynamic local variable.
            dynamic dynamicLocalVar = "Local variable";
            int myInt = 10;
            if (dynamicParam is int)
            {
                Console.WriteLine(" Parameters is an integer ");
                return dynamicLocalVar;
            }
            else
            {
                Console.WriteLine(" not an integer ");
                return myInt;
            }
        }
    }
}
