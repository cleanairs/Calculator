using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        public string HoleZahlVomBenutzer()
        {
            Console.Write("Bitte gib eine Zahl ein: ");
            return Console.ReadLine();
        }

        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib +,-,/ oder * ein: ");
            return Console.ReadLine();
        }

        public string WarteAufEndeDurchbenutzer()
        {
            Console.Write("Enter drücken.");
            return Console.ReadLine();
        }

       

        public void GibResultatAus(string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation getroffen.");
                    break;
            }
        }

    }
}