using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ClassAndObj
    {
        int num1 = 40;
        int num2 = 20;

        //Method or Behaviour

        public void Add()
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        public void Sub()
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        public void priya()
        {
            ClassAndObj obj = new ClassAndObj();
            obj.num1 = 20;
            obj.num2 = 10;
            obj.Sub();
        }

    }
}
