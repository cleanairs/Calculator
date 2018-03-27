using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main(string[] args)
        {
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            string erstZahlAlsString = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVomBenutzer();
            

            // Wandlung string -> int (Text in Ganzzahl)
            double ersteZahlAlsDouble = Convert.ToDouble(erstZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnungsaufruf
            model.Berechne(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

            // Ausgabe
            view.GibResultatAus(operation);
            view.WarteAufEndeDurchbenutzer();

        }
    }
}
