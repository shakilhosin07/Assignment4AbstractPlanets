using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Student Number: 300922629
 * Date: July 23rd, 2017
 * Description: This is the IHabitable interface
 * Version: 0.1 - Created the IHabitable interface
 */
namespace AbstractPlanets
{
    /// <summary>
    /// implements the habitable method used in the subclasses.
    /// </summary>
    public interface IHabitable
    {
        bool Habitable();
    }
}