using System;
namespace Azubis
{
        public class Azubi
        {
            public string Nachname { get; set; }
            public string Vorname { get; set; }
            public DateTime Geburtsdatum { get; set; }
            public string Beruf { get; set; }
            public string Wohngruppe { get; set; }
            public DateTime AusbildungsBeginn { get; set; }
            public char Lehrjahr { get; set; }
            public Azubi(string Nachname, string Vorname, DateTime Geburtsdatum)
            {
                this.Nachname = Nachname;
                this.Vorname = Vorname;
                this.Geburtsdatum = Geburtsdatum;
            }
            private void berechneAlter(DateTime Geburtsdatum)
            {
                int Jahr = DateTime.Now.Year - Geburtsdatum.Year;
                if (DateTime.Now.CompareTo(Geburtsdatum) < 0) { Jahr--; }
                gibSteckbriefAus(Jahr);
            }
            public void gibSteckbriefAus(int Jahr)
            {
                Console.WriteLine("Name:" + " " + Nachname + " " + "Vorname: " + " " + Vorname + " " + "Alter:" + " " + Jahr);
                 Console.WriteLine(Jahr);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Azubi MeinAzubi = new Azubi("Grunert", "Alexander", Convert.ToDateTime("09.02.2001"));
                Console.ReadKey();
            }
        }
    }