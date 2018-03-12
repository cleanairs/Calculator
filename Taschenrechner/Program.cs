using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren" : Als Benutzer möchte ich den Taschenrechner schnell aufrufen können um mein Resultat zu bekommen.
            Console.Write("Bitte gib die erste Zahl ein und bestätige mit Enter:");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib die zweite Zahl ein und bestätige mit Enter:");
            string zweiterSummand = Console.ReadLine();

            // Wandlung string -> int (Text in Ganzzahl)
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);
             
            //Berechnung
            double Ergebnis = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabevbnvbn
            Console.WriteLine("Das Ergebnis lautet: " + Ergebnis);
            Console.WriteLine("Enter drücken bitte. :)");

            Console.ReadLine();


        }
    }
}
