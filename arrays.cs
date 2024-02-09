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
        enum Months
        {
            Spring = 1,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
            /*Tehtävä 2.
            Kirjoita ohjelma, jossa määrittelet kaksi kolmipaikkaista taulukkoa.
            Alusta toinen tuotteiden nimillä ja toinen niiden hinnoilla.
            Tulosta tämän jälkeen jokaisen tuotteen nimi ja hinta yhdessä omalle riville.
            (Huom! ihan tavallisia 1 - ulotteisia taulukoita tarvitaan tässä)*/

            string[] names = { "pöytä", "tuoli", "lamppu" };
            int[] prices = { 10, 20, 15 };

            Console.WriteLine(names[0] + " hinta, " + prices[0]);
            Console.WriteLine(names[1] + " hinta, " + prices[1]);
            Console.WriteLine(names[2] + " hinta, " + prices[2]);

            /*Tehtävä 3.
            Tee ohjelma joka kysyy käyttäjältä viisi nimeä ja tallentaa ne string tyyppiseen taulukkoon.
            Lopuksi tulosta nimet taulukosta. (ei tarvitse tehdä toistorakenteella, peräkkäiset ReadLine-, WriteLine - komennot ratkaisuna ok)*/

            Console.Write("Anna 5 nimeä erotettuna välilyönnillä: ");
            string input = Console.ReadLine();
            string[] names = input.Split(' ');
            string nameOne = names[0];
            string nameTwo = names[1];
            string nameThree = names[2];
            string nameFour = names[3];
            string nameFive = names[4];

            Console.WriteLine(names);

            Console.WriteLine("anna 2 kokonaislukua välilyönnillä erotettuna");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int one = int.Parse(numbers[0]);
            int two = int.Parse(numbers[1]);

            int month = (int)Months.Autumn;

            Console.WriteLine("Syksyn arvo: " + month);

            Console.WriteLine(args.Length);

            double[] myArray = { double.Parse(args[0]), double.Parse(args[1]) };

            double sum = myArray[0] + myArray[1];
            double substract = myArray[0] - myArray[1];
            double multiply = myArray[0] * myArray[1];

            Console.WriteLine($"{myArray[0]} + {myArray[1]} = {sum}");
            Console.WriteLine($"{myArray[0]} - {myArray[1]} = {substract}");
            Console.WriteLine($"{myArray[0]} * {myArray[1]} = {multiply}");

            Console.WriteLine(args.Length);
        }
    }
}