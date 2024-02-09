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
            //2.Toteuta C# käyttäen ohjelma, joka kysyy käyttäjältä 5 nimeä ja tallettaa ne taulukkoon.
            //Lopuksi tulosta taulukon sisältö foreach -silmukkaa käyttäen.

            Console.Write("Hei anna 5 nimeä eroitettuna välilyönnillä: ");
            string input = Console.ReadLine();
            string[] names = input.Split(' ');
            string one = names[0];
            string two = names[1];
            string three = names[2];
            string four = names[3];
            string five = names[4];

            Console.WriteLine("Antamasi nimet olivat: ");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("nulling all values..");
            string element = "null";

            for ( int i = 0; i < names.Length; i++ )
            {
                names[i] = element;
                Console.WriteLine(names[i]);
            }

            /*4. Toteuta 10 soluinen taulukko, jonka sisällöksi arvotaan 10 kokonaislukua väliltä 1...1000
            //ja ohjelma käy taulukon läpi lajittelee sen ja laskee lukujen keskiarvon. 

            Satunnaisluku esim.  	Random rnd = new Random();
            luku = rnd.Next(0, 101);
            Lajittelu Array.Sort(taulukko); Katso esim. Tutorial Teacher.com

            Tulostus    Lukujen 53, 171, 352, 654, 716, 737, 806, 937, 938 ja 968 keskiarvo on 633,20*/

            int[] myArray = new int[10];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                int randomNum = random.Next(0, 1000);
                myArray[i] = randomNum;
            }

            Array.Sort(myArray);
            int sum = 0;
            for(int j = 0; j < myArray.Length; j++)
            {
                sum += myArray[j];
            }

            int mean = sum / myArray.Length;

            Console.Write($"Lukujen: " +
                $"{myArray[0]}, " +
                $"{myArray[1]}, " +
                $"{myArray[2]}, " +
                $"{myArray[3]}, " +
                $"{myArray[4]}, " +
                $"{myArray[5]}, " +
                $"{myArray[6]}, " +
                $"{myArray[7]}, " +
                $"{myArray[8]}, " +
                $"{myArray[9]} keskiarvo on {mean}.");

                /*3.Kirjoita ohjelma, joka pyytää käyttäjältä viisi kokonaislukua, 
                kirjoittaa ne sopivaan taulukkoon ja laskee lopussa niiden keskiarvon
                ja tulostaa sen näytölle.Käytä keskiarvon laskennassa foreach-lausetta.*/

                Console.Write("Hei, anna 5 kokonaislukua erotettuna välilyönneillä: ");
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');

                int.TryParse(numbers[0], out int numberOne);
                int.TryParse(numbers[1], out int numberTwo);
                int.TryParse(numbers[2], out int numberThree);
                int.TryParse(numbers[3], out int numberFour);
                int.TryParse(numbers[4], out int numberFive);

                int[] newArray = Array.ConvertAll(numbers, int.Parse);
                int sum = 0;

                foreach (int number in newArray) 
                {
                    sum += number;
                }

                int mean = sum / 5;
                Console.Write("numeroidesi keskiarvo on: " + mean);
        }
    }
}