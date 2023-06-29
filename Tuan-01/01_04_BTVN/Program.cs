using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_BTVN_2033200113_PhungTanSang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BAI TAP 04 --- BAI TAP VE NHA.");

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Day so trong [{0},{1}]",n,m);
            for (int i = n; i <= m; i++ )
            {
                Console.Write(" {0}",i);
            }

            Console.WriteLine("Day so chan trong day:\n");

            int dem = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" {0}", i);
                    dem = dem + 1;
                }
            }

            Console.WriteLine("\nso luong so chan: {0}",dem);



            Console.ReadLine();
        }
    }
}
