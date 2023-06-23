using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public interface IBank
    {
        public void NameOfBank();
        public void Operation();

    }

    public interface Society
    {
        public void Operation();
    }

    public class PunjabBank : IBank, Society
    {
        void IBank.Operation()
        {
            Console.WriteLine("Operation Of Bank");

        }
        void Society.Operation()
        {
            Console.WriteLine("Operation Of Society");
        }

        public void NameOfBank()
        {
            Console.WriteLine("Override the Name of Bank");
        }

    }
    
}
