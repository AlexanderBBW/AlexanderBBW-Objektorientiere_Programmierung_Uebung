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
            public int berechneAlter()
            {
                int alter = DateTime.Now.Year - Geburtsdatum.Year;
                if (DateTime.Now.CompareTo(Geburtsdatum) < 0) { alter--; }
                 return (alter);
            }
            public void gibSteckbriefAus()
            {
                Console.WriteLine("Name:" + " " + Nachname + " " + "Vorname: " + " " + Vorname + " " + "Alter:" + " " + berechneAlter());
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
            AuswahlMenue();
            }
        static void AuswahlMenue()
        {
            Console.WriteLine("Bitte geben Sie '1' an um einen neuen Azubi anzulegen oder '0' um sich die Azubis anzeigen zu lassen!");
            switch (Console.ReadLine())
            {
                case "1":
                    AzubiEingabe();
                    break;
                case "0":
                    AzubiAusgabe();
                    break;
                default:
                    Console.WriteLine("Dies war keine gültige Eingabe, drücken sie eine beliebige Taste um zur erneuten Auswahl zu kommen!");
                    Console.ReadKey();
                    AuswahlMenue();
                break;
            }
        }
        static object AzubiEingabe()
        {
            Console.WriteLine("Bitte geben Sie den Nachnamen an!");
            string Nachname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den Vornamen an!");
            string Vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den Nachnamen an!");
            DateTime GeburtsDatum = Convert.ToDateTime(Console.ReadLine());
            Azubi MeinAzubi = new Azubi(Nachname, Vorname, GeburtsDatum);
            AzubiAnzeigen(MeinAzubi);
            return (MeinAzubi);
        }
        static void AzubiAnzeigen(object MeinAzubi)
        {
            Console.WriteLine(MeinAzubi);
            Console.ReadLine();
        }
        static void AzubiAusgabe()
        {

        }
    }
}