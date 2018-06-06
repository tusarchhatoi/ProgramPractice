using DatabaseConnectionTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramPractice.Inheritance;


namespace ProgramPractice
{
    class Test: SealedMethod
    {
        static int x;

        Test()
        {
            Console.WriteLine("Program Class Constructure...");
        }

        static void Main(string[] args)
        {
            
            Test t = new Test();
            Console.WriteLine(x);
            Console.ReadLine();
        }

    
    }
}
