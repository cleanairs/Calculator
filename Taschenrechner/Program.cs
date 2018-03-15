using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren" : Als Benutzer möchte ich den Taschenrechner schnell aufrufen können um mein Resultat zu bekommen.
            string ersterSummand = HoleSummanden("Bitte gib die erste Zahl ein und bestätige mit Enter:");
            string zweiterSummand = HoleSummanden("Bitte gib die zweite Zahl ein und bestätige mit Enter:");

            // Wandlung string -> int (Text in Ganzzahl)
            //TODO: Auslagern in Methode wenn Struktur umfangereicher geworden ist.
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl );
            double differenz = Subtrahiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            //Ausgabe
            Console.WriteLine("Die Summe ist: " + summe);
            Console.WriteLine("Die Differenz ist: " + differenz);
            WarteAufBenutzerEingabe();
        }
        
        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("Enter drücken bitte. :)");
            Console.ReadLine();
        }

        static double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;
            return differenz;
        }
        
        static double Addiere(double ersterSummandAlsZahl, double zweiterSummandAlsZahl)
        {
           double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;
           return summe;
        }

        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();
            return summand;
        }
    }
}
