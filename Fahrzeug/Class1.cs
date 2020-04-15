namespace Fahrzeug
{
    public class Fahrzeug
    {
        public string Baujahr { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public string Laufleistung { get; set; }
        public string Kennzeichen { get; set; }
        public string Eigentümer { get; set; }

        public Fahrzeug(string Modell, string Eigentümer, string Kennzeichen)
        {
            this.Modell = Modell;
            this.Eigentümer = Eigentümer;
            this.Kennzeichen = Kennzeichen;
        }
        public Fahrzeug(string Modell, string Eigentümer, string Kennzeichen, string Baujahr)
        {
            this.Modell = Modell;
            this.Eigentümer = Eigentümer;
            this.Kennzeichen = Kennzeichen;
            this.Baujahr = Baujahr;
        }
        public string erhoeheLaufleistung(string Laufleistung)
        {
            return ("Das Modell" + " " + Modell+ " " + "mit dem Kennzeichen" + " " + Kennzeichen + " " + "Vom Eigentümer " + " " + Eigentümer + 
                " " + "besitzt eine Laufleistung von" + " " + Laufleistung + " "+ "Killometern");
        }
    }
}