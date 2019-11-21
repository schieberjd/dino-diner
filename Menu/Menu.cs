/* Menu.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Holds functions to filter and search the menu as well as all the menu items
    /// </summary>
    public static class Menu
    {
        //Backing variables
        private static List<IMenuItem> availableMenuItems;
        private static List<string> possibleIngredients;

        /// <summary>
        /// A list of all items offered by DinoDiner
        /// </summary>
        public static List<IMenuItem> AvailableMenuItems
        {
            get
            {
                if (availableMenuItems == null)
                {
                    availableMenuItems = new List<IMenuItem>();

                    availableMenuItems.Add(new Brontowurst());
                    availableMenuItems.Add(new DinoNuggets());
                    availableMenuItems.Add(new PrehistoricPBJ());
                    availableMenuItems.Add(new PterodactylWings());
                    availableMenuItems.Add(new SteakosaurusBurger());
                    availableMenuItems.Add(new TRexKingBurger());
                    availableMenuItems.Add(new VelociWrap());

                    availableMenuItems.Add(new Fryceritops());
                    availableMenuItems.Add(new MeteorMacAndCheese());
                    availableMenuItems.Add(new MezzorellaSticks());
                    availableMenuItems.Add(new Triceritots());

                    availableMenuItems.Add(new JurassicJava());
                    availableMenuItems.Add(new Sodasaurus());
                    availableMenuItems.Add(new Tyrannotea());
                    availableMenuItems.Add(new Water());

                    availableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                    availableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                    availableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    availableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                    availableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    availableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                    availableMenuItems.Add(new CretaceousCombo(new VelociWrap()));
                }

                return availableMenuItems;
            }
        }

        /// <summary>
        /// A list of all entrees offered by DinoDiner
        /// </summary>
        public static List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entrees = new List<Entree>();
                entrees.Add(new Brontowurst());
                entrees.Add(new DinoNuggets());
                entrees.Add(new PrehistoricPBJ());
                entrees.Add(new PterodactylWings());
                entrees.Add(new SteakosaurusBurger());
                entrees.Add(new TRexKingBurger());
                entrees.Add(new VelociWrap());
                return entrees;
            }
        }

        /// <summary>
        /// A list of all sides offered by DinoDiner
        /// </summary>
        public static List<Side> AvailableSides
        {
            get
            {
                List<Side> sides = new List<Side>();
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
                return sides;
            }
        }

        /// <summary>
        /// A list of all drinks offered by DinoDiner
        /// </summary>
        public static List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drinks = new List<Drink>();
                drinks.Add(new JurassicJava());
                drinks.Add(new Sodasaurus());
                drinks.Add(new Tyrannotea());
                drinks.Add(new Water());
                return drinks;
            }
        }

        /// <summary>
        /// A list of all combos offered by DinoDiner
        /// </summary>
        public static List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                combos.Add(new CretaceousCombo(new Brontowurst()));
                combos.Add(new CretaceousCombo(new DinoNuggets()));
                combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                combos.Add(new CretaceousCombo(new PterodactylWings()));
                combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                combos.Add(new CretaceousCombo(new TRexKingBurger()));
                combos.Add(new CretaceousCombo(new VelociWrap()));
                return combos;
            }
        }

        /// <summary>
        /// A list of all the unique ingredients at DinoDiner
        /// </summary>
        public static List<string> PossibleIngredients
        {
            get
            {
                if (possibleIngredients == null)
                {
                    possibleIngredients = new List<string>();

                    foreach (IMenuItem item in AvailableMenuItems)
                    {
                        foreach (string ingredient in item.Ingredients)
                        {
                            if (!possibleIngredients.Contains(ingredient))
                            {
                                possibleIngredients.Add(ingredient);
                            }
                        }
                    }
                }

                return possibleIngredients;
            }
        }

        /// <summary>
        /// Searches the given list for the given string
        /// </summary>
        /// <param name="menuItems">The list of items to search</param>
        /// <param name="term">The string to search for</param>
        /// <returns>The list of items with that string</returns>
        public static List<IMenuItem> Search(List<IMenuItem> menuItems, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (item.ToString().ToLower().Contains(term.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list by the given list of categories
        /// </summary>
        /// <param name="menuItems">The list of items to filter</param>
        /// <param name="categories">The categories to filter with</param>
        /// <returns>The filtered list</returns>
        public static List<IMenuItem> FilterByCategory(List<IMenuItem> menuItems, List<string> categories)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (categories.Contains("Combo") && item is CretaceousCombo)
                {
                    results.Add(item);
                }
                else if (categories.Contains("Entree") && item is Entree)
                {
                    results.Add(item);
                }
                else if (categories.Contains("Side") && item is Side)
                {
                    results.Add(item);
                }
                else if (categories.Contains("Drink") && item is Drink)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list by the minimum price given
        /// </summary>
        /// <param name="menuItems">The list to filter</param>
        /// <param name="minPrice">The price to filter with</param>
        /// <returns>The filtered list</returns>
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuItems, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (minPrice <= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list by the maximum price given
        /// </summary>
        /// <param name="menuItems">The list to filter</param>
        /// <param name="maxPrice">The price to filter with</param>
        /// <returns>The filtered list</returns>
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuItems, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (maxPrice >= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list by the ingredient list given
        /// </summary>
        /// <param name="menuItems">The list to filter</param>
        /// <param name="ingredients">The list of ingredients to filter with</param>
        /// <returns>The filtered list</returns>
        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menuItems, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                results.Add(item);
            }

            foreach (IMenuItem item in menuItems)
            {
                foreach (string ingredient in item.Ingredients)
                {
                    if (ingredients.Contains(ingredient))
                    {
                        results.Remove(item);
                    }
                }
                
            }
            return results;
        }
    }
}
