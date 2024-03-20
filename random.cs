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
            //käyttäjältä saadaan nopan koko jonka jälkeen heitetään pyydettyä noppaa.
            Console.Write("Anna nopan koko: ");
            int diceSize = int.Parse(Console.ReadLine());

            if(diceSize > 0)
            {
                Random dice = new Random();//saadaan random numero with constructor
                int rndNumber = dice.Next(1, diceSize+  1);

                Console.Write("Heitit : " + rndNumber);
            }
        }
    }
}