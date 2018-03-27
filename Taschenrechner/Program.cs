using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main(string[] args)
        {
            // User Story "Addieren" : Als Benutzer möchte ich den Taschenrechner schnell aufrufen können um mein Resultat zu bekommen.
            string erstZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein und bestätige mit Enter:");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein und bestätige mit Enter:");
            string operation = HoleBenutzerEingabe("Bitte gib +, -, / oder * ein: ");

            // Wandlung string -> int (Text in Ganzzahl)
            double ersteZahlAlsDouble = Convert.ToDouble(erstZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnungsaufruf
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

            // Ausgabe
            GibResultatAus(model.Resultat, operation);
            HoleBenutzerEingabe("Zum beenden Enter drücker!");
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Eingabe = Console.ReadLine();
            return Eingabe;
        }

        static void GibResultatAus(double resultat, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation getroffen.");
                    break;
            }

        }
    }
}