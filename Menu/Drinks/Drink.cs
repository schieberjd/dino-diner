/* Drink.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An abstract class that all drinks derive from.
    /// </summary>
    public abstract class Drink : IMenuItem
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
        public virtual List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets or sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Sets the ice property to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
