using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class arrays
    {
        static void Main(string[] args)
        {
            /*int[] grades = new int[10];
            grades[0] = 900;
            grades[1] = 1000;

            int[] grades = { 900, 20, 12, 41 };
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] grades = new int[size];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write(grades[i] + " ");
                Console.ReadLine();
            }
            Console.WriteLine(grades[4]);
            Console.ReadLine();*/

            int[] grades = { 30, 430, 23, 10 };
            int[] grades2 = {30, 430 ,23, 10 };
            int[,] grades2d = new int[3, 4]/*{{5,4,7,3},{7,3,2,6},{5,3,7,3}}*/;
            grades2d[0, 2] = 5;

            int[][] jagged = {
                new int[]{5,4,7,3},
                new int[]{7,3,2,6,7,4,2,4},
                new int[]{5,3,7,3}
            };
            Console.WriteLine(jagged[1][6]);
            Console.WriteLine(grades2d[0,2]);
            Console.WriteLine(jagged.Length);
            Console.WriteLine(jagged[0].Length);
            Console.ReadLine();

            Console.WriteLine(jagged.GetLength(0));
            Console.WriteLine(jagged.GetLength(1));

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int k = 0; k < jagged[i].Length; k++)
                {
                    Console.Write(jagged[i][k] + " ");
                    Console.Read();
                }
                Console.WriteLine();
                Console.ReadLine();
            }

            //2
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int k = 0; k < jagged.GetLength(0); k++)
                {
                    Console.Write(jagged[i][k] + " ");
                    Console.Read();
                }
                Console.WriteLine();
                Console.ReadLine();
            }

            //Console.WriteLine(Array.IndexOf(grades,23));
            //Console.ReadLine();
            //Array.Sort(grades);
            //Array.IndexOf(grades,23)
            //Array.Reverse(grades);
            //Enumerable.SequenceEqual(grades, grades2)) inside if statement, comparing
            //above you are imparing if they are the same entity not value
            //for value: in[] grades = grades2; inside if statement
            bool found = false;

            for(int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == 40)
                {
                    Console.WriteLine("we found it");
                    Console.ReadLine();
                    found = true;
                    break;
                }
                if(!found)
                {
                    Console.WriteLine("not found");
                    Console.ReadLine();
                }
            }
        }
    }
}
