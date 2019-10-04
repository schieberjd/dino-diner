/* MeteorMacAndCheese.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents the side item MeteorMacAndCheese.
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem
    {
        /// <summary>
        /// The size of the item.
        /// </summary>
        private Size size;

        /// <summary>
        /// The ingredients of the current menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
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
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructs a new order of MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return size.ToString() + " Meteor Mac and Cheese";
        }
    }
}

