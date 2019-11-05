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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Saves the selected drink
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Whether or not we are working with a combo
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// The Customize Combo page
        /// </summary>
        private CustomizeCombo comboPage;

        /// <summary>
        /// The hold ice button
        /// </summary>
        public Button holdIceButton = new Button();

        /// <summary>
        /// The button to add ice
        /// </summary>
        private Button iceButton = new Button();

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
        /// Whether or not the add ice button is displayed
        /// </summary>
        private bool addIceAdded = false;

        /// <summary>
        /// Whether or not the hold ice button is displayed
        /// </summary>
        private bool holdIceAdded = false;

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
        /// Initializes the form and buttons
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();

            holdIceButton.Content = "Hold ice";
            holdIceButton.FontSize = 16;
            holdIceButton.Click += new RoutedEventHandler(OnHoldIce);

            iceButton.Content = "Add ice";
            iceButton.FontSize = 16;
            iceButton.Click += new RoutedEventHandler(OnAddIce);

            flavorButton.Content = "Select flavor";
            flavorButton.FontSize = 16;
            flavorButton.Click += new RoutedEventHandler(SelectFlavor);

            sweetButton.Content = "Add sweetener";
            sweetButton.FontSize = 16;
            sweetButton.Click += new RoutedEventHandler(OnMakeSweet);

            lemonButton.Content = "Add lemon";
            lemonButton.FontSize = 16;
            lemonButton.Click += new RoutedEventHandler(OnAddLemon);

            decafButton.Content = "Make decaf";
            decafButton.FontSize = 16;
            decafButton.Click += new RoutedEventHandler(OnMakeDecaf);

            creamButton.Content = "Leave room for cream";
            creamButton.FontSize = 16;
            creamButton.Click += new RoutedEventHandler(OnLeaveRoomForCream);
        }

        /// <summary>
        /// Adds a drink to the control and selects the drink
        /// </summary>
        /// <param name="drink">The selected drink</param>
        private void SelectDrink(Drink drink)
        {
            if (isCombo)
            {
                comboPage.Combo.Drink = drink;
                Drink = comboPage.Combo.Drink;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
            else
            {
                if (DataContext is Order order)
                {
                    order.Add(drink);
                    Drink = drink;
                }
            }
        }

        /// <summary>
        /// Changes the side of the item
        /// </summary>
        /// <param name="size">The size selected</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                if (size == DinoDiner.Menu.Size.Small)
                {
                    Drink.MakeSmall();
                }
                else if (size == DinoDiner.Menu.Size.Medium)
                {
                    Drink.MakeMedium();
                }
                else if (size == DinoDiner.Menu.Size.Large)
                {
                    Drink.MakeLarge();
                }
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Changes the size of the item to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Changes the size of the item to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Changes the size of the item to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Creates a new drink selection page
        /// </summary>
        /// <param name="drink">The saved drink</param>
        /// <param name="isCombo">If it's a combo</param>
        /// <param name="comboPage">The customize combo page</param>
        public DrinkSelection(Drink drink, bool isCombo, CustomizeCombo comboPage)
        {
            InitializeComponent();
            this.isCombo = isCombo;
            this.comboPage = comboPage;
            if (this.isCombo)
            {
                this.comboPage.Combo.Drink = drink;
                Drink = comboPage.Combo.Drink;
            }
            else
            {
                Drink = drink;
            }

            holdIceButton.Content = "Hold ice";
            holdIceButton.FontSize = 16;
            holdIceButton.Click += new RoutedEventHandler(OnHoldIce);

            iceButton.Content = "Add ice";
            iceButton.FontSize = 16;
            iceButton.Click += new RoutedEventHandler(OnAddIce);

            flavorButton.Content = "Select flavor";
            flavorButton.FontSize = 16;
            flavorButton.Click += new RoutedEventHandler(SelectFlavor);

            sweetButton.Content = "Add sweetener";
            sweetButton.FontSize = 16;
            sweetButton.Click += new RoutedEventHandler(OnMakeSweet);

            lemonButton.Content = "Add lemon";
            lemonButton.FontSize = 16;
            lemonButton.Click += new RoutedEventHandler(OnAddLemon);

            decafButton.Content = "Make decaf";
            decafButton.FontSize = 16;
            decafButton.Click += new RoutedEventHandler(OnMakeDecaf);

            creamButton.Content = "Leave room for cream";
            creamButton.FontSize = 16;
            creamButton.Click += new RoutedEventHandler(OnLeaveRoomForCream);

            if (drink is Sodasaurus soda)
            {
                ChangeSpecialButtonsSodasaurus(soda, new RoutedEventArgs());
            }
            else if (drink is Tyrannotea tea)
            {
                ChangeSpecialButtonsTyrannotea(tea, new RoutedEventArgs());
            }
            else if (drink is JurassicJava java)
            {
                ChangeSpecialButtonsJurassicJava(java, new RoutedEventArgs());
            }
            else if (drink is Water water)
            {
                ChangeSpecialButtonsWater(water, new RoutedEventArgs());
            }
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        private void ChangeSpecialButtonsSodasaurus(object sender, RoutedEventArgs args)
        {
            OnSelectSodasaurus();
            uxDrinkSelection.Children.Remove(iceButton);
            uxDrinkSelection.Children.Remove(sweetButton);
            uxDrinkSelection.Children.Remove(lemonButton);
            uxDrinkSelection.Children.Remove(decafButton);
            uxDrinkSelection.Children.Remove(creamButton);
            sweetAdded = false;
            lemonAdded = false;
            decafAdded = false;
            creamAdded = false;
            addIceAdded = false;
            if (!flavorAdded)
            {
                uxDrinkSelection.Children.Add(flavorButton);
                Grid.SetColumn(flavorButton, 2);
                Grid.SetRow(flavorButton, 1);
                flavorAdded = true;
            }
            if (!holdIceAdded)
            {
                uxDrinkSelection.Children.Add(holdIceButton);
                Grid.SetColumn(holdIceButton, 2);
                Grid.SetRow(holdIceButton, 0);
                holdIceAdded = true;
            }
        }

        /// <summary>
        /// Navigates to the flavor selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            FlavorSelection fs = new FlavorSelection();
            fs.SelectionPage = this;
            NavigationService.Navigate(fs);
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        private void ChangeSpecialButtonsTyrannotea(object sender, RoutedEventArgs args)
        {
            OnSelectTyrannotea();
            uxDrinkSelection.Children.Remove(iceButton);
            uxDrinkSelection.Children.Remove(flavorButton);
            uxDrinkSelection.Children.Remove(decafButton);
            uxDrinkSelection.Children.Remove(creamButton);
            flavorAdded = false;
            decafAdded = false;
            creamAdded = false;
            addIceAdded = false;
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
            if (!holdIceAdded)
            {
                uxDrinkSelection.Children.Add(holdIceButton);
                Grid.SetColumn(holdIceButton, 2);
                Grid.SetRow(holdIceButton, 0);
                holdIceAdded = true;
            }
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        private void ChangeSpecialButtonsJurassicJava(object sender, RoutedEventArgs args)
        {
            OnSelectJurassicJava();
            uxDrinkSelection.Children.Remove(holdIceButton);
            uxDrinkSelection.Children.Remove(flavorButton);
            uxDrinkSelection.Children.Remove(sweetButton);
            uxDrinkSelection.Children.Remove(lemonButton);
            flavorAdded = false;
            sweetAdded = false;
            lemonAdded = false;
            holdIceAdded = false;
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
            if (!addIceAdded)
            {
                uxDrinkSelection.Children.Add(iceButton);
                Grid.SetColumn(iceButton, 2);
                Grid.SetRow(iceButton, 0);
                addIceAdded = true;
            }
        }

        /// <summary>
        /// Adds the special buttons for the selected drink
        /// </summary>
        private void ChangeSpecialButtonsWater(object sender, RoutedEventArgs args)
        {
            OnSelectWater();
            uxDrinkSelection.Children.Remove(iceButton);
            uxDrinkSelection.Children.Remove(sweetButton);
            uxDrinkSelection.Children.Remove(flavorButton);
            uxDrinkSelection.Children.Remove(decafButton);
            uxDrinkSelection.Children.Remove(creamButton);
            sweetAdded = false;
            flavorAdded = false;
            decafAdded = false;
            creamAdded = false;
            addIceAdded = false;
            if (!lemonAdded)
            {
                uxDrinkSelection.Children.Add(lemonButton);
                Grid.SetColumn(lemonButton, 2);
                Grid.SetRow(lemonButton, 1);
                lemonAdded = true;
            }
            if (!holdIceAdded)
            {
                uxDrinkSelection.Children.Add(holdIceButton);
                Grid.SetColumn(holdIceButton, 2);
                Grid.SetRow(holdIceButton, 0);
                holdIceAdded = true;
            }
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        protected void OnSelectSodasaurus()
        {
            SelectDrink(new Sodasaurus());
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        protected void OnSelectTyrannotea()
        {
            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        protected void OnSelectJurassicJava()
        {
            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        protected void OnSelectWater()
        {
            SelectDrink(new Water());
        }

        /// <summary>
        /// Holds ice for the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnHoldIce(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                Drink.HoldIce();
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Makes the tea sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSweet(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                Tyrannotea tea = (Tyrannotea)Drink;
                tea.MakeSweet();
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Makes java decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                JurassicJava java = (JurassicJava)Drink;
                java.MakeDecaf();
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Makes java decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnLeaveRoomForCream(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                JurassicJava java = (JurassicJava)Drink;
                java.LeaveRoomForCream();
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Adds lemon to the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                if (sweetAdded)
                {
                    Tyrannotea tea = (Tyrannotea)Drink;
                    tea.AddLemon();
                }
                else
                {
                    Water water = (Water)Drink;
                    water.AddLemon();
                }
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Makes java decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnAddIce(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                JurassicJava java = (JurassicJava)Drink;
                java.AddIce();
            }
            if (isCombo)
            {
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Returns to the menu category selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void FinishDrink(object sender, RoutedEventArgs args)
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
