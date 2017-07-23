﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 23rd, 2017
 * Description: Took all the parameters of the planet base class and set the local variable _type to it's instance 
 * variable in the constructor.
 * Version: 0.2 - Set the constructor
 */
namespace AbstractPlanets
{
    public class GiantPlanet : Planet , IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _type;
        // CONSTRUCTORS ---------------------------------------------
        /// <summary>
        /// The GiantPlanet Class inherits from the abstract planet class
        /// It implements the interfaces IhasMoons and IHasRings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) :base (name, diameter, mass)
        {
            this._type = type;
        }

        // PUBLIC METHODS
        /// <summary>
        /// This is the HasMoons method
        /// if the mooncount is greater than zero it returns a value of true
        /// if there isn't any moons, it returns false
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
        /// Same for the above method, if there are any rings it returns true, if not then it returns false.
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            if (RingCount > 0)
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