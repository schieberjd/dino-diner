/* Water.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item Water
    /// </summary>
    public class Water : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        //Backing variable
        private Size size;

        /// <summary>
        /// Whether or not the water has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets the description of the menu item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special instructions for a menu item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special Properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of propety changes
        /// </summary>
        /// <param name="propertyName">The property name</param>
        public override void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Gets the ingredients in water
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or sets the size of the item and the corresponding values
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Makes the item small
        /// </summary>
        public override void MakeSmall()
        {
            this.Size = Size.Small;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item medium
        /// </summary>
        public override void MakeMedium()
        {
            this.Size = Size.Medium;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item large
        /// </summary>
        public override void MakeLarge()
        {
            this.Size = Size.Large;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item medium for the website
        /// </summary>
        /// <returns>The medium item</returns>
        public override Drink Medium()
        {
            this.Size = Size.Medium;
            return this;
        }

        /// <summary>
        /// Makes the item large for the website
        /// </summary>
        /// <returns>The large item</returns>
        public override Drink Large()
        {
            this.Size = Size.Large;
            return this;
        }

        /// <summary>
        /// Constructs a new Water
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
