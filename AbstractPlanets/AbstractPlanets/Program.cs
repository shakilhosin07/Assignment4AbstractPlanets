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
 * Version: 0.2 - Created an object of the GiantPlanet class and played with the tostring method in the planet class.
 */
namespace AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet Shaktopia = new GiantPlanet("Shaktopia", 200000, 10000000020, "gas");
            Console.WriteLine(Shaktopia);
        }
    }
}
