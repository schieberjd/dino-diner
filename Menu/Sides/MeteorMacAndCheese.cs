/* MeteorMacAndCheese.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A class that represents the side item MeteorMacAndCheese.
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// The size of the item.
        /// </summary>
        private Size size;

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
            this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
        }
    }
}

