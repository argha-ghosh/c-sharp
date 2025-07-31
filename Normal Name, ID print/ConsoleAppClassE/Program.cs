using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassE
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressFormat a1 = new AddressFormat(12, 27, 1889, "Khulna");
            //AddressFormat a2 = new AddressFormat(42, 198, 1110, "Bogura");

            Student s1 = new Student();
            s1.SetId(100); //s1.id = 100;
            s1.SetName("Bruce"); //s1.name = "bruce";
            s1.SetCgpa(3.12); //s1.cgpa = 3.12;
            s1.SetBloodGroup("B+"); // s1.bloodGroup = "B+";
            s1.SetAddress(new AddressFormat(12, 27, 1889, "Khulna"));
            s1.PrintStudentInfo();

            Student s2 = new Student(200, "clerk", 2.28, "AB+", new AddressFormat(42, 198, 1110, "Bogura"));
            s2.PrintStudentInfo();

            //constant pointer, [0]
            //1d, Multi D, jagged array

            int[] ax = new int[5] { 12, 98, -67, 100, 4 };

            //for (int q = 0; q < ax.Length; q++)
            //{
            //    Console.Write("{0} ", ax[q]);
            //}
            //Console.WriteLine();

            //int k = 0;
            //while (k < ax.Length)
            //{
            //    Console.Write("{0} ", ax[k]);
            //    k++;
            //}

            //k = 0;
            //do
            //{
            //    Console.Write("{0} ", ax[k]);
            //    k++;
            //}
            //while (k < 5);

            //foreach (int e in ax)
            //{
            //    Console.Write("{0} ", e);
            //}

            int[,] bx = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            //int r = 0, c;
            //while(r < 4)
            //{
            //    c = 0;
            //    while(c<3)
            //    {
            //        Console.Write("{0} ", bx[r, c]);
            //        c++;
            //    }
            //    Console.WriteLine();
            //    r++;
            //}

            //int[,,,] cx = new int[3, 2, 4, 8];

            //foreach (int e in bx)
            //{
            //    Console.Write("{0} ", e);
            //}
            //Console.WriteLine();

            //int[][] jx = new int[4][];
            //jx[0] = new int[3] { 1, 2, 3 };
            //jx[1] = new int[2] { 4, 5 };
            //jx[2] = new int[5] { 6, 7, 8, 9, 10 };
            //jx[3] = new int[1] { 11 };
            //int r = 0, c;
            //while (r < jx.Length)
            //{
            //    c = 0;
            //    while (c < jx[r].Length)
            //    {
            //        Console.Write("{0} ", jx[r][c]);
            //        c++;
            //    }
            //    Console.WriteLine();
            //    r++;
            //}
        }
    }
}
