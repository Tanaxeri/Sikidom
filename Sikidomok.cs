using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Sikidomok
    {
        /* A kör objektum létrehozása és jellemzői kiíratása 
         */



        static void Main(string[] args)
        {
            /* Kör */
            Kor kor = new Kor(1.1);
            Console.WriteLine($"A kör sugara: {kor.Sugar}, kerülete: {kor.getkorKerulet():N2}, területe: {kor.getkorTerulet():N2}");

            kor.Sugar = 3.3;
            Console.WriteLine($"A kör sugara: {kor.Sugar}, kerülete: {kor.getkorKerulet():N2}, területe: {kor.getkorTerulet():N2}");

            kor.Sugar = 4.1;
            Console.WriteLine($"A kör sugara: {kor.Sugar}, kerülete: {kor.getkorKerulet():N2}, területe: {kor.getkorTerulet():N2}");

            kor.Sugar = -5;
            Console.WriteLine($"A kör sugara: {kor.Sugar}, kerülete: {kor.getkorKerulet():N2}, területe: {kor.getkorTerulet():N2}");

            /* Háromszög */
            Haromszog haromszog = new Haromszog(3.3, 2.1, 4.4);
            Console.WriteLine($"A háromszög oldalai A-oldal: {haromszog.Aharomszogoldal}, B-oldal: {haromszog.Bharomszogoldal}, C-oldal: {haromszog.Charomszogoldal}, kerülete: {haromszog.getharomszogKerulet():N2}, területe: {haromszog.getharomszogTerulet():N2}");
            haromszog.Aharomszogoldal = -3; haromszog.Bharomszogoldal = -1; haromszog.Charomszogoldal = -8;
            Console.WriteLine($"A háromszög oldalai A-oldal: {haromszog.Aharomszogoldal}, B-oldal: {haromszog.Bharomszogoldal}, C-oldal: {haromszog.Charomszogoldal}, kerülete: {haromszog.getharomszogKerulet():N2}, területe: {haromszog.getharomszogTerulet():N2}");

            /*Ötszög*/
            Otszog otszog = new Otszog(5, 1);
            Console.WriteLine($"A ötszög oldala: {otszog.Aotszogoldal1}, sugara: {otszog.Rsugarot}, kerülete: {otszog.getOtszogKerulet():N2}, területe: {otszog.getOtszogTerulet():N2}");
            otszog.Aotszogoldal1 = -3; otszog.Rsugarot = -4;
            Console.WriteLine($"A ötszög oldala: {otszog.Aotszogoldal1}, sugara: {otszog.Rsugarot}, kerülete: {otszog.getOtszogKerulet():N2}, területe: {otszog.getOtszogTerulet():N2}");

            /*Négyszög*/
            Negyszog negyszog = new Negyszog(10);
            Console.WriteLine($"A négyszög oldala: {negyszog.Anegyszogoldal1}, kerülete: {negyszog.getNegyszogKerulet():N2}, területe: {negyszog.getNegyszogTerulet():N2}");
            negyszog.Anegyszogoldal1 = - 16;
            Console.WriteLine($"A négyszög oldala: {negyszog.Anegyszogoldal1}, kerülete: {negyszog.getNegyszogKerulet():N2}, területe: {negyszog.getNegyszogTerulet():N2}");

            /*Téglalap*/
            Teglalap teglalap = new Teglalap(14, 7);
            Console.WriteLine($"A téglalap A-Oldala: {teglalap.Ateglalapoldal1} , B-Oldala: {teglalap.Bteglalapoldal1}, kerülete: {teglalap.getTeglalapKerulet():N2}, területe: {teglalap.getTeglalapTerulet():N2}");
            teglalap.Ateglalapoldal1 = -14; teglalap.Bteglalapoldal1 = -7;
            Console.WriteLine($"A téglalap A-Oldala: {teglalap.Ateglalapoldal1} , B-Oldala: {teglalap.Bteglalapoldal1}, kerülete: {teglalap.getTeglalapKerulet():N2}, területe: {teglalap.getTeglalapTerulet():N2}");

            Console.WriteLine("\nProgram vége.");
            Console.ReadKey();

        }
    }
}
