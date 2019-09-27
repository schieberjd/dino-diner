/* SteakosaurusBurger.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item Steakosaurus Burger and its customizations.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Whether or not the Steakosaurus Burger has a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Whether or not the Steakosaurus Burger has pickle.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Whether or not the Steakosaurus Burger has mustard.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Whether or not the Steakosaurus Burger has ketchup.
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// The ingredients in the Steakosaurus Burger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                if (ketchup) ingredients.Add("Ketchup");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new Steakosaurus Burger.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Removes the bun from the Steakosaurus Burger.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the pickle from the Steakosaurus Burger.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes the ketchup from the Steakosaurus Burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes the mustard from the Steakosaurus Burger.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
