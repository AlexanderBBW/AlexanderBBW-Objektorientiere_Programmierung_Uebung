using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeug
{
    public class Identifizierung
    {
        public string Baujahr { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public string Laufleistung { get; set; }
        public string Kennzeichen { get; set; }
        public string Eigentümer { get; set; }

        public Identifizierung(string Modell, string Eigentümer, string Kennzeichen)
        {
            this.Modell = Modell;
            this.Eigentümer = Eigentümer;
            this.Kennzeichen = Kennzeichen;
        }
        public Identifizierung(string Modell, string Eigentümer, string Kennzeichen, string Baujahr)
        {
            this.Modell = Modell;
            this.Eigentümer = Eigentümer;
            this.Kennzeichen = Kennzeichen;
            this.Baujahr = Baujahr;
        }
        public string erhoeheLaufleistung(string Laufleistung)
        {
            return ("Die Laufleistung beträgt:" + Laufleistung +"Kilometer");
        }
    }
}
