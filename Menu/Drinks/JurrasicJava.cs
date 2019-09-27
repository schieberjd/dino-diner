/* JurrasicJava.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The class for the menu item JurrasicJava
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// The size of the JurrasicJava
        /// </summary>
        private Size size;

        /// <summary>
        /// Whether or not room should be left for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether or not the coffee is decalf
        /// </summary>
        public bool Decalf { get; set; } = false;

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
        /// Constructs a new JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
        }
    }
}
