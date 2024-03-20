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
            //5. Kirjoita ohjelma, jossa kahden merkkijono (string) muuttujan arvot vaihdetaan keskenään.

            Console.Write("Anna 2 merkkinen teksti: ");
            string textOne = Console.ReadLine();
            Console.Write("Anna toinen 2 merkkinen teksti: ");
            string textTwo = Console.ReadLine();

            string newTextOne = textTwo;
            string newTextTwo = textOne;

            //voidaan myös käyttää kolmea muuttujaa ja korvata toisensa

            Console.Write($"1. teksti on {newTextOne}\n ja 2. teksti on {newTextTwo}");

            //new string
            string[] myArray = new string[5];
            Console.WriteLine(myArray);
            Console.ReadLine();
        }
    }
}