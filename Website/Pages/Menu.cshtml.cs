/* Menu.cs.html
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    /// <summary>
    /// The backing code for the menu website page
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// The current list of menu items to display
        /// </summary>
        public IEnumerable<IMenuItem> MenuItems;

        /// <summary>
        /// The phrase to search for
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// The categories to filter by
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// The minimum price to filter by
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }

        /// <summary>
        /// The maximum price to filter by
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }

        /// <summary>
        /// The list of ingredients to filter by
        /// </summary>
        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

        /// <summary>
        /// Loads and populates the page
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.AvailableMenuItems;
        }

        /// <summary>
        /// Updates the page after clicking the search and filter button
        /// </summary>
        public void OnPost()
        {
            MenuItems = Menu.AvailableMenuItems;

            if (search != null)
            {
                MenuItems = MenuItems.Where(item => item.ToString().ToLower().Contains(search.ToLower()));
            }

            if (menuCategory.Count != 0)
            {
                MenuItems = MenuItems.Where(item => (item is CretaceousCombo && menuCategory.Contains("Combo")) || (item is Entree && menuCategory.Contains("Entree")) || (item is Side && menuCategory.Contains("Side")) || (item is Drink && menuCategory.Contains("Drink")));
            }

            if (minimumPrice != null)
            {
                MenuItems = MenuItems.Where(item => item.Price >= minimumPrice);
            }

            if (maximumPrice != null)
            {
                MenuItems = MenuItems.Where(item => item.Price <= maximumPrice);
            }

            if (excludeIngredient.Count != 0)
            {
                MenuItems = MenuItems.Where(item => !item.Ingredients.Any(ingredient => excludeIngredient.Contains(ingredient)));
            }
        }
    }
}