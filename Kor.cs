using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Kor
    {

        double sugar;
        double atmero;

        public double Sugar
        {
            get => sugar;
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException($"{value} nem lehet körsugara!");


                }
                else
                {

                    sugar = value;

                }
            }
        }
        public double Atmero
        {
            get => atmero;
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException($"{value} nem lehet a kör átmérője!");

                }
                else
                {

                    atmero = value;

                }
            }
        }

        public double getkorTerulet()
        {

            return sugar * sugar * Math.PI;

        }
        public double getkorKerulet()
        {

            return 2 * sugar * Math.PI;

        }

        public Kor(double sugar)
        {

            this.Sugar = sugar;

        }
    }
}
