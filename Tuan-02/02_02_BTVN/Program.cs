using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_BTVN_2033200113_PhungTanSang
{
    class Program
    {
        static int[][] nhapMang2C(int[][] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap A[{0}][{1}]: ",i,j);
                    A[i][j] = int.Parse(Console.ReadLine());
                }
            }

            return A;
        }

        static void xuatMang2C(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    Console.Write("\t {0}", A[i][j]);
                }
            }

            Console.WriteLine();
        }

        static void xuatDuongCheoChinh(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i==j)
                    {
                        Console.Write("\t {0}", A[i][j]);
                    }
                }
            }
        }

        static void xuatDuongCheoPhu(int[][] A)
        {
            int n = A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                n = n - 1;

                for (int j = 0; j < A.Length; j++)
                {
                    if (j == n)
                    {
                        Console.Write("\t {0}", A[i][j]);
                    }
                }
            }
        }
        
        static int tinhTongDuongCheoChinh(int[][] A)
        {
            int tong = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i == j)
                    {
                        tong = tong + A[i][j];
                    }
                }
            }

            return tong;

        }

        static int tinhTongDuongCheoPhu(int[][] A)
        {
            int tong = 0;

            int n = A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                n = n - 1;

                for (int j = 0; j < A.Length; j++)
                {
                    if (j == n)
                    {
                        tong = tong + A[i][j];
                    }
                }
            }

            return tong;
        }


        


        static void Main(string[] args)
        {
            Console.Write("BAI TAP 02 --- BAI TAP VE NHA --- BUOI 02\n\n");

            int n;
            int[][] A;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            A = new int[n][];

            for (int i = 0; i < n; i++)
            {
                A[i] = new int[n];
            }

            nhapMang2C(A, n);
            xuatMang2C(A);

            Console.Write("\nXuat duong cheo chinh: ");
            xuatDuongCheoChinh(A);

            Console.Write("\nXuat duong cheo phu: ");
            xuatDuongCheoPhu(A);

            Console.Write("\nTinh tong duong cheo chinh: {0}", tinhTongDuongCheoChinh(A));

            Console.Write("\nTinh tong duong cheo phu: {0}", tinhTongDuongCheoPhu(A));

            Console.ReadLine();
        }
    }
}
