using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singelton
{
    public class SingletonWithLock
    {
        private static SingletonWithLock instance = null;

        private static readonly object _lock = new object();
        public SingletonWithLock() { }

        public static SingletonWithLock Instance
        {
            get
            { 
                lock(_lock)
                {
                    if(instance == null)
                    {
                        instance = new SingletonWithLock();
                    }
                    return instance;
                }
            }
        }
    }
}
