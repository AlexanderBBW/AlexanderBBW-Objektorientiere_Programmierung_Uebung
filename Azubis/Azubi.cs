using System;
namespace Azubis
{
    class Azubi
    {        
        public string Nachname { get; set; }
        public string Vorname { get; set; } 
        public DateTime Geburtsdatum { get; set; } //Wird zur Berechnung des Alters benötigt
        public string Beruf { get; set; }
        public string Wohngruppe { get; set; }
        public DateTime AusbildungsBeginn { get; set; }
        public char Lehrjahr { get; set; }
        public string AzubiNummer { get; set; } //Wird unten in einer anderen Klasse generiert
        public Azubi(string Nachname, string Vorname, DateTime Geburtsdatum) //Konstruktor
        {
            this.Nachname = Nachname;
            this.Vorname = Vorname;
            this.Geburtsdatum = Geburtsdatum;
            AzubiNummer = IDGenerierung.Generierung();
        }
        protected int berechneAlter() //Berechnet aus dem Geburtsdatum und dem heutigen Datum das Alter
        {
            int alter = DateTime.Now.Year - Geburtsdatum.Year;
            if (DateTime.Now.CompareTo(Geburtsdatum) < 0) //Abfrage zur Absicherung das auch das richtige alter genommen wird (Monat und Tage )
            {
                alter--;
            }
            return (alter);
        }
        public void gibSteckbriefAus() //Gibt den Steckbrief über die Azubis aus
        {
            Console.WriteLine("Name:" + " " + Nachname + " " + "Vorname: " + " " + Vorname + " " + "Alter:" + " " + berechneAlter()+ " " + "Azubinummer" +" " +AzubiNummer);
        }
    }
}
