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
            int age = int.Parse(Console.ReadLine()); //input
            int ageB;
            int.TryParse(Console.ReadLine(), out ageB); //jos kirjaimia seassa ja tulostaa jos tarvitsee. käyttäjä virhe ja tulostaa peruselementin.
            int ikä = int.Parse(age);
            Console.Write("Anna ikäsi: ");
            string age = Console.ReadLine();
            Console.WriteLine("Olet " + age + " vuotta vanha");
            Console.WriteLine("Olet {0} vuotta vanha", age); //elegant
            Console.WriteLine($"olet {age} vuotta vanha "); //tietoturvan kanssa voi olla tekemistä stringien luomisen kanssa

        }
    }
}