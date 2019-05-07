using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Singleton_v1;

namespace Singleton_v0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            Console.WriteLine("Singleton Version is "+Singleton.GetVersion());
            Console.ReadLine();
            Console.WriteLine("Now using Singleton...");
            for (int i = 0; i < 5; i++)
            {
                ThreadJob job=new ThreadJob();
                Thread t = new Thread(job.Run);
                t.Start();                
            }

            Console.WriteLine("Waiting before second batch...");
            Thread.Sleep(10000);
            Console.WriteLine("working on phase 2");

            for (int i = 0; i < 5; i++)
            {
                ThreadJob job = new ThreadJob();
                Thread t = new Thread(job.Run);
                t.Start();
            }
        }
    }
}
