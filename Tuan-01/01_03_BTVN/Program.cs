using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_BTVN_2033200113_PhungTanSang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BAI TAP 03 ---  BAI TAP VE NHA");

            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i%2!=0)
                {
                    Console.Write(" {0}",i);
                }
            }

                Console.ReadLine();
        }
    }
}
