using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OOP01
    { 

        static void Main(string[] args)
        {

            Console.WriteLine("s = (100000*a+10000*b+1000*c+100*d+10*e+f)，0<=a,b,c,d,e,f<=9");
            Console.WriteLine("請輸入一個整數n:");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int sum = 0;
            Console.WriteLine("符合的數字:");
            for (int i = 1; i < n; i++)
            {
                int _1 = i % 100;
                int _2 = i % 10000 - _1;
                int _3 = (i - _1 - _2);
                _2 /= 100;
                _3 /= 10000;
                if (Math.Pow(_3, 3) + Math.Pow(_2, 3) + Math.Pow(_1, 3) == i)
                {
                    Console.WriteLine("{0}", i);
                    sum += i;
                }

            }
            Console.WriteLine("Sum: {0}", sum);

            Console.WriteLine("輸入k");
            string kin = Console.ReadLine();
            int k = int.Parse(kin);
            int cnt = 0;
            Console.WriteLine("前k個符合的數字:");
            for (int i = 1; i < n; i++)
            {
                int _1 = i % 100;
                int _2 = i % 10000 - _1;
                int _3 = (i - _1 - _2);
                _2 /= 100;
                _3 /= 10000;
                if (Math.Pow(_3, 3) + Math.Pow(_2, 3) + Math.Pow(_1, 3) == i)
                {
                    if (cnt == k)
                        break;
                    else
                    {
                        Console.WriteLine("{0}", i);
                        cnt++;
                    }

                }

            }
            Console.Read();
        }



    }
}
