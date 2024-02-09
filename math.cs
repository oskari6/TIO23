using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Switch
    {
        static void Main(string[] args)
        {
            /*4.Kirjoita ohjelma, joka tulostaa näytölle 20 lukua seuraavasta sarjasta.
            Vihje: lukuun ottamatta ensimmäistä lukua, jokainen luku on itseään edeltävien lukujen summa. 
            Ensimmäisen luvun perusteella voit laskea kaikki muut luvut. 1, 1, 2, 4, 8, 16, …*/

            int num = 1;
            Console.WriteLine(1);

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}