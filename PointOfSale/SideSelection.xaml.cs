/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Saves the side selected
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Whether or not we are working with a combo
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// The Customize Combo page
        /// </summary>
        private CustomizeCombo comboPage;

        /// <summary>
        /// Creates a new side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new side selection page
        /// </summary>
        /// <param name="side">The saved side</param>
        /// <param name="isCombo">If it's a combo</param>
        /// <param name="comboPage">The customize combo page</param>
        public SideSelection(Side side, bool isCombo, CustomizeCombo comboPage)
        {
            InitializeComponent();
            this.isCombo = isCombo;
            this.comboPage = comboPage;
            if (this.isCombo)
            {
                this.comboPage.Combo.Side = side;
                Side = comboPage.Combo.Side;
            }
            else
            {
                Side = side;
            }
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
        /// Adds a side to the control and selects the side
        /// </summary>
        /// <param name="side">The saved side</param>
        private void SelectSide(Side side)
        {
            if (isCombo)
            {
                comboPage.Combo.Side = side;
                Side = comboPage.Combo.Side;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
            else
            {
                if (DataContext is Order order)
                {
                    order.Add(side);
                    Side = side;
                }
            }
        }

        /// <summary>
        /// Changes the side of the item
        /// </summary>
        /// <param name="size">The size selected</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                if (size == DinoDiner.Menu.Size.Small)
                {
                    Side.MakeSmall();
                }
                else if (size == DinoDiner.Menu.Size.Medium)
                {
                    Side.MakeMedium();
                }
                else if (size == DinoDiner.Menu.Size.Large)
                {
                    Side.MakeLarge();
                }

                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");

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

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddFryceritopsEvent(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddMeteorMacAndCheeseEvent(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddMezzorellaSticksEvent(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Selects the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddTriceritotsEvent(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
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
    }
}
