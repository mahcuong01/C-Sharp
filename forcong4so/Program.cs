using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forcong4so
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a, b, i, x=0;
            Console.WriteLine("nhap 4 so can cho");
            a = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <=4; i++)
            {
                b = a % 10;
                a = a / 10;
                x = x + b;
            }
            Console.WriteLine("tong cua 4 so la:{0}" ,x);*/ //vòng lập đã gán



            int a, b, i, n, x = 0;
            Console.WriteLine("nhap so lan so can cho:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap {0} so vao day:" ,n);
            a  = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            { 
                b = a % 10;
                a = a / 10;
                x = x + b;
            }
            Console.WriteLine("tong cua cac so la:{0}", x);//vòng lập chưa gán
            Console.ReadKey();
        }
    }
}
