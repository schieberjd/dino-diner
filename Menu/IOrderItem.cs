/* IOrderItem.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implements the price, description, and special properties for all order items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The description of the order item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Special intructions for the order item
        /// </summary>
        string[] Special { get; }
    }
}
