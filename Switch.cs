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
            string name = "Caleb";
            switch(name)
            {
                case "Caleb": //can be named numbers
                    Console.WriteLine("legit");
                    break;
                case "Claire":
                    Console.WriteLine("no");
                    //return; //stops and goes to main. use either break or return
                    break;
                default:
                    Console.WriteLine("who");
                    break;
            }
        }
    }
}
