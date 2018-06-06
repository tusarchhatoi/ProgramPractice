using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice.Inheritance
{
     class Parent
    {
        internal Parent()
        {
            Console.WriteLine("Parent Class Constructor...");
        }

        public virtual void  ParentMethod()
        {
            Console.WriteLine("Parent Class ParentMethod...");
        }
    }
}
