﻿/* Tyrannotea.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The class for the menu item Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink
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
            }
            get
            {
                return sweet;
            }
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
        }

        /// <summary>
        /// Constructs a new tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }
    }
}