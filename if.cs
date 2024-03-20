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
            //1. Kirjoita ohjelma, jossa käyttäjältä pyydetään kokonaisluku. Ohjelma vertaa tätä etukäteen tallennettuun lukuun.
            //Ohjelman tarkoitus on tulostaa käyttäjälle vertailun lopputulos, oliko käyttäjän antama luku suurempi.

            int myNumber = 6;
            Console.Write("anna numero: ");
            int yourNumber = int.Parse(Console.ReadLine());

            bool guess = yourNumber > myNumber;
            Console.WriteLine("numerosi on isompi kuin minun totuusarvo: " + guess);


            int myNumber = 3;
            Console.Write("anna kokonaisluku: ");
            int number = int.Parse(Console.ReadLine());

            if (number > myNumber)
            {
               Console.WriteLine("lukusi on suurempi, minun lukuni on: " + myNumber);
            }
            else if (number == myNumber)
            {
               Console.WriteLine("lukusi on yhtä suuri kuin minun!");
            }
            else
            {
               Console.WriteLine("lukusi on pienempi kuin minun, minun lukuni on: " + myNumber);
            }

            //leap year
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkaus vuosi");
            }

            /*1. Toteuta ohjelma, joka pyytää käyttäjää syöttämään etunimensä.
            Mikäli käyttäjän nimen pituus on suurempi kuin 5 merkkiä,
            ohjelma tulostaa tekstin "pitkä nimi". Muutoin ohjelma tulostaa tekstin "lyhyt nimi".*/

            while (true)
            {
                Console.Write("Anna etunimesi: ");
                string firstName = Console.ReadLine().ToLower();
                string favName = "Oskari";

                favName = favName.ToLower();

                if (string.IsNullOrEmpty(firstName)) //checks for nulls
                {
                    Console.WriteLine("Laiton vastaus: ");
                }
                else
                {
                    if (firstName.Length > 5)
                    {
                        Console.WriteLine("Pitkä nimi");
                    }
                    else
                    {
                        Console.WriteLine("Lyhyt nimi");
                    }

                    if (firstName == favName)
                    {
                        Console.WriteLine("Paras nimi");
                    }
                    if (firstName.Length > 3 && firstName[2] == 'k')
                    {
                        Console.WriteLine("3. kirjain on k");
                    }
                }
            }
            /*Lisätehtävä: Jos vastaa Joni, pitää tulostaa paras nimi!!!
            Lisälisätehtävä: Jos kolmas kirjain on k, tulostetaan lopuksi teksti "3. kirjain on k"
            Lisälisälisätehtävä: Jos käyttäjä vastaa suoraan enterillä, kysy uudestaan*/

            /*2. Toteuta ohjelma, joka pyytää käyttäjää syöttämään kokonaisluvun.
            Mikäli käyttäjän syöttämä luku on parillinen ohjelma tulostaa tekstin "parillinen".
            Muutoin ohjelma tulostaa tekstin "pariton".*/

            Console.Write("anna kokonaisluku: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0) //null check
            {
                Console.WriteLine("annoit nollan tai et antanut mitään.");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} on parillinen", num);
                }
                else
                {
                    Console.WriteLine("{0} on pariton", num);
                }
            }
            /*4. Toteuta ohjelma, jossa muuttujat osumapisteet ja aseenTyyppi.
            Toteuta ohjelmaan ehtorakenne, jossa tutkitaan, onko ase miekka vai jousi.
            Jos ase on miekka, lisätään osumapisteisiin 50. Jos ase on jousi, lisätään osumapisteisiin 100.*/

            string weaponType = ""; toinen tapa saada ihan sama mikä ase
            weaponType = readline

            int points = 0;
            Console.WriteLine("gun type: ");
            string gunType = Console.ReadLine().ToLower(); //muista ToLower inputissa

            string gunTypeOne = "miekka";
            string gunTypeTwo = "jousi";

            if (gunType == gunTypeOne)
            {
               points += 50;
               Console.WriteLine("points {0}", points);
            }
            else if (gunType == gunTypeTwo)
            {
               points += 100;
               Console.WriteLine("points {0}", points);
            }
            else
            {
               Console.WriteLine("different gun type");
            }

            /*1.Kirjoita ohjelma, jossa määrittelet muuttujan arvonta ja
            alustat sen jollakin kokonaisluvulla, esim. 45.
            Ohjelman pitää pyytää käyttäjältä luku ja verrata sitä muuttujan arvonta arvoon.
            Jos käyttäjän syöttämä luku on yhtä suuri kuin arvonta,
            ohjelman pitää tulostaa onnitteluviesti ja lopettaa.
            Muussa tapauksessa ohjelman pitää jatkaa luvun pyytämistä,
            kunnes kierrosten määrä on 5 tai tulee osuma.*/

            int rightGuess = 45;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Arvaa luku, sinulla on {5 - i} yritystä: ");
                int.TryParse(Console.ReadLine(), out int guess);

                if (guess == rightGuess)
                {
                    Console.WriteLine("***onnittelut***");
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Peli on ohi..");
        }
    }
}