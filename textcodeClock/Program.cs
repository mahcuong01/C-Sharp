using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace textcodeClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("nhập số giây cần đếm:");
            n = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (true)
            {
                if (count >= n)
                {
                    Console.WriteLine("\n hết giờ đếm!");
                    break;
                }

                Console.WriteLine("còn {0} giây nữa", n - count);

                Thread.Sleep(1000); // chờ 1 giây
                count++;

            }  
        }    
    }
}
