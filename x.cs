+using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Syöte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //painavien kiekko = 4, kevyin 1
            var needleOne = new List<int>() { 4, 3, 2, 1 };
            var needleTwo = new List<int>() { };
            var needleThree = new List<int>() { };

            for (int i = 1; i < 16; i++)
            {
                switch (i)
                {
                    case 1:
                        needleTwo.Add(1);
                        needleOne.RemoveAt(3);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 2:
                        needleThree.Add(2);
                        needleOne.RemoveAt(2);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 3:
                        needleThree.Add(1);
                        needleTwo.RemoveAt(0);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 4:
                        needleTwo.Add(3);
                        needleOne.RemoveAt(1);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 5:
                        needleOne.Add(1);
                        needleThree.RemoveAt(1);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 6:
                        needleTwo.Add(2);
                        needleThree.RemoveAt(0);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 7:
                        needleTwo.Add(1);
                        needleOne.RemoveAt(1);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 8:
                        needleThree.Add(4);
                        needleOne.RemoveAt(0);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 9:
                        needleThree.Add(1);
                        needleTwo.RemoveAt(2);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 10:
                        needleOne.Add(2);
                        needleTwo.RemoveAt(1);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 11:
                        needleOne.Add(1);
                        needleThree.RemoveAt(1);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 12:
                        needleThree.Add(3);
                        needleTwo.RemoveAt(0);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 13:
                        needleTwo.Add(1);
                        needleOne.RemoveAt(1);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 14:
                        needleThree.Add(2);
                        needleOne.RemoveAt(0);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    case 15:
                        needleThree.Add(1);
                        needleTwo.RemoveAt(0);
                        Console.WriteLine("1. needle: " + String.Join(", ", needleOne));
                        Console.WriteLine("2. needle: " + String.Join(", ", needleTwo));
                        Console.WriteLine("3. needle: " + String.Join(", ", needleThree) + "\n");
                        continue;
                    _:
                        break;
                }
            }
            Console.WriteLine("Yhteensä 15 siirtoa!");

        }
    }
}