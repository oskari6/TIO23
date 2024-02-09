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
            //1. Tee ohjelma, joka tulostaa 5 kertaa oman nimesi. Käytä while rakennetta.

            Console.Write("Anna nimesi: ");
            string name = Console.ReadLine();

            int i = 0;
            while (i < 5)
            {
               Console.WriteLine(name);
               i++;
            }

            //2. Tee ohjelma, joka tulostaa luvut 1 - 10. Käytä while rakennetta.

            int i = 1;

            while(i <= 10)
            {
               Console.WriteLine(i);
               i++;
            }

            /*3. Tee ohjelma, joka pyytää käyttäjää arvaamaan ohjelmaan tallennetun luvun
            ja kysyy sitä niin kauan kuin käyttäjä vastaa oikein. Käytä while rakennetta.*/

            int savedNumber = 10;
            bool guess = false;

            while (guess == false)
            {
               Console.WriteLine("arvaa luku: ");
               int input = int.Parse(Console.ReadLine());

               if (input == savedNumber)
               {
                   guess = true;
                   Console.WriteLine("Arvasti oikein, {0} on oikein", savedNumber);
                   break;
               }
               else
               {
                   continue;
               }
            }
            //toinen tapa
             bool = isCorrect = false; //good practice variable naming
             while(!isCorrect)
             {

             }
             
            /*Kirjoita ohjelma, joka hakee ja asettaa satunnaisen kokonaisluku muuttujan 1-100.
            Käyttäjän tehtävä on arvata luku, ohjelma kertoo onko arvaus liian suuri tai liian pieni.
            Käyttäjälle annetaan 5 arvausta.
            Viimeisen arvauksen jälkeen paljastetaan oikea numero.
            Peli on mahdollista pelata uudelleen arvausten päätyttyä tai oikean vastauksen jälkeen,
            ohjelma kysyy "Haluatko pelata uudestaan?".Jos käyttäjä vastaa ei, peli sulkeutuu. 
            Mikäli kyllä, peli käynnistyy alusta uudestaan.*/

            Random random = new Random();
            int randomNum = random.Next(1,100);

            int guesses = 0;


            while(true)
            {
                while (guesses < 5)
                {
                    Console.Write("Arvaa numero 1-100 väliltä: ");
                    int guessNum = int.Parse(Console.ReadLine());

                    if (guessNum == randomNum)
                    {
                        Console.WriteLine("Arvasit oikean numeron!");
                        Console.Write("Haluatko pelata uudestaan? Y/n: ");
                        char input = char.Parse(Console.ReadLine());

                        if (input == 'Y')
                        {
                            guesses = 0;
                            continue;
                        }
                        else if (input == 'n')
                        {
                            Console.WriteLine("Kiitos pelaamisesta!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sopimaton vastaus");
                            break;
                        }
                    }
                    if (guessNum > randomNum)
                    {
                        Console.WriteLine("Arvauksesi on liian suuri");
                    }
                    else if (guessNum < randomNum)
                    {
                        Console.WriteLine("Arvauksesi on liian pieni");
                    }
                    else
                    {
                        Console.WriteLine("Vastauksesi ei ole 1-100 välillä");
                    }
                    guesses++;
                }
                if (guesses == 5)
                {
                    Console.WriteLine("Hävisit, oikea numero olisi ollut: " + randomNum);
                }
                Console.Write("Haluatko pelata uudestaan? Y/n: ");
                char newTry= char.Parse(Console.ReadLine());

                if (newTry == 'Y')
                {
                    guesses = 0;
                    continue;
                }
                else if (newTry == 'n')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sopimation syöte, poistutaan pelistä");
                    break;
                }
            }
        }
    }
}