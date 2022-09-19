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

                    throw new ArgumentException($"{value} nem lehet A-oldala a négyszögnek!");

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
            Anegyszogoldal1 = anegyszogoldal;
        }

    }
}
