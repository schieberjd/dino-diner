/* Water.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item Water
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// Whether or not the water has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
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
