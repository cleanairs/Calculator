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

            //Berechnung            
            double resultat;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
                    Console.WriteLine("Die Summe ist: " + resultat);
                    break;
                case "-":
                    resultat = Subtrahiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
                    Console.WriteLine("Die Differenz ist: " + resultat);
                    break;
                case "*":
                    resultat = Multipliziere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
                    Console.WriteLine("Das Produkt ist: " + resultat);
                    break;
                case "/":
                    resultat = Dividiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
                    Console.WriteLine("Der Quotient ist: " + resultat);
                    break;
                default:
                    Console.WriteLine("Bitte +, /, * oder - eingeben!");
                    break;
            }


        /*    if (operation == "+")
	    {
            resultat = Addiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
            Console.WriteLine("Die Summe ist: " + resultat);
            }
        else if (operation == "-")
            {
            resultat = Subtrahiere(ersteZahlAlsDouble, zweiteZahlAlsDouble);
            Console.WriteLine("Die Differenz ist: " + resultat);
            }
        else if (true)
            {

            }
        else
	        {
            Console.WriteLine("Bitte + oder - eingeben!");
            }
        */

        HoleBenutzerEingabe("Zum beenden Enter drücker!");
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
        static double Multipliziere(double ersterMultiplikator, double zweiterMultiplikator)
        {
            double produkt = ersterMultiplikator * zweiterMultiplikator;
            return produkt;
        }
        public static double Dividiere(double ersterTeiler, double zweiterTeiler)
        {
            double quotient = ersterTeiler / zweiterTeiler;
            return quotient;
        }
        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Eingabe = Console.ReadLine();
            return Eingabe;
        }
    }
}
