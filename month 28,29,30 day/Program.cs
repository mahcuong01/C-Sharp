using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace month_28_29_30_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int month, year;
            string thang, nam;
            Console.WriteLine("nhập tháng:");
            thang = Console.ReadLine();
            month = Convert.ToInt32(thang);
            Console.WriteLine("nhập năm:");
            nam = Console.ReadLine();
            year = Convert.ToInt32(nam);
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine("tháng có 31 ngày"); break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("tháng có 31 ngày"); break;
                case 2:
                    if ((year % 4) == 0)
                        Console.WriteLine("tháng có 29 ngày");
                    else
                        Console.WriteLine("tháng có 28 ngày");
                        Console.ReadKey();
                    break;

            }


        }
    }
}
