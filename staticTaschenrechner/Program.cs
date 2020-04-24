using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticTaschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static char Opperator()
        {
            Console.WriteLine("Bitte geben Sie den Opperator an");
            Console.WriteLine("+, -, *, / und ^ ");
            char opperator = Convert.ToChar(Console.ReadLine());
            return opperator;
        }
        public static void Eingabe()
        {
            Console.WriteLine("Bitte Geben Sie die erste Zahl ein!");
            int eingabe1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein!");
            int eingabe2 = Convert.ToInt32(Console.ReadLine());
            Rechnen(eingabe1, eingabe2);
        }
        public static void Rechnen(int eingabe1 , int eingabe2)
        {
            Program.Opperator opperator = new Program.Opperator();
            var Ergebniss = eingabe1 + opperator + eingabe2; 
        }
    }
}
