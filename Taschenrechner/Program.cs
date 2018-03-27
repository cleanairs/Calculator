using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleView view = new ConsoleView();
            string erstZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein und bestätige mit Enter:");
            string zweiteZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein und bestätige mit Enter:");
            string operation = view.HoleBenutzerEingabe("Bitte gib +, -, / oder * ein: ");

            // Wandlung string -> int (Text in Ganzzahl)
            double ersteZahlAlsDouble = Convert.ToDouble(erstZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnungsaufruf
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

            // Ausgabe
            view.GibResultatAus(model.Resultat, operation);
            view.HoleBenutzerEingabe("Zum Beenden Enter.");

        }
    }
}
