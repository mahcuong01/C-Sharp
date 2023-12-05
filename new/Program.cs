using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string c, d;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số a:");
            c = Console.ReadLine();
            c = Convert.ToInt64 (a);
            Console.WriteLine("nhập số b:");
            d = Console.ReadLine();
            d = Convert.ToInt64 (b);
            Console.WriteLine("tổng của a và b là:{0}", a + b);
            Console.ReadKey();
        }
    }
}
