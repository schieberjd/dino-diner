/* MezzorellaSticks.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents the side item MezzorellaSticks.
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem
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
                ingredients.Add("Cheese Product");
                ingredients.Add("Breading");
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructs a new order of MezzorellaSticks.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return size.ToString() + " Mezzorella Sticks";
        }
    }
}

