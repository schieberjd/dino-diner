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
    public class TRexKingBurger
    {
        /// <summary>
        /// The price of the T-Rex King Burger.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The number of calories in the T-Rex King Burger.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Whether or not the T-Rex King Burger has a bun.
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has lettuce.
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has tomato.
        /// </summary>
        private bool Tomato = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has onion.
        /// </summary>
        private bool Onion = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has pickle.
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has ketchup.
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has mustard.
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// Whether or not the T-Rex King Burger has mayo.
        /// </summary>
        private bool Mayo = true;

        /// <summary>
        /// The ingredients in the T-Rex King Burger.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
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
            this.Bun = false;
        }

        /// <summary>
        /// Removes the lettuce from the T-Rex King Burger.
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// Removes the tomato from the T-Rex King Burger.
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
        }

        /// <summary>
        /// Removes the onion from the T-Rex King Burger.
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }

        /// <summary>
        /// Removes the pickle from the T-Rex King Burger.
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }

        /// <summary>
        /// Removes the ketchup from the T-Rex King Burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        /// <summary>
        /// Removes the mustard from the T-Rex King Burger.
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }

        /// <summary>
        /// Removes the mayo from the T-Rex King Burger.
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }
    }
}
