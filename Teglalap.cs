using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Teglalap
    {

        double Ateglalapoldal;
        double Bteglalapoldal;

        public double Ateglalapoldal1
        {
            get => Ateglalapoldal;
            set
            {
                if (value < 0)
                {

                    Ateglalapoldal = 0;

                }
                else
                {

                    Ateglalapoldal = value;

                }
            }
        }

        public double Bteglalapoldal1
        {
            get => Bteglalapoldal;
            set
            {
                if (value < 0)
                {

                    Bteglalapoldal = 0;

                }
                else
                {

                    Bteglalapoldal = value;

                }
            }
        }

        public double getTeglalapTerulet()
        {

            return Ateglalapoldal * Bteglalapoldal;

        }
        public double getTeglalapKerulet()
        {

            return 2 * Ateglalapoldal + 2 * Bteglalapoldal;

        }

        public Teglalap(double ateglalapoldal, double bteglalapoldal)
        {
            Ateglalapoldal = ateglalapoldal;
            Bteglalapoldal = bteglalapoldal;
        }
    }
}
