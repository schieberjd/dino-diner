/* Order.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the current customer order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        // Backing variable
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Gets or sets the items in the order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Gets the subtotal of the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double sum = 0;
                foreach (IOrderItem item in Items)
                {
                    sum += item.Price;
                }
                if (sum < 0) return 0;
                else return sum;
            }
        }

        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies of the properties changed
        /// </summary>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Event handler for properties changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Gets or sets the sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .10;

        /// <summary>
        /// Gets the sales tax cost
        /// </summary>
        public double SalesTaxCost { get { return SalesTaxRate * SubtotalCost; } }

        /// <summary>
        /// Gets the total cost of the order
        /// </summary>
        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

        /// <summary>
        /// Constructs a new order
        /// </summary>
        public Order() { }

        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Removes an item from our order
        /// </summary>
        /// <param name="item">The item to return</param>
        /// <returns>Whether or not it was returned</returns>
        public bool Remove(IOrderItem item)
        {
            bool flag = items.Remove(item);
            if (flag)
            {
                NotifyAllPropertiesChanged();
            }
            return flag;
        }
    }
}
