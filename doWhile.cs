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
            //1. Kirjoita ohjelma, joka laskee yhteen luvut 1:stä 100:an. Käytä do...while rakennetta.

            int total = 0;
            int number = 1; 

            do
            {
               total = total + number; //int number += total;
               number++;

            } while (number <= 100);
            Console.WriteLine(total);

            /*2. Kirjoita ohjelma, joka pyytää käyttäjältä luvun 1-10 väliltä.
            Tulosta annetun luvun kertotaulu kymmenenteen kertoimeen asti.
            Käytä do..while rakennetta.

            Esim. 1 x 1 = 1
            2 x 1 = 2
            3 x 1 = 3...     10 x 1 = 10*/

            Console.Write("Anna numero 1-10 väliltä: ");
            int.TryParse(Console.ReadLine(), out int number);

            int multiplier = 1;

            do
            {
               int results = number * multiplier;
               Console.WriteLine(results);
               multiplier++;

            } while (multiplier <= 10);

            /*3. Tee ohjelma, joka pyytää käyttäjää arvaamaan ohjelmaan
            tallennetun luvun ja kysyy sitä niin kauan kuin käyttäjä vastaa oikein.
            Käytä do ...while rakennetta. (Kyllä, sama tehtävä kuin while-rakenteessa, mutta nyt do:n kanssa.)*/

            int savedNumber = 20;
            bool isCorrect = false;

            do
            {
               Console.Write("Arvaa tallentamani numero: ");
               int.TryParse(Console.ReadLine(), out int guessNumber);

               if(guessNumber == savedNumber)
               {
                   isCorrect = true;
                   Console.WriteLine("Arvasit oikein!");
               }
               else
               {
                   Console.WriteLine("Arvasit väärin.");
               }
            } while (!isCorrect);

            /*4. Tee ohjelma, jossa on merkkijono tyyppinen taulukko.
            Tallenna koodissa taulukkoon 10 nimeä alustamalla taulukko suoraan arvoilla.
            Tulosta nimet käyttämällä do while toistorakennetta.*/

            string[] myArray = { "Alan", "George", "Matt", "John", "Mike", "Matthew", "Colin", "Phil", "Brad", "Jonathan" };

            int i = 0;
            do
            {
               Console.WriteLine(myArray[i]);
               i++;
            } while (i < myArray.Length);
        }
    }
}