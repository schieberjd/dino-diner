/* Drink.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An abstract class that all drinks derive from.
    /// </summary>
    public abstract class Drink : IMenuItem, INotifyPropertyChanged, IOrderItem
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
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets or sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special Properties
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of propety changes
        /// </summary>
        /// <param name="propertyName">The property name</param>
        public virtual void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the ice property to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }

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
    }
}
