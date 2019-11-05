/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Initializes the form
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Navigates to the customize combo page with a selected combo and adds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
    }
}
