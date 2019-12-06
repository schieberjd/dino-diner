/* Triceritots.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents the side item Triceritots.
    /// </summary>
    public class Triceritots : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the item.
        /// </summary>
        private Size size;

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
                return special.ToArray();
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special Properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of propety changes
        /// </summary>
        /// <param name="propertyName">The property name</param>
        public void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// The ingredients of the current menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or sets the size of the item and the corresponding values.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                }
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
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item medium
        /// </summary>
        public override void MakeMedium()
        {
            this.Size = Size.Medium;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item large
        /// </summary>
        public override void MakeLarge()
        {
            this.Size = Size.Large;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item medium for the website
        /// </summary>
        /// <returns>The medium item</returns>
        public override Side Medium()
        {
            this.Size = Size.Medium;
            return this;
        }

        /// <summary>
        /// Makes the item large for the website
        /// </summary>
        /// <returns>The large item</returns>
        public override Side Large()
        {
            this.Size = Size.Large;
            return this;
        }

        /// <summary>
        /// Constructs a new order of Triceritots.
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return size.ToString() + " Triceritots";
        }
    }
}

