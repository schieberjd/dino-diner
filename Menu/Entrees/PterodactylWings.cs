/* PterodactylWings
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item Pterodactyl Wings and its customizations.
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// The price of the Pterodactyl Wings.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The number of calories in the Pterodactyl Wings.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients in the Pterodactyl Wings.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new order of Pterodactyl Wings.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
