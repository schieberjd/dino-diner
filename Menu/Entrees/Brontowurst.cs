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
        private bool Bun = true;
        /// <summary>
        /// Whether or not the Brontowurst has peppers.
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// Whether or not the Brontowurst has onion.
        /// </summary>
        private bool Onion = true;

        /// <summary>
        /// The ingredients in the Brontowurst.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
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
            this.Bun = false;
        }

        /// <summary>
        /// Removes the peppers from the Brontowurst.
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
        }

        /// <summary>
        /// Removes the onion from the Brontowurst.
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }
    }
}
