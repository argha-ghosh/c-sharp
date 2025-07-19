using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApphome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This is 1D array
            int[,] grades = new int[5, 6];
            grades[0, 2] = 5;
            Console.WriteLine("So the output for this 1d array is: " + grades[0, 2]);
            Console.WriteLine("So the length of the output array is: " + grades.GetLength(0));

            Console.WriteLine("______________________________________________________");
            //Console.WriteLine();

            // Initialize 2D array
            int[,] roll =
            {
                {1, 2 ,3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            Console.WriteLine("So the output for this 2D array is: " + roll[1, 2]);
            Console.WriteLine(roll.GetLength(0));
            Console.WriteLine(roll.GetLength(1));
            Console.WriteLine("Given 2D array: ");

            for (int j = 0; j < roll.GetLength(0); j++)
            {
                for (int l = 0; l < roll.GetLength(1); l++)
                {

                    Console.Write(roll[j, l] + " ");

                }
                Console.WriteLine();

            }

            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();

            //Jaccked array
            int[][] classID =
            {
               new int[4] { 800, 900, 700, 600 },
               new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 },
               new int[2] { 50, 70 },
               new int[3] { 1, 2, 3 }
            };

            int[] array = {10, 20, 30, 40 };
            Console.WriteLine("Output for this jaccked array is: " + classID[2][0]);
            Console.WriteLine("Length of array: " + classID.Length);
            Console.WriteLine("Length of index: " + classID[3].Length);
            Console.WriteLine(classID[2][1] + classID[1][2]);
            Console.WriteLine(classID[2][1] - classID[1][2]);
            Console.WriteLine(classID[2][1] + array[3]);
            Console.WriteLine(classID[2][1] - array[3]);
            Console.WriteLine("Given jaccked array: ");

            for (int i = 0; i < classID.Length; i++)
            {
                for (int k = 0; k < classID[i].Length; k++)
                {

                    Console.Write(classID[i][k] + " ");

                }
                Console.WriteLine();

            }

        }

    }

}

