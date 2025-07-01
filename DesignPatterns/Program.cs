
using DesignPatterns.Singelton;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SingletonImplemetation(false);

            SingletonWithLockImplementation(true);
        }

        private static void SingletonWithLockImplementation(bool v)
        {
            if (v)
            {

            }
        }

        private static void SingletonImplemetation(bool v)
        {
            if (v)
            {
                Singleton s1 = Singleton.GetInstance();
                Singleton s2 = Singleton.GetInstance();
                
                if (s1 != s2)
                {
                    Console.WriteLine("New Instance Created for Both");
                }
                else
                {
                    Console.WriteLine("Singleton Works");
                }
            }
        }
    }
}
