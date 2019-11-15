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
    /// Creates and controls the menu page of the website
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// The current DinoDiner Menu
        /// </summary>
        public Menu Menu { get; } = new Menu();
    }
}