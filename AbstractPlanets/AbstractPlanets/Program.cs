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
 * Version: 0.3 - Implementing the interfaces we created for the planets.
 */
namespace AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Giant Planet Object
            GiantPlanet Shaktopia = new GiantPlanet("Shaktopia", 200000, 10000000020, "gas");
            Shaktopia.OrbitalPeriod = 95;
            Shaktopia.RotationPeriod = 762;
            Shaktopia.MoonCount = 5;
            Console.WriteLine("Has Moons?");
            Console.WriteLine(Shaktopia.HasMoons() ? "Yes" : "No");
            Console.WriteLine("Has Rings?");
            Console.WriteLine(Shaktopia.HasRings() ? "Yes" : "No");
            Console.WriteLine();
            Console.WriteLine("STATS");
            Console.WriteLine(Shaktopia);

            //Terrestrial Planet Object
            TerrestrialPlanet Torontoplo = new TerrestrialPlanet("earth", 28060708, 912827633674746434.393, true);
            Torontoplo.OrbitalPeriod = 18;
            Torontoplo.RotationPeriod = 190;
            Torontoplo.MoonCount = 0;
            Console.WriteLine(Torontoplo);
            WaitForKey();

        }
        static void WaitForKey()
        {

            Console.ReadKey();
        }
    }
}
