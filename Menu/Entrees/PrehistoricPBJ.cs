/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item PrehistoricPBJ and its customizations.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Whether or not the PrehistoricPBJ has peanut butter.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Whether or not the PrehistoricPBJ has jelly.
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// The ingredients in the PrehistoricPBJ.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new PrehistoricPBJ.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes the peanut butter from the PrehistoricPBJ.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Removes the jelly from the PrehistoricPBJ.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
