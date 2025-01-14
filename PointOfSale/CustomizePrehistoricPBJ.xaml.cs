﻿/* CustomizePrehistoricPBJ.xaml.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        //Backing variable
        private PrehistoricPBJ pbj;

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
        /// <param name="pbj">The item to customize</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Creates a new customize entree page
        /// </summary>
        /// <param name="pbj">The current PrehistoricPBJ</param>
        /// <param name="comboPage">The customize combo page</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj, CustomizeCombo comboPage)
        {
            InitializeComponent();
            isCombo = true;
            this.comboPage = comboPage;
            this.comboPage.Combo.Entree = pbj;
            this.pbj = (PrehistoricPBJ)comboPage.Combo.Entree;
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
        /// Holds the jelly for the sandwich
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds the peanut butter for the sandwich
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
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
