/* VelociWrap.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The menu item VelociWrap and its customizations.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// Whether or not the VelociWrap has dressing.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Whether or not the VelociWrap has lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Whether or not the VelociWrap has cheese.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// The ingredients in the VelociWrap.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new VelociWrap.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Removes the dressing from the VelociWrap.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Removes the lettuce from the VelociWrap.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes the cheese from the VelociWrap.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
