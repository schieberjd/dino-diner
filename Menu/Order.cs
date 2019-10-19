/* Order.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the current customer order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

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
    }
}
