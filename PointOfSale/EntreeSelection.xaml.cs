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
        /// <param name="side">The saved entree</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Adds an entree to the control
        /// </summary>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                Entree = entree;
            }
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            Brontowurst b = new Brontowurst();
            SelectEntree(b);
            //NavigationService.Navigate(new CustomizeBrontowurst(b));
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets d = new DinoNuggets();
            SelectEntree(d);
            //NavigationService.Navigate(new CustomizeDinoNuggets(d));
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            SelectEntree(p);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(p));
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            PterodactylWings p = new PterodactylWings();
            SelectEntree(p);
            //NavigationService.Navigate(new CustomizePterodactylWings(p));
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            SelectEntree(s);
            //NavigationService.Navigate(new CustomizeSteakosaurusBurger(s));
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            TRexKingBurger t = new TRexKingBurger();
            SelectEntree(t);
            //NavigationService.Navigate(new CustomizeTRexKingBurger(t));
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap v = new VelociWrap();
            SelectEntree(v);
            //NavigationService.Navigate(new CustomizeVelociWrap(v));
        }
    }
}
