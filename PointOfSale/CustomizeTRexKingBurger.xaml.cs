/* CustomizeTRexKingBurger.xaml.cs
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        //Backing variable
        private TRexKingBurger burger;

        /// <summary>
        /// Whether or not we are working with a combo
        /// </summary>
        private bool isCombo = false;

        /// <summary>
        /// The Customize Combo page
        /// </summary>
        private CustomizeCombo comboPage = null;

        /// <summary>
        /// Contructs a new customize page
        /// </summary>
        /// <param name="burger">The item to customize</param>
        public CustomizeTRexKingBurger(TRexKingBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }

        /// <summary>
        /// Creates a new customize entree page
        /// </summary>
        /// <param name="burger">The current TRexKingBurger</param>
        /// <param name="comboPage">The customize combo page</param>
        public CustomizeTRexKingBurger(TRexKingBurger burger, CustomizeCombo comboPage)
        {
            InitializeComponent();
            isCombo = true;
            this.comboPage = comboPage;
            this.comboPage.Combo.Entree = burger;
            this.burger = (TRexKingBurger)comboPage.Combo.Entree;
        }

        /// <summary>
        /// Notifies of a combo property change
        /// </summary>
        /// <param name="propertyName">The property name</param>
        public void NotifyOfPropertyChange(string propertyName)
        {
            if (isCombo)
            {
                comboPage.Combo.NotifyOfPropertyChange(propertyName);
            }
        }

        /// <summary>
        /// Holds the bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Finishes the customization and returns to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
