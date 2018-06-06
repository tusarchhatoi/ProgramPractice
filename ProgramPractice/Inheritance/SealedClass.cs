using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice.Inheritance
{
    sealed class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("Sealed Class Constructure");
        }
        public void SealedClassMethod()
        {
            Console.WriteLine("Sealed Class Method");
        }
    }
}
