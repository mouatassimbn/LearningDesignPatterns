
using System;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Proxy Pattern Demo.***");
            //Demo1();
            Demo2();
        }

        static void Demo1()
        {
            Subject proxy = new Proxy();
            proxy.DoSomeWork();
        }

        static void Demo2()
        {
            // Authorized user Admin
            Subject proxy = new ProtectionProxy("Admin");
            proxy.DoSomeWork();

            // Authorized user Yoshi
            proxy = new ProtectionProxy("Yoshi");
            proxy.DoSomeWork();

            // Unauthorized user Test
            proxy = new ProtectionProxy("Test");
            proxy.DoSomeWork();
        }
    }
}
