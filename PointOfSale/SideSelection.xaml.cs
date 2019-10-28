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
        /// Creates a new side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new side selection page with a saved side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        /// <summary>
        /// Adds a side to the control and selects the side
        /// </summary>
        /// <param name="side">The saved side</param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                Side = side;
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
                    if (DataContext is Order order)
                    {
                        if (Side is Fryceritops fry)
                        {
                            order.Items.Remove(Side);
                            fry.MakeSmall();
                            Side = fry;
                            order.Items.Add(Side);
                        }
                        else if (Side is MeteorMacAndCheese mmc)
                        {
                            order.Items.Remove(Side);
                            mmc.MakeSmall();
                            Side = mmc;
                            order.Items.Add(Side);
                        }
                        else if (Side is MezzorellaSticks ms)
                        {
                            order.Items.Remove(Side);
                            ms.MakeSmall();
                            Side = ms;
                            order.Items.Add(Side);
                        } else if (Side is Triceritots tt)
                        {
                            order.Items.Remove(Side);
                            tt.MakeSmall();
                            Side = tt;
                            order.Items.Add(Side);
                        }
                    }
                }
                else if (size == DinoDiner.Menu.Size.Medium)
                {
                    if (DataContext is Order order)
                    {
                        if (Side is Fryceritops fry)
                        {
                            order.Items.Remove(Side);
                            fry.MakeMedium();
                            Side = fry;
                            order.Items.Add(Side);
                        }
                        else if (Side is MeteorMacAndCheese mmc)
                        {
                            order.Items.Remove(Side);
                            mmc.MakeMedium();
                            Side = mmc;
                            order.Items.Add(Side);
                        }
                        else if (Side is MezzorellaSticks ms)
                        {
                            order.Items.Remove(Side);
                            ms.MakeMedium();
                            Side = ms;
                            order.Items.Add(Side);
                        }
                        else if (Side is Triceritots tt)
                        {
                            order.Items.Remove(Side);
                            tt.MakeMedium();
                            Side = tt;
                            order.Items.Add(Side);
                        }
                    }
                }
                else if (size == DinoDiner.Menu.Size.Large)
                {
                    if (DataContext is Order order)
                    {
                        if (Side is Fryceritops fry)
                        {
                            order.Items.Remove(Side);
                            fry.MakeLarge();
                            Side = fry;
                            order.Items.Add(Side);
                        }
                        else if (Side is MeteorMacAndCheese mmc)
                        {
                            order.Items.Remove(Side);
                            mmc.MakeLarge();
                            Side = mmc;
                            order.Items.Add(Side);
                        }
                        else if (Side is MezzorellaSticks ms)
                        {
                            order.Items.Remove(Side);
                            ms.MakeLarge();
                            Side = ms;
                            order.Items.Add(Side);
                        }
                        else if (Side is Triceritots tt)
                        {
                            order.Items.Remove(Side);
                            tt.MakeLarge();
                            Side = tt;
                            order.Items.Add(Side);
                        }
                    }
                }
                NavigationService.Navigate(new MenuCategorySelection());
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
