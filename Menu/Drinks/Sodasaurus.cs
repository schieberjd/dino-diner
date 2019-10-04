/* Sodasaurus.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item Sodasaurus
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// The size of the Sodasaurus
        /// </summary>
        private Size size;

        /// <summary>
        /// The flavor of the Sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// The ingredients of the current menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
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
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructs a new sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return size.ToString() + " " + Flavor.ToString() + " Sodasaurus";
        }
    }
}
