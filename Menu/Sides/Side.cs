/* Side.cs
 * Author: Nathan Bean
 * Modified by: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The size options for each side.
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    /// <summary>
    /// The abstract class that each side class inherits.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
