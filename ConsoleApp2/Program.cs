using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary3;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl1 = new Class1();
            Class2 cl2 = new Class2();
            Console.WriteLine("Hello World!!!!!!");
            Console.WriteLine(cl1.Method1());
            Console.WriteLine(cl2.method2());
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }
    }
}
