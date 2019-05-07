using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_v0
{
    public class Singleton
    {
        static int instanceCount = 0;
        int id;
        public Singleton()
        {
            id = ++instanceCount;
            Console.WriteLine("\t\t*** Singleton with id #{0} created***",id);
        }

        public int GetId() { return id; }


        public static string GetVersion() { return "0.9"; }
    }
}
