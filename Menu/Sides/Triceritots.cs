/* Triceritots.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A class that represents the side item Triceritots.
    /// </summary>
    public class Triceritots : Side
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
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructs a new order of Triceritots.
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}

