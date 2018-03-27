﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Berechne(string operation, double ersteZahl, double zweiteZahl)
        {
            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;
            }

            return resultat;
        }

            private double Addiere(double ersterSummand, double zweiterSummand)
            {
                double summe = ersterSummand + zweiterSummand;

                return summe;
            }

            private double Subtrahiere(double minuend, double subtrahent)
            {
                double differenz = minuend - subtrahent;

                return differenz;
            }

            private double Dividiere(double dividend, double divisor)
            {
                return dividend / divisor;
            }

            private double Multipliziere(double multiplikator, double multiplikand)
            {
                return multiplikator * multiplikand;
            }
    }
}

