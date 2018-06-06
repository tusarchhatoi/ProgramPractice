using ProgramPractice.Basic;
using DatabaseConnectionTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice
{
    class Program: AbstractDemo, ParentInterface
    {
        Program()
        {
            Console.WriteLine("Program Class Constructure...");
        }
        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterface Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AbstractMethod();

            AbstractDemo ab = new Program();
            ab.AbstractMethod();

            p.NonAbstractMethod();
            ab.NonAbstractMethod();

            p.ParentInterfaceMethod();
          //  ab.ParentInterfaceMethod();

            Console.ReadLine();
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Inside AbstractMethod Of Abstract Class");
        }
    }
}
