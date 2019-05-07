using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_v0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            Console.WriteLine("Singleton Version is "+Singleton.GetVersion());

            Console.WriteLine("Now using Singleton...");
            for (int i = 0; i < 10; i++)
            {
                Singleton s = new Singleton();
                Console.WriteLine("using singleton #"+s.GetId());
            }
        }
    }
}
