﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;
        }

        public void Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            switch (operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;
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

