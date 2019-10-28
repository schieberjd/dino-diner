/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Saves the entree selected
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Initializes the form
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new entree selection page with a saved entree
        /// </summary>
        /// <param name="entree">The saved entree</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Adds an entree to the control and selects the entree
        /// </summary>
        /// <param name="entree">The selected entree</param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(entree);
                Entree = entree;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }
    }
}
