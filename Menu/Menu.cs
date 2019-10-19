/* Menu.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the DinoDiner menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// A list of all menu items offered by DinoDiner
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();

                menuItems.Add(new Brontowurst());
                menuItems.Add(new DinoNuggets());
                menuItems.Add(new PrehistoricPBJ());
                menuItems.Add(new PterodactylWings());
                menuItems.Add(new SteakosaurusBurger());
                menuItems.Add(new TRexKingBurger());
                menuItems.Add(new VelociWrap());

                menuItems.Add(new Fryceritops());
                menuItems.Add(new MeteorMacAndCheese());
                menuItems.Add(new MezzorellaSticks());
                menuItems.Add(new Triceritots());

                menuItems.Add(new JurassicJava());
                menuItems.Add(new Sodasaurus());
                menuItems.Add(new Tyrannotea());
                menuItems.Add(new Water());

                menuItems.Add(new CretaceousCombo(new Brontowurst()));
                menuItems.Add(new CretaceousCombo(new DinoNuggets()));
                menuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menuItems.Add(new CretaceousCombo(new PterodactylWings()));
                menuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                menuItems.Add(new CretaceousCombo(new VelociWrap()));

                return menuItems;
            }
        }

        /// <summary>
        /// A list of all entrees offered by DinoDiner
        /// </summary>
        public List<Entree> AvailableEntrees
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
        public List<Side> AvailableSides
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
        public List<Drink> AvailableDrinks
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
        public List<IMenuItem> AvailableCombos
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
        /// Writes a string of all the menu items on separate lines
        /// </summary>
        /// <returns>A string of all menu items</returns>
        public override string ToString()
        {
            string s = "";
            foreach(IMenuItem item in AvailableMenuItems)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }
    }
}
