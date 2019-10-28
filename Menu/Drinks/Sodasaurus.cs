/* Sodasaurus.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item Sodasaurus
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the Sodasaurus
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets the description of the menu item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special instructions for a menu item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special Properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of propety changes
        /// </summary>
        /// <param name="propertyName">The property name</param>
        public override void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// The flavor of the Sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// The ingredients of the current menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or sets the size of the item and the corresponding values
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Makes the item small
        /// </summary>
        public override void MakeSmall()
        {
            this.Size = Size.Small;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item medium
        /// </summary>
        public override void MakeMedium()
        {
            this.Size = Size.Medium;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Makes the item large
        /// </summary>
        public override void MakeLarge()
        {
            this.Size = Size.Large;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeCola()
        {
            this.Flavor = SodasaurusFlavor.Cola;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeOrange()
        {
            this.Flavor = SodasaurusFlavor.Orange;
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeVanilla()
        {
            this.Flavor = SodasaurusFlavor.Vanilla;
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeChocolate()
        {
            this.Flavor = SodasaurusFlavor.Chocolate;
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeRootBeer()
        {
            this.Flavor = SodasaurusFlavor.RootBeer;
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeCherry()
        {
            this.Flavor = SodasaurusFlavor.Cherry;
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// Change the flavor of sodasaurus
        /// </summary>
        public void MakeLime()
        {
            this.Flavor = SodasaurusFlavor.Lime;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Constructs a new sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return size.ToString() + " " + Flavor.ToString() + " Sodasaurus";
        }
    }
}
