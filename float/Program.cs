using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @float
{
    internal class Program
    {
        static void Main(string[] args)
        {
             float a, e;
            string c, f;
            Console.WriteLine("nhap so a:");
            c = Console.ReadLine();
            a = float.Parse(c);
            Console.WriteLine("nhap so b:");
            f = Console.ReadLine();
            e = float.Parse(f);
            Console.WriteLine("tong cua a va b la:{0}", a + e);
            Console.ReadKey();
        }
    }
}
