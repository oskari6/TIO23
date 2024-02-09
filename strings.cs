using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 //a namespace - user for organizational structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine(); //has a return
            Console.WriteLine(x); //has to be done to a variable
            Console.WriteLine($"Hello {x}!");//interpletation

            int? y = null; //get a null
            //"C" String, 'C' character

             /*Tehtävä 3.
            Tee ohjelma joka kysyy käyttäjältä viisi nimeä ja tallentaa ne string tyyppiseen taulukkoon.
            Lopuksi tulosta nimet taulukosta. (ei tarvitse tehdä toistorakenteella, 
            peräkkäiset ReadLine-, WriteLine - komennot ratkaisuna ok)*/

            Console.Write("Anna 5 nimeä erotettuna välilyönnillä: ");
            string input = Console.ReadLine();
            string[] names = input.Split(' ');
            string nameOne = names[0];
            string nameTwo = names[1];
            string nameThree = names[2];
            string nameFour = names[3];
            string nameFive = names[4];

            Console.WriteLine($"{nameOne}, {nameTwo}, {nameThree}, {nameFour}, {nameFive}");

            /*Tehtävä 4.
            Kirjoita ohjelma, joka saa syötteinä, argumentteina, kaksi kokonaislukua, 
            tallentaa luvut taulukkoon ja tulostaa lukujen summan, erotuksen ja kertolaskun tuloksineen.*/

            /*muuttuja-arvot tulevat ohjelmaan argumentteina.
            2 eri tapaa syöttää argumenttien(= parametrien, = muuttujien) arvot ohjelmaan: Debug - 
            Project Properties - Debug - Command Line Arguments TAI komentoikkunassa ohjelman käynnistyskomennon perään)*/

            Console.WriteLine(args.Length);

            int[] myArray = args.Select(int.Parse).ToArray();

            int sum = myArray[0] + myArray[1];
            int substract = myArray[0] - myArray[1];
            int multiply = myArray[0] * myArray[1];

            Console.WriteLine($"{myArray[0]} + {myArray[1]} = {sum}");
            Console.WriteLine($"{myArray[0]} - {myArray[1]} = {substract}");
            Console.WriteLine($"{myArray[0]} * {myArray[1]} = {multiply}");
        }
    }
}