using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singelton
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static int i = 0;
        private Singleton()
        {}

        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
