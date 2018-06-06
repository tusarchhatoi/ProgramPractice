using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionTest
{
   public  class DatabaseProgram
    {
        protected internal void DatabaseConnectionTest()
        {
            Console.WriteLine("Not Connected To Any DB...");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Database Connection Test Main method...");
            Console.ReadKey();
        }
    }
}
