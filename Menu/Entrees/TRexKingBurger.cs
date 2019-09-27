/* TRexKingBurger.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The menu item T-Rex King Burger and its customizations.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Whether or not the T-Rex King Burger has a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has tomato.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has onion.
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has pickle.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has mustard.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has mayo.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// The ingredients in the T-Rex King Burger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new T-Rex King Burger.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Removes the bun from the T-Rex King Burger.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the lettuce from the T-Rex King Burger.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes the tomato from the T-Rex King Burger.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Removes the onion from the T-Rex King Burger.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Removes the pickle from the T-Rex King Burger.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes the ketchup from the T-Rex King Burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes the mustard from the T-Rex King Burger.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Removes the mayo from the T-Rex King Burger.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
