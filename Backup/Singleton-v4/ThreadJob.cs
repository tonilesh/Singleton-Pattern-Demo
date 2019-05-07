using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Singleton_v0;

namespace Singleton_v1
{
    public class ThreadJob
    {
        public void Run()
        {
            Singleton s = Singleton.GetInstance();
            Console.WriteLine("using singleton #" + s.GetId());
        }
    }
}
