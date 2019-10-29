/* OrderTests.cs
 * Author: Justin Schieber
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// Contains unit tests for the order class
    /// </summary>
    public class OrderTests
    {
        /// <summary>
        /// Tests if subtotal cost can be a negative value
        /// </summary>
        [Fact]
        public void SubtotalCostCantBeNegative()
        {
            Order o = new Order();
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.Price = -100;
            o.Add(p);
            Assert.Equal<double>(0, o.SubtotalCost);
        }

        /// <summary>
        /// Tests if total cost is calculated correctly
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectTotalCost()
        {
            Order o = new Order();
            o.Add(new Brontowurst());
            Tyrannotea t = new Tyrannotea();
            t.MakeLarge();
            o.Add(t);
            Assert.Equal<double>(8.085, o.TotalCost);
        }

        /// <summary>
        /// Tests if total cost is calculated correctly
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectTotalCost2()
        {
            Order o = new Order();
            o.Add(new CretaceousCombo(new DinoNuggets()));
            o.Add(new Water());
            Assert.Equal<double>(7.249, o.TotalCost);
        }

        /// <summary>
        /// Tests if total cost is calculated correctly
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectTotalCost3()
        {
            Order o = new Order();
            o.Add(new CretaceousCombo(new PterodactylWings()));
            Triceritots t = new Triceritots();
            t.MakeLarge();
            o.Add(t);
            Assert.Equal<double>(12.54, o.TotalCost);
        }
    }
}
