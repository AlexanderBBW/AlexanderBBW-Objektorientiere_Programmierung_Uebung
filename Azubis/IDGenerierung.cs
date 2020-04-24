using System;
using System.Collections.Generic;
namespace Azubis
{
    class IDGenerierung
    {
       static  List<string> zeichenListe = new List<string> // Liste mit möglichen ID Zeichen
        { 
            "1","2","3","4","5","6","7","8","9","0","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };
       static  Random randomNumb = new Random(); //instantiert eine randomnummer 
        public static string Generierung()
        {
            string ID = ""; 
            for (int i = 1; i < 9; i++) //lässt 9 Zeichen aus der Liste ziehen
            {
               int zahl = randomNumb.Next(0,zeichenListe.Count);
                var newString = zeichenListe[zahl];
                if (!int.TryParse(newString, out int numb) && randomNumb.Next(0,2)==1)
                {
                    newString = newString.ToLower(); //verwandelt die Zeichen ggf. in kleinbuchstaben
                }
                ID += newString;

                if (i == 8 && ÜberprüfeID(ID)) //schaut ob es die ID schon gibt wenn ja wird i zurückgesetzt und er findet ne neue ID raus
                {
                    i = 0;
                }

            }
            return ID;
        }
        public static bool ÜberprüfeID(string ID) //Hier findet die Überprüfung der ID statt
        {
            bool nichtRichtig = false;
            foreach (var item in AzubiVerwaltung.MeineAzubiListe)
            {
                if (ID == item.AzubiNummer)
                {
                    nichtRichtig = true;
                    break;
                }
            }
            return nichtRichtig;
        }
    }

}
