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

                    Aotszogoldal = 0;

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

                    rsugarot = 0;

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
            Aotszogoldal = aotszogoldal;
            this.rsugarot = rsugarot;
        }
    }
}
