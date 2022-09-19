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

                    throw new ArgumentException($"{value} nem lehet A-oldala a háromszögnek!");

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

                    throw new ArgumentException($"{value} nem lehet B-oldala a háromszögnek!");

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

                    throw new ArgumentException($"{value} nem lehet C-oldala a háromszögnek!");

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
            this.Aharomszogoldal = aharomszogoldal;
            this.Bharomszogoldal = bharomszogoldal;
            this.Charomszogoldal = charomszogoldal;
        }
    }
}
