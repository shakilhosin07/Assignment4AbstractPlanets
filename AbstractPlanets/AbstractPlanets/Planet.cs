using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 23rd, 2017
 * Description: Overrode the tostring method to return name diameter and mass of a planet.
 * Version: 0.5 - overrode the tostring method, completed the abstract class planet.
 */
namespace AbstractPlanets
{
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        // PUBLIC PROPERTIES
        /// <summary>
        /// Set all the public properties
        /// Properties that are readonly have only a getter and properties can be initialized to another value
        /// have a getter and setter
        /// </summary>
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
           get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
            
        }
        // CONSTRUCTORS ---------------------------------------------
        /// <summary>
        ///  take name, diameter and mass as local variables and 
        /// set therelated instancevariables(_name, _diameter and_mass)to their values
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // OVERRIDE METHOD
        /// <summary>
        /// Tried the output string method instead of the string.format method (will see if this works)
        /// </summary>
        /// <returns> Name, Diameter, and Mass</returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "===========================================================\n";
            outputString += "Planet Name: " + this.Name + "Diameter: " + this.Diameter + "Mass: " + this.Mass;
            outputString += "===========================================================\n";

            return outputString;
        }


    }
}