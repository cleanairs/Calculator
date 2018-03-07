using System;

namespace Taschenrechner_Iteration_1
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
            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            Console.WriteLine("Gewandelter erster Summand: {0}", ersterSummandAlsZahl);
            Console.WriteLine("Gewandelter zweiter Summand: {0}", zweiterSummandAlsZahl);

            //Berechnung
            int Ergebnis = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabe
            Console.WriteLine("Das Ergebnis lautet: " + Ergebnis);
            Console.WriteLine("Enter drücken bitte. :)");




            Console.ReadLine();


        }
    }
}
