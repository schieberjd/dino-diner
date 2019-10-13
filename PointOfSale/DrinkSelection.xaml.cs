/* DrinkSelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// The button to add flavor
        /// </summary>
        private Button flavorButton = new Button();

        /// <summary>
        /// The button to add sweetener
        /// </summary>
        private Button sweetButton = new Button();

        /// <summary>
        /// The button to add lemon
        /// </summary>
        private Button lemonButton = new Button();

        /// <summary>
        /// The button to make decaf
        /// </summary>
        private Button decafButton = new Button();

        /// <summary>
        /// The button to leave room for cream
        /// </summary>
        private Button creamButton = new Button();

        /// <summary>
        /// Whether or not the flavor button is displayed
        /// </summary>
        private bool flavorAdded = false;

        /// <summary>
        /// Whether or not the sweet button is displayed
        /// </summary>
        private bool sweetAdded = false;

        /// <summary>
        /// Whether or not the lemon button is displayed
        /// </summary>
        private bool lemonAdded = false;

        /// <summary>
        /// Whether or not the decaf button is displayed
        /// </summary>
        private bool decafAdded = false;

        /// <summary>
        /// Whether or not the cream button is displayed
        /// </summary>
        private bool creamAdded = false;

        /// <summary>
        /// Initializes the form and buttons
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();

            flavorButton.Content = "Select flavor";
            flavorButton.FontSize = 16;
            flavorButton.Click += new RoutedEventHandler(SelectFlavor);

            sweetButton.Content = "Add sweetener";
            sweetButton.FontSize = 16;

            lemonButton.Content = "Add lemon";
            lemonButton.FontSize = 16;

            decafButton.Content = "Make decaf";
            decafButton.FontSize = 16;

            creamButton.Content = "Leave room for cream";
            creamButton.FontSize = 16;
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeSpecialButtonsSodasaurus(object sender, RoutedEventArgs args)
        {
            uxDrinkSelection.Children.Remove(sweetButton);
            uxDrinkSelection.Children.Remove(lemonButton);
            uxDrinkSelection.Children.Remove(decafButton);
            uxDrinkSelection.Children.Remove(creamButton);
            sweetAdded = false;
            lemonAdded = false;
            decafAdded = false;
            creamAdded = false;
            if (!flavorAdded)
            {
                uxDrinkSelection.Children.Add(flavorButton);
                Grid.SetColumn(flavorButton, 2);
                Grid.SetRow(flavorButton, 1);
                flavorAdded = true;
            }
        }

        /// <summary>
        /// Navigates to the flavor selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeSpecialButtonsTyrannotea(object sender, RoutedEventArgs args)
        {
            uxDrinkSelection.Children.Remove(flavorButton);
            uxDrinkSelection.Children.Remove(decafButton);
            uxDrinkSelection.Children.Remove(creamButton);
            flavorAdded = false;
            decafAdded = false;
            creamAdded = false;
            if (!sweetAdded)
            {
                uxDrinkSelection.Children.Add(sweetButton);
                Grid.SetColumn(sweetButton, 2);
                Grid.SetRow(sweetButton, 1);
                sweetAdded = true;
            }
            if (!lemonAdded)
            {
                uxDrinkSelection.Children.Add(lemonButton);
                Grid.SetColumn(lemonButton, 2);
                Grid.SetRow(lemonButton, 2);
                lemonAdded = true;
            }
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeSpecialButtonsJurassicJava(object sender, RoutedEventArgs args)
        {
            uxDrinkSelection.Children.Remove(flavorButton);
            uxDrinkSelection.Children.Remove(sweetButton);
            uxDrinkSelection.Children.Remove(lemonButton);
            flavorAdded = false;
            sweetAdded = false;
            lemonAdded = false;
            if (!decafAdded)
            {
                uxDrinkSelection.Children.Add(decafButton);
                Grid.SetColumn(decafButton, 2);
                Grid.SetRow(decafButton, 1);
                decafAdded = true;
            }
            if (!creamAdded)
            {
                uxDrinkSelection.Children.Add(creamButton);
                Grid.SetColumn(creamButton, 2);
                Grid.SetRow(creamButton, 2);
                creamAdded = true;
            }
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeSpecialButtonsWater(object sender, RoutedEventArgs args)
        {
            uxDrinkSelection.Children.Remove(sweetButton);
            uxDrinkSelection.Children.Remove(flavorButton);
            uxDrinkSelection.Children.Remove(decafButton);
            uxDrinkSelection.Children.Remove(creamButton);
            sweetAdded = false;
            flavorAdded = false;
            decafAdded = false;
            creamAdded = false;
            if (!lemonAdded)
            {
                uxDrinkSelection.Children.Add(lemonButton);
                Grid.SetColumn(lemonButton, 2);
                Grid.SetRow(lemonButton, 1);
                lemonAdded = true;
            }
        }
    }
}
