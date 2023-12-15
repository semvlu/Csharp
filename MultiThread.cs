using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace multithread
{
    internal class Program
    {
        public static void func1()
        {
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine("Func1: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void func2()
        {
            for (int i = 10; i >=0; i--)
            {
                Console.WriteLine("Func2: {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;
            main.Name = "MAIN";
            Thread t1 = new Thread(() => { func1(); });
            Thread t2 = new Thread(func2);
            t1.Start();
            Console.WriteLine(t1.IsAlive);
            t2.Start();
            Console.WriteLine(t1.IsAlive);
            Console.ReadLine();
        }
    }
}
