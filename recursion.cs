using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine($"Factorial of {n} is {Factorial(5)}.");
        }
        public static int Factorial(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}

