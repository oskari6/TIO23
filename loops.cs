using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class loops
    {
        static void Main(string[] args)
        {
            int i = 0; //icu
            while (i < 10)
            {
                Console.WriteLine(i);
                Console.ReadLine();
                i++;
            }

            int k = 0;
            do //atleast once do while loop
            {
                Console.WriteLine(k);
                Console.ReadLine();
            }
            while (k < 10);

            for (int u = 0; u < 10; u++)
            {
                Console.WriteLine(u);
                Console.ReadLine();
            }


            bool logging = false;
            for(int b = 9; b >=0; b-=2)
            {
                Console.WriteLine(b);
                Console.ReadLine();
                if( i == 7)
                {
                    if(logging == true)
                    {
                        Console.WriteLine("found 7");
                        Console.ReadLine();
                    }
                }
            }

            for(int x = 9; x >= 0; x--)
            {
                if( x == 5)
                {
                    break;
                }
                for(int y = x; y >= 0; y--)
                {
                    if(y == 3)
                    {
                        continue;
                    }
                    Console.Write(y); //continue skips this
                    Console.Read();
                }
                Console.WriteLine();
            }


            int t = 9;
            while(t >= 0)
            {
                int o = t;
                while(o >= 0)
                {
                    Console.WriteLine(o + " ");
                    Console.ReadLine();
                    o--;
                }
                Console.WriteLine();
                Console.ReadLine();
                t--;
            }

            /*Kirjoita ohjelma, joka pyytää käyttäjältä reaalilukuja, 
            laskee ne yhteen ja näyttää niiden reaaliaikaisen summan, samalla kun se pyytää seuraavaa lukua. 
            Ohjelman pitää jatkaa näin niin kauan kuin lukujen yhteissumma on korkeintaan 100.
            Jos lukujen yhteissumma ylittää 100, ohjelman tulee ilmoittaa, että raja on saavutettu ja se lopettaa toiminnan.*/
            int sum = 0;

            while (true)
            {
            
                Console.Write("Anna luku: ");
                int.TryParse(Console.ReadLine(), out int number);

                sum += number;
                Console.WriteLine("Summa on: " + sum);
                if (sum > 100)
                {
                    Console.WriteLine("raja on ylitetty!");
                    break;
                }
            }

            /*Kirjoita ohjelma, joka pyytää käyttäjältä reaalilukuja, 
            laskee ne yhteen ja näyttää niiden reaaliaikaisen summan, samalla kun se pyytää seuraavaa lukua. 
            Ohjelman pitää jatkaa näin niin kauan kuin lukujen yhteissumma on korkeintaan 100.
            Jos lukujen yhteissumma ylittää 100, ohjelman tulee ilmoittaa, että raja on saavutettu ja se lopettaa toiminnan.*/

            int sum = 0;

            while (true)
            {
            
                Console.Write("Anna luku: ");
                int.TryParse(Console.ReadLine(), out int number);

                sum += number;
                Console.WriteLine("Summa on: " + sum);
                if (sum > 100)
                {
                    Console.WriteLine("raja on ylitetty!");
                    break;
                }            
            }

            /*3.Kirjoita ohjelma, joka pyytää käyttäjältä ylärajan luvun ja tulostaa alkuluvut(prime numbers), jotka ovat sitä pienempiä tai joka on yhtä suuri kuin se itse.
            Vihje: Alkuluku on positiivinen kokonaisluku, joka on jaollinen vain ykkösellä ja
            itsellään.*/

            //kysytään raja
            Console.Write("Anna isoin luku, johon asti haluat tietää alkuluvut: ");
            int.TryParse(Console.ReadLine(), out int limit);
            //tehdään taulukko numeroilla jotka ylettyy rajaan asti, 
            int[] numbers = new int[limit + 1];

            //koska 1 ei ole alkuluku
            for(int i = 2; i < numbers.Length; i++)
            {
                numbers[i]= i;
            }
            //katsotaan jokainen luku läpi yksi kerrallaan onko kantaluku
            for (int i = 2; i <= limit; i++)
            {   //tehdään muuttuja jossa oletetaan että luku on kantaluku
                bool isPrime = true;
                //tehdään toinen looppi jossa tarkastetaan ulomman loopin arvot taulukon arvojen kanssa
                for(int j = 2; j < i; j++) 
                {   //jos jakojäännöstä ei jää, ei luku voi olla kantaluku -> hylky
                    if(i % numbers[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }//jos on niin se tulostetaan muuttujan avulla
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }

            /*4.Kirjoita ohjelma, jossa määrittelet kaksi char-tyyppiä
            olevaa taulukkoa, joiden koko on 10.Alusta ensin taulukoiden alkiot
            mielesi mukaan ja vertaile niitä sitten keskenään siten, että ohjelma
            tulostaa ne alkiot, jotka olivat taulukossa erilaisia.*/

            char[] myArrayOne = new char[10] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'}; //b d f h j
            char[] myArrayTwo = new char[10] {'a', 'm', 'c', 'x', 'e', 'u', 'g', 'p', 'i', 'q'}; //m x u p q

            HashSet<char> uniqueOne = new HashSet<char>();
            HashSet<char> uniqueTwo = new HashSet<char>();

            for (int i = 0; i < 10; i++)
            {
                if (myArrayOne[i] != myArrayTwo[i])
                {
                    uniqueOne.Add(myArrayOne[i]);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (myArrayTwo[i] != myArrayOne[i])
                {
                    uniqueTwo.Add(myArrayTwo[i]);
                }
            }
            Console.Write("1. taulukon erilaiset: ");
            foreach (char c in uniqueOne)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.Write("2. taulukon erilaiset: ");
            foreach (char c in uniqueTwo)
            {
                Console.Write(c + " ");
            }

            //char taulukko vertailu yksinkertainen
            char[] myArrayOne = new char[10] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' }; //b d f h j
            char[] myArrayTwo = new char[10] { 'a', 'm', 'c', 'x', 'e', 'u', 'g', 'p', 'i', 'q' }; //m x u p q

            for(int i = 0; i < 10; i++)
            {
                    if (myArrayOne[i] == myArrayTwo[i])
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(myArrayOne[i] + " ");
                    }
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (myArrayTwo[i] == myArrayOne[i])
                {
                    continue;
                }
                else
                {
                    Console.Write(myArrayTwo[i] + " ");
                }
            }
        }
    }
}
