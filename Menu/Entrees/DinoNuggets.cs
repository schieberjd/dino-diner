/* DinoNuggets.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item Dino Nuggets and its customizations.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// The price of the Dino Nuggets.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The number of calories in the Dino Nuggets.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The amount of additional nuggets ordered on top of six.
        /// </summary>
        private int AdditionalNuggets;

        /// <summary>
        /// The ingredients in the Dino Nuggets.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                for (int i = 0; i < this.AdditionalNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new order of Dino Nuggets.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// Adds an additional nugget to the order.
        /// </summary>
        public void AddNugget()
        {
            this.AdditionalNuggets++;
            this.Price += .25;
            this.Calories += 59;
        }
    }
}
