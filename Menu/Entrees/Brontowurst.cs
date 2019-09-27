/* Brontowurst.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item Brontowurst and its customizations.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Whether or not the Brontowurst has a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Whether or not the Brontowurst has peppers.
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Whether or not the Brontowurst has onion.
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// The ingredients in the Brontowurst.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new Brontowurst.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes the bun from the Brontowurst.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the peppers from the Brontowurst.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes the onion from the Brontowurst.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
