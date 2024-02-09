using System;
using System.Collections.Generic; // this is manditory
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lists
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200};
            List<int> grades2 = new List<int>() { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200 };

            if(grades.SequenceEqual(grades2)) //compare list items
            {
                Console.WriteLine("equals!");
            }

            for ( int i = 0; i < grades.Count; i++ ) //iterate through list
            {
                grades[i] *= 2;
                Console.WriteLine(grades[1]);
            }

            foreach(int grade in grades)
            {
                Console.WriteLine(grade);
            }
            
            //grades.Add(5);
            //grades.Add(10);

            //methods
            grades.Add(30);
            grades.Insert(2, 15);//shifts everything over
            grades.Clear();
            grades = new List<int>(); //same result
            grades.Remove(10);
            grades.RemoveAt(1);
            if(grades.Contains(80))
            {
                Console.WriteLine("found");
            }
            if(grades.IndexOf(23) == -1)
            {
                Console.WriteLine("true");
            }
            if (grades.LastIndexOf(26) == 9)
            {
                Console.WriteLine("true");
            }


            Console.WriteLine(grades[0]);

            //nested foreach loops
            List<List<int>> studentGrades = new List<List<int>>()
                {
                new List<int> { 5,10,26},
                new List<int> { 34,26,26 },
                new List<int> { 26, 2, 23,26,200 } };

            foreach(List<int> grades1 in studentGrades.ToArray())
            {
                foreach (int grade in grades1)
                {
                    Console.WriteLine(grade + "\t");
                }
                Console.WriteLine();
            }

            //same with jagged
            int[][] studentGrades1 = 
                {
                new int[] { 5,10,26},
                new int[] { 34,26,26 },
                new int[] { 26, 2, 23,26,200 } 
            };

            foreach (int[] grades1 in studentGrades1)
            {
                foreach (int grade in grades1)
                {
                    Console.WriteLine(grade + "\t");
                }
                Console.WriteLine();
                //for each works for lists and jagged arrays, 2d arrays have to be done with for loops nested
            }

            //list conversion / array conversion
            List<int> stuff = new List<int>() { 5, 60 ,3, 50};

            int[] myArr = stuff.ToArray();

            List<int> myList = studentGrades1[0].ToList();

            //reverse and sort list
            stuff.Sort();
            stuff.Reverse();

            foreach(int s in stuff)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();         
        }
    }
}
