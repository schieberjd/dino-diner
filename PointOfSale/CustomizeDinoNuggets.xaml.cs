/* CustomizeDinoNuggets.xaml.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        //Backing variable
        private DinoNuggets dino;

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
        /// <param name="dino">The item to customize</param>
        public CustomizeDinoNuggets(DinoNuggets dino)
        {
            InitializeComponent();
            this.dino = dino;
        }

        /// <summary>
        /// Creates a new customize entree page
        /// </summary>
        /// <param name="dino">The current dinonugget</param>
        /// <param name="comboPage">The customize combo page</param>
        public CustomizeDinoNuggets(DinoNuggets dino, CustomizeCombo comboPage)
        {
            InitializeComponent();
            isCombo = true;
            this.comboPage = comboPage;
            this.comboPage.Combo.Entree = dino;
            this.dino = (DinoNuggets)comboPage.Combo.Entree;
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
        /// Adds a nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dino.AddNugget();
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
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
