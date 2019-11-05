/* CustomizeVelociWrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        //Backing variable
        private VelociWrap wrap;

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
        /// <param name="wrap">The item to customize</param>
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// Creates a new customize entree page
        /// </summary>
        /// <param name="wrap">The current VelociWrap</param>
        /// <param name="comboPage">The customize combo page</param>
        public CustomizeVelociWrap(VelociWrap wrap, CustomizeCombo comboPage)
        {
            InitializeComponent();
            isCombo = true;
            this.comboPage = comboPage;
            this.comboPage.Combo.Entree = wrap;
            this.wrap = (VelociWrap)comboPage.Combo.Entree;
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
        /// Holds the dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
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
