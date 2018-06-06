using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice.Inheritance
{
    abstract class AbstractDemo
    {
        public AbstractDemo()
        {
            Console.WriteLine("AbstractDemo Class Constructure...");
        }
        public void NonAbstractMethod()
        {
            Console.WriteLine("Inside NonAbstractMethod Of Abstract Class");
        }
        public  abstract void AbstractMethod();
       
    }
}
