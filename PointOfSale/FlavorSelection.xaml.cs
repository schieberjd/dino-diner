/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// The current drink selection page
        /// </summary>
        public DrinkSelection SelectionPage { get; set; }

        /// <summary>
        /// Initializes the form
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the flavor of the soda to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectCherry(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeCherry();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }

        /// <summary>
        /// Changes the flavor of the soda to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectChocolate(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeChocolate();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }

        /// <summary>
        /// Changes the flavor of the soda to cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectCola(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeCola();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }

        /// <summary>
        /// Changes the flavor of the soda to lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectLime(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeLime();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }

        /// <summary>
        /// Changes the flavor of the soda to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectOrange(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeOrange();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }

        /// <summary>
        /// Changes the flavor of the soda to root beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeRootBeer();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }

        /// <summary>
        /// Changes the flavor of the soda to vanilaa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectVanilla(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)SelectionPage.Drink;
            soda.MakeVanilla();
            SelectionPage.Drink = soda;
            SelectionPage.NotifyOfPropertyChange("Special");
            NavigationService.Navigate(SelectionPage);
        }
    }
}
