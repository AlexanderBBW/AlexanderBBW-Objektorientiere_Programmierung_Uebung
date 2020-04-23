using System;
namespace Azubis
{
    class Azubi
    {
        
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string Beruf { get; set; }
        public string Wohngruppe { get; set; }
        public DateTime AusbildungsBeginn { get; set; }
        public char Lehrjahr { get; set; }
        public string AzubiNummer { get; set; } //Wird unten in einer anderen Klasse generiert
        public Azubi(string Nachname, string Vorname, DateTime Geburtsdatum)
        {
            this.Nachname = Nachname;
            this.Vorname = Vorname;
            this.Geburtsdatum = Geburtsdatum;
            AzubiNummer = IDGenerierung.Generierung();
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
            Console.WriteLine("Name:" + " " + Nachname + " " + "Vorname: " + " " + Vorname + " " + "Alter:" + " " + berechneAlter()+ " " + "Azubinummer" +" " +AzubiNummer);
        }
    }
}
