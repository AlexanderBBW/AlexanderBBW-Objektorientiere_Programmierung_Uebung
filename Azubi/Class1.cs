using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azubi
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
        public int berechneAlter (DateTime Geburtsdatum)
        {
            int Jahr = DateTime.Now.Year - Geburtsdatum.Year;
                if (DateTime.Now.CompareTo(Geburtsdatum) < 0) { Jahr--; }
            return Jahr;
        }
    }
}
