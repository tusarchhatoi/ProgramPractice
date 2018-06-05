using ProgramPractice.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice
{
    class Program:Parent,ParentInterface
    {
        Program()
        {
            Console.WriteLine("Program Class Constructure...");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ParentInterfaceMethod();
            Console.ReadLine();
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterface Method");
        }
    }
}
