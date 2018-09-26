using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoftech_gyak2
{
    class Auto
    {
        private string gyarto;
        private string tipus;
        //futási idejű konstans (const az fordítási idejű)
        private readonly int evjarat;

        private string motorTipus;
        private string uzemanyag;
        private double atlagFogyasztas;

        public double AtlagFogyasztas
        {
            get { return atlagFogyasztas; }
            set { atlagFogyasztas = value; }
        }


        public string Uzemanyag
        {
            get { return uzemanyag; }
            set { uzemanyag = value; }
        }


        public string MotorTipus
        {
            get { return motorTipus; }
            set { motorTipus = value; }
        }


        public string Tipus
        {
            get { return tipus; }
            //set { tipus = value; }
        }
        public string Gyarto
        {
            get { return gyarto; }
            //set { gyarto = value; }
        }

        public Auto(string gyarto, string tipus, int evjarat, string motorTipus, string uzemanyag, double atlagFogyasztas)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.motorTipus = motorTipus;
            this.uzemanyag = uzemanyag;
            this.atlagFogyasztas = atlagFogyasztas;

            
        }
        public Auto(string gyarto, string tipus, int evjarat, string motorTipus)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.motorTipus = motorTipus;
            this.uzemanyag = "benzin";

            switch (motorTipus)
            {
                case "1.4":
                    this.atlagFogyasztas = 6.5;
                    break;
                case "1.8":
                    this.atlagFogyasztas = 7.5;
                    break;
                case "2.0":
                    this.atlagFogyasztas = 8;
                    break;

                default:
                    break;
            }
        }

        public void MotorCsere(string motorTipus, string uzemanyag, double atlagFogyasztas)
        {
            this.motorTipus = motorTipus;
            this.uzemanyag = uzemanyag;
            this.atlagFogyasztas = atlagFogyasztas;

        }
        public double Fogyasztas(double uzemanyag, int tavolsag)
        {
            return uzemanyag / tavolsag * 100;
        }

        public bool AtlagFogyasztasOsszehasonlito(double uzemanyag, int tavolsag)
        {
            return Fogyasztas(uzemanyag, tavolsag) <= atlagFogyasztas;
        }
        /// <summary>
        /// uzemanyag koltseg kiszamitasa
        /// </summary>
        /// <param name="tavolsag"> távolság km-ben</param>
        /// <param name="uzemanyag">uzemanyag literenkénti ára ft-ban</param>
        /// <returns>uzemanyag osszkoltseg</returns>
        public int UzemanyagKoltsegSzamitas(int tavolsag, int uzemanyag)
        {
            return (int)(atlagFogyasztas * tavolsag * uzemanyag / 100);
        }
        public override string ToString()
        {
            return "Auto: "
                + Gyarto + ", "
                + Tipus + ", "
                + evjarat + ", "
                + MotorTipus + ", "
                + Uzemanyag + ", "
                + AtlagFogyasztas;
        }
    }
}
