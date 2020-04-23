using System;
using System.Collections.Generic;
namespace Azubis
{
    class IDGenerierung
    {
       static  List<string> zeichenListe = new List<string>
        { 
            "1","2","3","4","5","6","7","8","9","0","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };
       static  Random randomNumb = new Random();
        public static string Generierung()
        {
            string ID = "";
            for (int i = 1; i < 9; i++)
            {
               int zahl = randomNumb.Next(0,zeichenListe.Count);
                var newString = zeichenListe[zahl];
                if (!int.TryParse(newString, out int numb) && randomNumb.Next(0,2)==1)
                {
                    newString = newString.ToLower();
                }
                ID += newString;

                if (i == 8 && ÜberprüfeID(ID))
                {
                    i = 0;
                }

            }
            return ID;
        }
        public static bool ÜberprüfeID(string ID)
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
