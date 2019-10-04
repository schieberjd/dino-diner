/* JurassicJava.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item JurassicJava
    /// </summary>
    public class JurassicJava : Drink, IMenuItem
    {
        /// <summary>
        /// The size of the JurassicJava
        /// </summary>
        private Size size;

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
        /// Leaves room for cream in the drink
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
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
