using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Shakil Hosin
 * Student Number: 300922629
 * Date: July 23rd, 2017
 * Description: This is the Driver class
 * Version: 1.0 - Finalized the output of the driver class.
 */
namespace AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================\n");
            Console.WriteLine("Shakil Hosin -- 300922629 -- Assignment 4 -- Abstract Planets");
            Console.WriteLine("===========================================================\n");

            //Giant Planet Object
            GiantPlanet Shaktopia = new GiantPlanet("Shaktopia", 200000, 10000000020, "gas");
            Shaktopia.OrbitalPeriod = 95;
            Shaktopia.RotationPeriod = 762;
            Shaktopia.MoonCount = 5;
            Shaktopia.RingCount = 0;
            Console.WriteLine("STATS");
            Console.WriteLine(Shaktopia);
            Console.WriteLine("Has Moons?");
            Console.WriteLine(Shaktopia.HasMoons() ? "Yes" : "No");
            Console.WriteLine("Has Rings?");
            Console.WriteLine(Shaktopia.HasRings() ? "Yes" : "No");
            Console.WriteLine("===========================================================");

            //Terrestrial Planet Object
            TerrestrialPlanet Torontoplo = new TerrestrialPlanet("Torontoplo", 28060708, 912827633674746434.393, true);
            Torontoplo.OrbitalPeriod = 18;
            Torontoplo.RotationPeriod = 190;
            Torontoplo.MoonCount = 0;
            Torontoplo.RingCount = 1;
            Console.WriteLine();
            Console.WriteLine("STATS");
            Console.WriteLine(Torontoplo);
            Console.WriteLine("Has Moons?");
            Console.WriteLine(Torontoplo.HasMoons() ? "Yes" : "No");
            Console.WriteLine("Habitable?");
            Console.WriteLine(Torontoplo.Habitable() ? "Yes" : "No");
            Console.WriteLine("===========================================================");
            WaitForKey();

        }
        static void WaitForKey()
        {

            Console.ReadKey();
        }
    }
}
