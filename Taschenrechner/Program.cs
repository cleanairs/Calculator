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
            string operation = HoleBenutzerEingabe("Bitte gib +, -, / oder * ein: ");
            
            // Wandlung string -> int (Text in Ganzzahl)
            //TODO: Auslagern in Methode wenn Struktur umfangereicher geworden ist.
            double ersteZahlAlsDouble = Convert.ToDouble(erstZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);
            double resultat = Berechnung(operation, ersteZahlAlsDouble, zweiteZahlAlsDouble);

            Console.WriteLine("Das Ergebnis lautet: " + resultat);
            HoleBenutzerEingabe("Zum beenden Enter drücker!");
        }

        static double Berechnung(string operation, double ersteZahl, double zweiteZahl)
        {double resultat = 0;
            switch (operation)
            {
                case "+":
                    return ersteZahl + zweiteZahl;
                      break;
                case "-":
                    return ersteZahl - zweiteZahl;
                     break;
                case "*":
                    return ersteZahl * zweiteZahl;
                    break;
                case "/":
                    return ersteZahl / zweiteZahl;
                     break;
                default:
                    Console.WriteLine("Bitte +, /, * oder - eingeben!");
                    break;
            }return resultat;
        }
        private static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Eingabe = Console.ReadLine();
            return Eingabe;
        }
              
        
    }
}
