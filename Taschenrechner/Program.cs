using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
        // User Story "Addieren" : Als Benutzer möchte ich den Taschenrechner schnell aufrufen können um mein Resultat zu bekommen.
        string erstZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein und bestätige mit Enter:");
        string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein und bestätige mit Enter:");
        string operation = HoleBenutzerEingabe("Bitte gib für Addition + und für Substraktion - ein: ");
            
        // Wandlung string -> int (Text in Ganzzahl)
        //TODO: Auslagern in Methode wenn Struktur umfangereicher geworden ist.
        double ersteZahlAlsDouble = Convert.ToDouble(erstZahlAlsString);
        double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

        //Berechnung            
        if (operation == "+")
	    {
            double summe = Addiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
	    }else
	    {
            double differenz = Subtrahiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
	    }
            
            double differenz = Subtrahiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);

        //Ausgabe
        Console.WriteLine("Die Summe ist: " + summe);
        Console.WriteLine("Die Differenz ist: " + differenz);
        HoleBenutzerEingabe("Enter drücken bitte. :)");
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

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Eingabe = Console.ReadLine();
            return Eingabe;
        }
    }
}
