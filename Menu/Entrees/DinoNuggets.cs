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
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// The amount of additional nuggets ordered on top of six.
        /// </summary>
        private int additionalNuggets;

        /// <summary>
        /// The ingredients in the Dino Nuggets.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                for (int i = 0; i < this.additionalNuggets; i++)
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
            this.additionalNuggets++;
            this.Price += .25;
            this.Calories += 59;
        }
    }
}
