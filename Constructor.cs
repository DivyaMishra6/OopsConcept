using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Constructor
    {
        //Non Parameterised

        int num1;
        int num2;
        double result;
        public Constructor()
        {
            num1 = 10;
            num2 = 20;
            result = num1 + num2;
            Console.WriteLine("Addition " + result);
        }

        public Constructor(int a, long b)
        {
            Console.WriteLine("num1 = " + a);
            Console.WriteLine("num2 = " + b);
            result = a + b;
            Console.WriteLine("Addition " + result);
        }

        public Constructor(long x, long y, int z)
        {
            Console.WriteLine("num1 = " +x);
            Console.WriteLine("num1 = " + y);
            Console.WriteLine("num2 = " + z);
            result = x + y + z;
            Console.WriteLine("Addition " + result);

        }



    }
}
