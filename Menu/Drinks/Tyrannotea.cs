/* Tyrannotea.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the menu item Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the Tyrannotea
        /// </summary>
        private Size size;

        /// <summary>
        /// If the tea has sweetener
        /// </summary>
        private bool sweet = false;

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
                if (Lemon) special.Add("Add Lemon");
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
        /// Gets or sets if the tea has sweetener and changes the corresponding values
        /// </summary>
        public bool Sweet
        {
            set
            {
                sweet = value;
                if (sweet)
                {
                    if (size == Size.Small) this.Calories = 16;
                    else if (size == Size.Medium) this.Calories = 32;
                    else this.Calories = 64;
                }
                else
                {
                    if (size == Size.Small) this.Calories = 8;
                    else if (size == Size.Medium) this.Calories = 16;
                    else this.Calories = 32;
                }
                NotifyOfPropertyChange("Description");
            }
            get
            {
                return sweet;
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
        /// If the tea has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets the ingredients from the tea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
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
                if (sweet)
                {
                    switch (size)
                    {
                        case Size.Large:
                            Price = 1.99;
                            Calories = 64;
                            break;
                        case Size.Medium:
                            Price = 1.49;
                            Calories = 32;
                            break;
                        case Size.Small:
                            Price = 0.99;
                            Calories = 16;
                            break;
                    }
                }
                else
                {
                    switch (size)
                    {
                        case Size.Large:
                            Price = 1.99;
                            Calories = 32;
                            break;
                        case Size.Medium:
                            Price = 1.49;
                            Calories = 16;
                            break;
                        case Size.Small:
                            Price = 0.99;
                            Calories = 8;
                            break;
                    }
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Adds lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
        }

        public void MakeSweet()
        {
            this.Sweet = true;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Constructs a new tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }

        /// <summary>
        /// Returns the name of the menu item in string format
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            if (sweet) return size.ToString() + " Sweet Tyrannotea";
            else return size.ToString() + " Tyrannotea";
        }
    }
}
