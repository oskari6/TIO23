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
            //1. Tee ohjelma, joka tulostaa for-toistorakennetta käyttäen luvut 1-100.

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }

            //2. Muuta edellistä ohjelmaa siten, että luvut tulostetaan laskevassa
            //järjestyksessä alkaen luvusta 100 ja päättyen lukuun 1.

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //3. Tee ohjelma, joka tulostaa for-toistorakennetta käyttäen joka toisen luvun välillä 1-100:
            //Tulostuu: 1, 3, 5, 7, 9, 11, … ,97,99

            for (int i = 1; i < 100; i+=2)
            {
                Console.WriteLine(i);
            }

            /*4. Tee ohjelma joka tulostaa konsolille seuraavanlaisen kuvion. Käytä for-toistorakennetta.
            ********
            ********
            ********
            ******** */

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }

            //5. Muuta tehtävää 4 siten, että ohjelma kysyy käyttäjältä kuvion
            //leveyden ja korkeuden sekä tulostaa halutun kokoisen kuvion

            Console.Write("Anna kuvion leveys: ");
            int.TryParse(Console.ReadLine(), out int width);
            Console.Write("Anna kuvion korkeus: ");
            int.TryParse(Console.ReadLine(), out int height);

            //string star = "";
            //star = new String('', width);

            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*6. Tee ohjelma joka tulostaa konsolille seuraavanlaisen kuvion. Käytä for-toistorakennetta.

            *
            **
            ***
            ****
            *****
            ******
            *******
            ******** */

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //7. Muuta tehtävää 6 siten, että ohjelma tulostaa niin monta riviä,
            //kun käyttäjä haluaa, maksimi on yhdelle riville sopiva merkkimäärä

            while(true)
            {
                Console.Write("Kuinka monta riviä haluat tulostaa: ");
                int.TryParse(Console.ReadLine(), out int amount);

                if (amount > 120)
                {
                    Console.WriteLine("Liian paljon, anna uusi arvo");
                    continue;
                }
                else
                {
                    for (int i = 0; i < amount; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }
        Console.ReadLine();

            /*1.
            a) Toteuta C# käyttäen 100 soluinen taulukko ja vie sen jokaiseen soluun luku 5. 
            Lopuksi tulosta taulukon sisältö for-silmukkaa käyttäen.
            b) Tulosta taulukon sisältö lopusta alkuun.*/

            int[] myArray = new int[100];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = 5;
            }

            for(int j = 99; j >= 0; j--)
            {
                Console.WriteLine($"{j + 1}: {myArray[j]}");
            }

             /*2. Tee ohjelma joka tulostaa luvut 1--100, ja jos luku on jaollinen 5:llä, 
                tulosta luvun perään teksti "Hep!". Tulostuksen olla täsmälleen kuten mallissa. 
                Ota huomioon välit ja rivinvaihdon kohta                1 
                2 
                3 
                4
                5 Hep!                 
                6 
                7 
                8 
                9 
                10 Hep!*/

            //käydään luvut 1-100 läpi
            for (int i = 1; i < 101; i++)
            {   //tehdään ehto jos jako jäännös 5:llä on 0, eri tulostus
                if (i % 5 == 0)
                {
                    Console.WriteLine(string.Format("{0, 3}", i) + " Hep");
                    continue; //jos tämä toteutuu -> seuraava iteraatio
                }
                Console.WriteLine("{0,3}", i);
            }

            /*2.Kirjoita ohjelma, joka pyytää käyttäjältä kaksi kokonaislukua, 
            laskee niiden välillä olevien lukujen summan ja tulostaa sen näytölle.*/

            int total = 0;

            Console.Write("Hei anna 2 kokonaislukua erotettuna välilyönnillä: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int.TryParse(numbers[0], out int numberOne);
            int.TryParse(numbers[1], out int numberTwo);

            for(int i = numberOne + 1; i < numberTwo; i++)
            {
                numberOne = numberOne + 1;
                total = total + numberOne;
            }

            Console.WriteLine($"numeroidesi välisten numeroiden summa on: {total}.");

            //fibonacci sequence
            int x = 0;
            int y = 1;
            int z = 0;

            for(int i = 0; i < 20; i++)
            {
                z = x + y; //kahden edellisen summa
                Console.WriteLine(z); //esitys
                x = y; //seuraava numero sarjassa
                y = z; //toisen summattavan numeron arvon muunto
            }

            //1. Kirjoita ohjelma, jossa tulostetaan joka 3. luku väliltä 1-100. Käytä continue-lausetta.

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0) //jos jakojäännös 0 tulostetaan
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue; //muuten mennään seuraavaan iteraatioon.
                }
            }

            /*2.Kirjoita ohjelma, jossa määrittelet int-tyyppiä olevan taulukon, 
            jonka koko on 10.Alusta taulukko for-toistolauseella sekä parillisilla että parittomilla luvuilla.
            Laske tämän jälkeen taulukossa olevien parittomien lukujen summa.
            Vihje: continue-lauseella pääset toistolauseen kierrosten yli*/

            //tehdään taulukko
            int[] myArray = new int[10];
            //tuodaan taulukon täyttöä varten random moduuli
            Random random = new Random();

            //täytetään taulukko random numeroilla
            for (int i = 0; i < myArray.Length; i++)
            {
                int randNum = random.Next(1, 20);
                myArray[i] = randNum;
            }

            //muuttuja parittomien laskemiselle
            int count = 0;

            //näytetään taulukon arvot
            Console.WriteLine("Taulukon numerot:");
            //käydään taulukon arvot läpi
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                //jos ei ole jakojäännös 0 on pariton ja lasketaan muutujaan
                if (myArray[i] % 2 != 0)
                {
                    count++;
                }
                else
                {//jos ei pariton niin seuraava iteraatio
                    continue;
                }
            }//esitetään tulos
            Console.WriteLine("parittomien määrä: " + count);
        }
    }
}