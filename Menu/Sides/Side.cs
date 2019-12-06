/* Side.cs
 * Author: Nathan Bean
 * Modified by: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

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

        /// <summary>
        /// Makes the item small
        /// </summary>
        public abstract void MakeSmall();

        /// <summary>
        /// Makes the item medium
        /// </summary>
        public abstract void MakeMedium();

        /// <summary>
        /// Makes the item large
        /// </summary>
        public abstract void MakeLarge();

        /// <summary>
        /// Makes the side medium for the website
        /// </summary>
        /// <returns>The medium side</returns>
        public abstract Side Medium();

        /// <summary>
        /// Makes the side large for the website
        /// </summary>
        /// <returns>The large side</returns>
        public abstract Side Large();

        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;
    }
}
