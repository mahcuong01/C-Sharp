using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_eles_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhap so a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so b:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                if (b == 1)
                {
                    Console.WriteLine("a hòa b:=");
                }
                if (b == 2)
                {
                    Console.WriteLine("a thua b:<");
                }
                if (b == 3)
                {
                    Console.WriteLine("a thắng b:>");
                }
                if (a == 2)
                {
                    if (b == 1)
                    {
                        Console.WriteLine("a thắng b>:");
                    }
                    if (b == 2)
                    {
                        Console.WriteLine("a hòa b:=");
                    }
                    if (b == 3)
                    {
                        Console.WriteLine("a thua b:<");
                    }
                   if (a == 3)
                
                    if (b == 1)
                    {
                        Console.WriteLine("a thua b:<");
                    }
                    if (b == 2)
                    {
                        Console.WriteLine("a thắng b:>");
                    }
                    if (b == 3)
                    {
                        Console.WriteLine("a hòa b:=");
                    }
                }   Console.ReadKey();
                    
            }
        }
    }
}
