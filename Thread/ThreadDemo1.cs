using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPractice
{
    class ThreadDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Start...");
            Thread t1 = new Thread(Work1);
            Thread t2 = new Thread(Work2);
            t1.Start();
            t2.Start();          
            for(int i = 100;i<=150;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Main Thread End...");
           
           
            Console.ReadLine();
        }
        static void Work1()
        {
            Console.WriteLine("Working-1 Thread Start...");
            for (int i = 200; i <= 250; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Working-1 Thread End...");
        }

        static void Work2()
        {
            Console.WriteLine("Working-2 Thread Start...");
            for (int i = 300; i <= 350; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Working-2 Thread End...");
        }
    }
}
