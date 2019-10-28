/* JurassicJava.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item JurassicJava
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the JurassicJava
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
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Leave Room For Cream");
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
        /// Whether or not room should be left for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether or not the coffee is decalf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// The ingredients of the current menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
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
                switch (size)
                {
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                }
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
        /// Leaves room for cream in the drink
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Makes the coffee decaf
        /// </summary>
        public void MakeDecaf()
        {
            this.Decaf = true;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Constructs a new JurassicJava
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            if (Decaf) return size.ToString() + " Decaf Jurassic Java";
            else return size.ToString() + " Jurassic Java";
        }
    }
}
