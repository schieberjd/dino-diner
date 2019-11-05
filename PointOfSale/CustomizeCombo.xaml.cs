/* CustomizeCombo.xaml.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Saves the combo selected
        /// </summary>
        public CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Creates a new customize combo page with a saved combo
        /// </summary>
        /// <param name="combo">The saved combo</param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
            UpdateButtonText();
        }

        /// <summary>
        /// Updates the buttons when the page is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnPageLoaded(object sender, RoutedEventArgs args)
        {
            UpdateButtonText();
        }

        /// <summary>
        /// Helper method to update button text
        /// </summary>
        private void UpdateButtonText()
        {
            CurrentEntree.Content = Combo.Entree.Description;
            CurrentSide.Content = Combo.Side.Description;
            CurrentDrink.Content = Combo.Drink.Description;
        }

        /// <summary>
        /// Changes the size of the item to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectLarge(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Large;
            UpdateButtonText();
        }

        /// <summary>
        /// Changes the size of the item to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectMedium(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Medium;
            UpdateButtonText();
        }

        /// <summary>
        /// Changes the size of the item to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSmall(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Small;
            UpdateButtonText();
        }

        /// <summary>
        /// Returns to the menu category selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Navigates to the correct entree page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectEntree(object sender, RoutedEventArgs args)
        {
            if (Combo.Entree is Brontowurst b)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(b, this));
            }
            else if (Combo.Entree is DinoNuggets d)
            {
                NavigationService.Navigate(new CustomizeDinoNuggets(d, this));
            }
            else if (Combo.Entree is PrehistoricPBJ p)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(p, this));
            }
            else if (Combo.Entree is SteakosaurusBurger s)
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(s, this));
            }
            else if (Combo.Entree is TRexKingBurger t)
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger(t, this));
            }
            else if (Combo.Entree is VelociWrap v)
            {
                NavigationService.Navigate(new CustomizeVelociWrap(v, this));
            }
        }

        /// <summary>
        /// Navigates to the correct side page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(Combo.Side, true, this));
        }

        /// <summary>
        /// Navigates to the correct drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(Combo.Drink, true, this));
        }
    }
}
