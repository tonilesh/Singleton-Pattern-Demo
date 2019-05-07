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
        static object _lock = new object();
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {

                    Thread.Sleep(1000);
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }

            return _instance;
        }
        
        public int GetId() { return id; }


        public static string GetVersion() { return "3.0"; }
    }
}
