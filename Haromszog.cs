using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Haromszog
    {

        double aharomszogoldal;
        double bharomszogoldal;
        double charomszogoldal;

        public double Aharomszogoldal
        {
            get => aharomszogoldal;
            set
            {
                if (value < 0)
                {

                    aharomszogoldal = 0;

                }
                else
                {

                    aharomszogoldal = value;

                }
            }
        }
        public double Bharomszogoldal
        {
            get => bharomszogoldal;
            set
            {
                if (value < 0)
                {

                    bharomszogoldal = 0;

                }
                else
                {

                    bharomszogoldal = value;

                }
            }
        }
        public double Charomszogoldal
        {
            get => charomszogoldal;
            set
            {
                if (value < 0)
                {

                    charomszogoldal = 0;

                }
                else
                {

                    charomszogoldal = value;

                }
            }
        }



        public double getharomszogTerulet()
        {
            double s = (aharomszogoldal + bharomszogoldal + charomszogoldal) / 2;
            double t = Math.Sqrt(s * (s - aharomszogoldal) * (s - bharomszogoldal) * (s - charomszogoldal));

            return t;

        }
        public double getharomszogKerulet()
        {

            return aharomszogoldal + bharomszogoldal +charomszogoldal;

        }

        public Haromszog(double aharomszogoldal, double bharomszogoldal, double charomszogoldal)
        {
            this.aharomszogoldal = aharomszogoldal;
            this.bharomszogoldal = bharomszogoldal;
            this.charomszogoldal = charomszogoldal;
        }
    }
}
