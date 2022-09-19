using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Otszog
    {

        double Aotszogoldal;
        double rsugarot;

        public double Aotszogoldal1
        {
            get => Aotszogoldal;
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException($"{value} nem lehet A-oldala az ötszögnek!");

                }
                else
                {

                    Aotszogoldal = value;

                }
            }
        }
        public double Rsugarot
        {
            get => rsugarot;
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException($"{value} nem lehet sugara a ötszögnek!");

                }
                else
                {

                    rsugarot = value;

                }
            }
        }

        public double getOtszogTerulet()
        {

            return 5 * (Aotszogoldal * rsugarot) / 2 ;

        }
        public double getOtszogKerulet()
        {

            return 5 * Aotszogoldal;

        }

        public Otszog(double aotszogoldal, double rsugarot)
        {
            Aotszogoldal1 = aotszogoldal;
            this.Rsugarot = rsugarot;
        }
    }
}
