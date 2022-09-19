using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Negyszog
    {

        double Anegyszogoldal;

        public double Anegyszogoldal1
        {
            get => Anegyszogoldal;
            set
            {
                if (value < 0)
                {

                    Anegyszogoldal = 0;

                }
                else
                {

                    Anegyszogoldal = value;

                }
            }
        }

        public double getNegyszogTerulet()
        {

            return Anegyszogoldal * Anegyszogoldal;

        }
        public double getNegyszogKerulet()
        {

            return 4 * Anegyszogoldal;

        }

        public Negyszog(double anegyszogoldal)
        {
            Anegyszogoldal = anegyszogoldal;
        }

    }
}
