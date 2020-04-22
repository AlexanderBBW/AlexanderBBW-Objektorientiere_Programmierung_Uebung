using System;
using System.Collections.Generic;
namespace Azubis
{
    class Program
    {
        static void Main(string[] args)
        {
            AzubiVerwaltung azubiVerwaltung = new AzubiVerwaltung();     
        }
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
                if (DateTime.Now.CompareTo(Geburtsdatum) < 0) 
                { 
                    alter--;
                }
                return (alter);
            }
            public void gibSteckbriefAus()
            {
                Console.WriteLine("Name:" + " " + Nachname + " " + "Vorname: " + " " + Vorname + " " + "Alter:" + " " + berechneAlter());
            }
        }
    class AzubiVerwaltung
    {
       public List<Azubi> MeineAzubiListe = new List<Azubi>();
        public AzubiVerwaltung()
        {
                AngabenAuswahl();
        }
        protected void AngabenAuswahl()
        {
            Console.WriteLine("0 Zeigt alle aktullen Azubis an und 1 lässt Sie einen neuen angeben!");
                Console.WriteLine("2 zum beenden des Programmes --> Löscht alle Azubis");
            switch (Console.ReadLine())
            {
                //case "0":
                    //break;
                case "1":
                    AzubiEingabe();
                    break;
                    case "2":
                        Exit();
                        break;
                default:
                    AngabenAuswahl();
                    break;
            }
        }
        public void AzubiEingabe()
        {
            Console.WriteLine("Bitte geben Sie den Nachnamen an!");
            string Nachname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den Vornamen an!");
            string Vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie das Geburtsdatum an!");
            DateTime GeburtsDatum = Convert.ToDateTime(Console.ReadLine());
            Azubi MeinAzubi = new Azubi(Nachname, Vorname, GeburtsDatum);
            MeineAzubiListe.Add(MeinAzubi);
            MeinAzubi.gibSteckbriefAus();
        }
    }
        static void Exit()
        {
            Environment.Exit(2);
        }
    }
    //class AnzubiAnzeigen
    //{
    //    public void Azubianzeigen()
    //    {

    //    }
    //}
}