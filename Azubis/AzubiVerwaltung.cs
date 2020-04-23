using System;
using System.Collections.Generic;
namespace Azubis
{
    class AzubiVerwaltung
    {
        public static List<Azubi> MeineAzubiListe = new List<Azubi>(); //Erstellen der Liste wo die Azubis eingefügt werden bzw. gespeichert werden
        public AzubiVerwaltung()
        {
            AngabenAuswahl(); //Konstruktor damit Die Methode wenn sie in der main aufgerufen wird ausgeführt wird
        }
        protected void AngabenAuswahl() //Auswahl ob die Azubis angezeigt werden sollen 
        {
            while (true)
            {
                Console.WriteLine("0 Zeigt alle aktullen Azubis an und 1 lässt Sie einen neuen angeben!");
                Console.WriteLine("2 zum beenden des Programmes --> Löscht alle Azubis!");
                Console.WriteLine("3 um die AzubisListe in eine txt Datei zu schreiben!");
                switch (Console.ReadLine())
                {
                    case "0":
                        AzubiAnzeigen();
                        break;
                    case "1":
                        AzubiEingabe();
                        break;
                    case "2":
                        Environment.Exit(2);
                        break;
                    case "3":
                        AusDrücken();
                        break;
                }
            }       
        }
        private int InputNumb()
        {
            int Numb = 0;
            while (true)
            {
                Console.WriteLine("Wie viele Azubis müssen Sie von Ihrem Chef aus anlegen?");
                var iEingabe = Console.ReadLine();
                if (int.TryParse(iEingabe, out Numb))
                {
                    break;
                }
            }
            return Numb;           
        }
        protected void AzubiEingabe()
        {
            var Input = InputNumb();
            string Nachname = "";
            string Vorname = "";
            for (int i = 0; i < Input; i++)
            {
                while (true)
                {
                    Console.WriteLine("Bitte geben Sie den Nachnamen an!");
                    Nachname = Console.ReadLine(); //Eingabe Nachname
                    Console.WriteLine("Bitte geben Sie den Vornamen an!");
                    Vorname = Console.ReadLine(); //Eingabe Vorname
                    if (!NamensPruefung(Nachname, Vorname))
                    {
                        break;
                    }
                }
                Console.WriteLine("Bitte geben Sie das Geburtsdatum an!");
                var GeburtsDatum = DateTime.Now;
                while (true)
                {
                    try
                    {
                        GeburtsDatum = Convert.ToDateTime(Console.ReadLine()); //Eingabe des Datums und umconvertierung
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Falsche Eingabe, geben Sie ein richtiges Datum an z.B. 09.02.2001");
                    }
                }                      
                Azubi MeinAzubi = new Azubi(Nachname, Vorname, GeburtsDatum);
                MeineAzubiListe.Add(MeinAzubi); //Fügt den Azubi zur Liste hinzu               
            }
        }
        public void AzubiAnzeigen()
        {
            foreach (var item in MeineAzubiListe)
            {
                item.gibSteckbriefAus();
            }
        }
        public void AusDrücken()
        {
            System.IO.TextWriter tw = new System.IO.StreamWriter("Azubi_Ausgabe.txt");
            foreach (var item in MeineAzubiListe)
            {
                tw.WriteLine(item.Nachname + item.Vorname + item.Geburtsdatum + item.AzubiNummer);
            }
            tw.Flush();
            tw.Close();
        }
        public bool NamensPruefung(string nachname, string vorname)
        {
            var istbool = false;
            var newString = "";
            foreach (var item in nachname)
            {
                newString = item.ToString();
                if (int.TryParse(newString, out int numb))
                {
                    istbool = true;
                    break;
                }
            }
            foreach (var item in vorname)
            {
                newString = item.ToString();
                if (int.TryParse(newString, out int numb))
                {
                    istbool = true;
                    break;
                }
            }
            return istbool;
        }
    }
}