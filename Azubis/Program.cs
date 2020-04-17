using System;
using System.Collections.Generic;
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
            List<Azubi> MeineAzubiListe = new List<Azubi>();
                AnganbenAuswahl();
            }
        static void AnganbenAuswahl()
        {
            Console.WriteLine("Bitte geben Sie '1' '2' oder '3' um neue Azubi anzulegen oder '0' um sich die Azubis anzeigen zu lassen!");
            switch (Console.ReadLine())
            {
                case "1":
                    AzubiEingabe();
                    break;
              //case "2":
              //      AzubiEingabezwei();
              //      break;
              //  case "3":
              //      AzubiEingabedrei();
              //      break;
                default:
                    AnganbenAuswahl();
                    break;
            }
        }
        static void AzubiEingabe()
        {
            Console.WriteLine("Bitte geben Sie den Nachnamen an!");
            string Nachname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den Vornamen an!");
            string Vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie das Geburtsdatum an!");
            DateTime GeburtsDatum = Convert.ToDateTime(Console.ReadLine());
            Azubi MeinAzubi = new Azubi(Nachname, Vorname, GeburtsDatum);
            MeinAzubi.gibSteckbriefAus();
            Console.WriteLine("beenden? JA = '0' Nein = 1");
            switch (Console.ReadLine())
            {
                case "0":
                    Exit();
                    break;
                case "1":
                    AzubiEingabe();
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe, das Programm wird jetzt gestoppt");
                    Console.WriteLine("Drücke beliebige Taste");
                    Console.ReadKey();
                    Exit();
                    break;
            }
        }
        static void Exit()
        {
            Environment.Exit(2);
        }
    }
}