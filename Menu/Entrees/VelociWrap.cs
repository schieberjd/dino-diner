/* VelociWrap.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item VelociWrap and its customizations.
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// The price of the VelociWrap.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The number of calories in the VelociWrap.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Whether or not the VelociWrap has dressing.
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// Whether or not the VelociWrap has lettuce.
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Whether or not the VelociWrap has cheese.
        /// </summary>
        private bool Cheese = true;

        /// <summary>
        /// The ingredients in the VelociWrap.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
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
            this.Dressing = false;
        }

        /// <summary>
        /// Removes the lettuce from the VelociWrap.
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// Removes the cheese from the VelociWrap.
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }
    }
}
