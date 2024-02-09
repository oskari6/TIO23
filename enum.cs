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
        enum Months
        {
            tammikuu = 1,
            helmikuu,
            maaliskuu,
            huhtikuu,
            toukokuu,
            kesäkuu,
            heinäkuu,
            elokuu,
            syyskuu,
            lokakuu,
            marraskuu,
            joulukuu
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //€
        }
    }
}