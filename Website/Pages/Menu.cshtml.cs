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
        public List<IMenuItem> MenuItems;

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
                MenuItems = Menu.Search(MenuItems, search);
            }

            if (menuCategory.Count != 0)
            {
                MenuItems = Menu.FilterByCategory(MenuItems, menuCategory);
            }

            if (minimumPrice != null)
            {
                MenuItems = Menu.FilterByMinPrice(MenuItems, (float)minimumPrice);
            }

            if (maximumPrice != null)
            {
                MenuItems = Menu.FilterByMaxPrice(MenuItems, (float)maximumPrice);
            }

            if (excludeIngredient.Count != 0)
            {
                MenuItems = Menu.FilterByIngredients(MenuItems, excludeIngredient);
            }
        }
    }
}