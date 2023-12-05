using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, c, e;
            string b, d, f;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhap so a:");
            b = Console.ReadLine();
            a = Convert.ToInt32(b);
            Console.WriteLine("nhap so b:");
            d = Console.ReadLine();
            c = Convert.ToInt32(d);
            Console.WriteLine("nhap so c:");
            f = Console.ReadLine();
            e = Convert.ToInt32(f);
            Console.WriteLine("tong cua ca ba so vua nhap la:{0}",a+c+e);
            Console.ReadKey();



            /*int a;
            string A;
            Console.WriteLine("nhap vao mot ki tu");
            Console.Read();
            Console.Write("{0}",a);
            Console.ReadKey();*/


        }
    }
}
