/* CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        //Backing variable
        private Brontowurst bronto;

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
        /// <param name="bronto">The item to customize</param>
        public CustomizeBrontowurst(Brontowurst bronto)
        {
            InitializeComponent();
            this.bronto = bronto;
        }

        /// <summary>
        /// Creates a new customize entree page
        /// </summary>
        /// <param name="bronto">The current brontowurst</param>
        /// <param name="comboPage">The customize combo page</param>
        public CustomizeBrontowurst(Brontowurst bronto, CustomizeCombo comboPage)
        {
            InitializeComponent();
            isCombo = true;
            this.comboPage = comboPage;
            this.comboPage.Combo.Entree = bronto;
            this.bronto = (Brontowurst)comboPage.Combo.Entree;
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
            bronto.HoldBun();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the peppers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bronto.HoldPeppers();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            bronto.HoldOnion();
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
