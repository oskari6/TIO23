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
            Console.Write("anna kk palkkasi: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("anna veroprosenttisi: ");
            double taxRate = double.Parse(Console.ReadLine());

            double finalSalary = salary * (1 - (taxRate / 100)); //fastest way

            double taxesPaid = salary - finalSalary;

            Console.WriteLine(finalSalary.ToString("#.##"));
            Console.WriteLine("veron osuus nettopalkasta: " + taxesPaid.ToString("#.## veroja")); //## on numeroita

            Console.Write("Anna painosi; ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Anna pituutesi; ");
            double height = double.Parse(Console.ReadLine());

            double weightIndex = weight / (height / 100) * (weight / 100);

            Console.WriteLine("painokertoimesi on: " + weightIndex.ToString("#.#")); 

            if (weightIndex > 40)
            {
               Console.WriteLine("olet ikävä kyllä sairaalloisen lihava");
            } else if (weightIndex < 40 && weightIndex >= 35)
            {
               Console.WriteLine("ny on  vaikea lihavus");

            } else
            {
               Console.WriteLine("ihan hyvin painos ollaan");
            }

            Console.WriteLine("arvaa sana: ");
            string sana = Console.ReadLine();

            Console.WriteLine(sana[2]);
            Console.ReadKey(); //jos käyttää keytä voi poistua terminaalista näppäimellä

            Console.Write("anna tuotteen hinta: ");
            double tuotteenHinta = double.Parse(Console.ReadLine());

            Console.Write("Anna tuotteen alennus prosentti: ");
            double alennusProsentti = double.Parse(Console.ReadLine());

            double alennettuHinta = tuotteenHinta * (1 - (alennusProsentti / 100));
            double alennettuMäärä = tuotteenHinta - alennettuHinta;

            Console.Write("Tuotteen hinta alennuksen jälkeen on: " + alennettuHinta + " euroa\n");
            Console.WriteLine("Alennuksen määrä on: " + alennettuMäärä + " euroa\n");

            Console.ReadLine();

            Console.WriteLine("anna numero: ");
            int number = int.Parse(Console.ReadLine());
            int testi = number % 2; //tällä voi myös printata, 0 on parillinen, ei on pariton

            if (number % 2 == 0)
            {
               Console.WriteLine("numero on parillinen");
            } else
            {
               Console.WriteLine("numero on pariton");
            }
            
            //2.Kirjoita ohjelma, joka pyytää käyttäjältä kaksi kokonaislukua ja tulostaa niiden jakojäännöksen näytölle.
            Console.WriteLine("anna kaksi kokonaislukua 1 kerrallaan: ");
            //arraylla
            Console.WriteLine("anna 2 kokonaislukua välilyönnillä erotettuna");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int one = int.Parse(numbers[0]);
            int two = int.Parse(numbers[1]);

            int leftOvers = one % two;
            Console.WriteLine($"Antamasi lukujen {one} ja {two} jako jäännös on {leftOvers}");

            Console.ReadLine();

            //3.Kirjoita ohjelma, joka lukee tuotteen hinnan, laskee siitä ALV:n joka on 24 % tuotteen hinnasta ja tulostaa näytölle ALV: n
            //määrän sekä tuotteen hinnan ilman ALV: tä.
            //Tutustu ja kokeile rahamäärien tulostuksessa rahayksikköformaattia(c tai C).

            const double Alv = 0.24;
            Console.Write("give me a price: ");
            double itemPrice = double.Parse(Console.ReadLine());

            double priceWoVat = itemPrice / (1 + Alv);
            double vatAmount = itemPrice - priceWoVat;

            Console.WriteLine("ALV:n osuus hinnasta: " + vatAmount.ToString("C"));
            Console.WriteLine("tuotteen hinta ilman ALV:ia: " + priceWoVat.ToString("C"));

            //1. Kirjoita ohjelma, joka pyytää käyttäjältä kaksi kokonaislukua.
            //Ohjelma kertoo luvut keskenään ja tulostaa vastauksen konsoliin.

            Console.Write("Anna ensimmäinen kokonaisluku: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int multiplied = numberOne * numberTwo;

            Console.WriteLine(numberOne + "*" + numberTwo + "=" + multiplied);

            Console.ReadLine();

            2.Kirjoita ohjelma, joka laskee neljän luvun keskiarvon.

            Console.Write("Anna numero 1: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Anna numero 2: ");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.Write("Anna numero 3: ");
            double numberThree = double.Parse(Console.ReadLine());
            Console.Write("Anna numero 4: ");
            double numberFour = double.Parse(Console.ReadLine());

            int numbersCount = 4;
            double mean = (numberOne + numberTwo + numberThree + numberFour) / numbersCount;

            Console.WriteLine($"keskiarvo = {mean}");

            Console.WriteLine();

            3. Kirjoita ohjelma, joka laskee paljonko on 25 kertaa 5 jaettuna sadalla.
            double program = (25d * 5d) / 100d;
            Console.WriteLine("25 * 5 / 100 = " + program);

            Console.ReadLine();

            /*4. Kirjoita ohjelma, joka pyytää ja lukee kaksi numeroa näppäimistöltä. Tämän
            jälkeen ohjelman pitää suorittaa perusaritmeettiset operaatiot(yhteen-,
            vähennys -, kerto - ja jakolaskut) luvuilla ja tulostaa näytölle jokaisen
            operaation tulos.Ohjelman pitää tulostaa kaikki luvut kahden
            desimaalin tarkkuudella. Jos syötetyt luvut ovat esimerkiksi 3,456 ja
            1,230, ohjelman pitää tulostaa:*/

            Console.Write("Anna 1. luku (desimaali erotin , ): ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku (desimaali erotin , ): ");
            double numberTwo = double.Parse(Console.ReadLine());

            double sum = numberOne + numberTwo;
            double substract = numberOne - numberTwo;
            double divide = numberOne / numberTwo;
            double multiply = numberOne * numberTwo;

            Console.WriteLine($"\n summa = {sum.ToString("#.##")}\n vähennys = {substract.ToString("#.##")}\n" +
               $" jako = {divide.ToString("#.##")}\n kerto = {multiply.ToString("#.##")}");
        }
    }
}