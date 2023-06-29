using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_BTVN_2033200113_PhungTanSang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BAI TAP 02 --- BAI TAP VE NHA.");

            int dem = 0;

            for (int i = 0; i <= 100;i++ )
            {
                for(int j=1;j<10;j++)
                {

                    if (i/j==11 && i%j==0)
                    {
                        Console.Write(" {0}", i);
                    }

                }

                
            }




                Console.ReadLine();


        }
    }
}
