using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_BTVN_2033200113_PhungTanSang
{
    class Program
    {
        static public double tinhPT01(int x)
        {

            return 3 * x + Math.Sqrt(x);
        }

        static public double tinhPT02(int x)
        {
            return Math.Pow(Math.E, x) + 4;
        }

        static public double tinhPT03(int x)
        {
            return Math.Sqrt(Math.Pow(x, 2) + 1);
        }

        static public double tinhPT04(int x)
        {
            return 3*x + 5;
        }

        static public double tinhPT05(int x)
        {
            return Math.Pow(x, 2) + 2 * x - 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("BAI TAP 01 --- BAI TAP VE NHA.");

            
            Console.Write("Nhap gia tri x: ");
            int x = int.Parse(Console.ReadLine());

            // Cau a
            //if (x > 0)
            //{
                //Console.Write("ket qua: {0}", tinhPT01(x));
            //}

            //if (x <= 0)
            //{
                //Console.Write("ket qua: {0}", tinhPT02(x));
            //}

            //cau b
            if (x>=1)
            {
                Console.Write("ket qua: {0:0.00}", tinhPT03(x));
                
            }
            else if(x>-1 && x<1)
            {
                Console.Write("ket qua: {0:0.00}", tinhPT04(x));
            }
            else
            {
                Console.Write("ket qua: {0:0.00}", tinhPT05(x));
            }





            Console.ReadLine();
        }
    }
}
