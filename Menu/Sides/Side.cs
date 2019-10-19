/* Side.cs
 * Author: Nathan Bean
 * Modified by: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract class that each side class inherits.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem
    {

        /// <summary>
        /// Gets the description of the order item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets the special instructions for a menu item
        /// </summary>
        public abstract string[] Special { get; }

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
        public abstract Size Size { get; set; }
    }
}
