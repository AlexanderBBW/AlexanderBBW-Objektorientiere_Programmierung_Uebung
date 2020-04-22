using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
namespace Azubis
{
    class Program
    {
        static void Main(string[] args)
        {
            AzubiVerwaltung azubiVerwaltung = new AzubiVerwaltung();     //Startet das Programm über die Instantizierung  
        }
        protected class Azubi
        {
            public string Nachname { get; set; }
            public string Vorname { get; set; }
            public DateTime Geburtsdatum { get; set; }
            public string Beruf { get; set; }
            public string Wohngruppe { get; set; }
            public DateTime AusbildungsBeginn { get; set; }
            public char Lehrjahr { get; set; }
            public int AzubiNummer { get; set; } //Wird unten in einer anderen Klasse generiert
            public Azubi(string Nachname, string Vorname, DateTime Geburtsdatum)
            {
                this.Nachname = Nachname;
                this.Vorname = Vorname;
                this.Geburtsdatum = Geburtsdatum;
            }
            protected int berechneAlter()
            {
                int alter = DateTime.Now.Year - Geburtsdatum.Year;
                if (DateTime.Now.CompareTo(Geburtsdatum) < 0) 
                { 
                    alter--;
                }
                return (alter);
            }
            public void gibSteckbriefAus() //Gibt den Steckbrief über die Azubis aus
            { 
                Console.WriteLine("Name:" + " " + Nachname + " " + "Vorname: " + " " + Vorname + " " + "Alter:" + " " + berechneAlter());
            }
        }
    class AzubiVerwaltung
    {
       public List<Azubi> MeineAzubiListe = new List<Azubi>(); //Erstellen der Liste wo die Azubis eingefügt werden bzw. gespeichert werden
        public AzubiVerwaltung()
        {
                AngabenAuswahl(); //Konstruktor damit Die Methode wenn sie in der main aufgerufen wird ausgeführt wird
        }
        protected void AngabenAuswahl() //Auswahl ob die Azubis angezeigt werden sollen 
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
            public void generiereID() //genereieren der AzubiNummer
            {

            }
        protected void AzubiEingabe()
        {
            Console.WriteLine("Bitte geben Sie den Nachnamen an!");
            string Nachname = Console.ReadLine(); //Eingabe Nachname
            Console.WriteLine("Bitte geben Sie den Vornamen an!");
            string Vorname = Console.ReadLine(); //Eingabe Vorname
            Console.WriteLine("Bitte geben Sie das Geburtsdatum an!");
            DateTime GeburtsDatum = Convert.ToDateTime(Console.ReadLine()); //Eingabe des Datums und umconvertierung
            Azubi MeinAzubi = new Azubi(Nachname, Vorname, GeburtsDatum);
            MeineAzubiListe.Add(MeinAzubi); //Fügt den Azubi zur Liste hinzu
            MeinAzubi.gibSteckbriefAus(); //Gibt den Steckbrief nach der Methode aus
        }
    }
        static void Exit()
        {
            Environment.Exit(2); //schließt das Programm 
        }
    }
}