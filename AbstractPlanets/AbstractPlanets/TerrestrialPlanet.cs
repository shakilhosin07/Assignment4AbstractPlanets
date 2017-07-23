using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 23rd, 2017
 * Description: This is the TerrestrialPlanet class
 * Version: 0.3 - completed the TerrestrialPlanet class and set the parameters to that of the base class as well as
 * setting the local variable _oxygen to the instance variable. Then created the methods to determine if it has moons 
 * or oxygen.
 */
namespace AbstractPlanets
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private bool _oxygen;
        // PUBLIC PROPERTIES

        // CONSTRUCTORS ---------------------------------------------
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        /// <summary>
        /// If the mooncount is greater than zero, then return a value of true
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// The habitable method returns a value of true if the oxygen instance variable is set to true. 
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}