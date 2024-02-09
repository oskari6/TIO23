using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ternary
    {
        static void Main(string[] args)
        {
            //Expression ? true : false

            bool correct = true;

            int pointsEarned = correct ? 10 : 0;

            Console.WriteLine(pointsEarned);

            if(correct)
            {
                pointsEarned = 10;
            }
            else
            {
                pointsEarned = 0;

                string name = "claire";

                if (name == "claire") Console.WriteLine("lame"); //cant do 2 statements
            }
            Console.WriteLine(pointsEarned);
        }
    }
}
