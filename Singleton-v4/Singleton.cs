using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton_v0
{
    public sealed class Singleton
    {
        static int instanceCount = 0;
        int id;

        private static Singleton _instance = null;

        private Singleton()
        {
            id = ++instanceCount;
            Thread.Sleep(10);
            Console.WriteLine("\t*** singleton with id {0} created ***",id);
        }

        static Singleton()
        {
            _instance = new Singleton();
        }

        public static Singleton GetInstance()
        {
            return _instance;
        }
        
        public int GetId() { return id; }


        public static string GetVersion() { return "4.0"; }
    }
}
