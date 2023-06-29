using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01_BTVN_2033200113_PhungTanSang
{
    class Program
    {
        static int[] nhapMang1C(int[] A, int n)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Nhap A[{0}]: ", i);
                A[i] = int.Parse(Console.ReadLine());
            }

            return A;
        }

        static void xuatMang1C(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("\t {0}", A[i]);
            }

            Console.WriteLine();
        }

        static int tinhTongPTCD(int[] A)
        {
            int tong = 0;

            for (int i = 1; i < A.Length-1; i++)
            {
                if (A[i] > A[i-1])
                {
                    if (A[i] > A[i+1])
                    {
                        Console.Write("{0} ",A[i]);
                        tong = tong + A[i];
                    }
                }
            }

            return tong;

        }


        static void Main(string[] args)
        {
            int n;
            int[] A;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            A = new int[n];

            nhapMang1C(A,n);

            Console.Write("\nXuat mang vua nhap: ");
            xuatMang1C(A);

            Console.Write("\n\nTinh tong pt cuc dai: {0}", tinhTongPTCD(A));
            //tinhTongPTCD(A);

            Console.ReadLine();
        }
    }
}
