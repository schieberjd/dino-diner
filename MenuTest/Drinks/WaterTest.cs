﻿/* WaterTest.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Contains the tests for the Water menu item
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// The correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water wat = new Water();
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// The correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water wat = new Water();
            Assert.Equal<uint>(0, wat.Calories);
        }

        /// <summary>
        /// The correct default ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water wat = new Water();
            Assert.True(wat.Ice);
        }

        /// <summary>
        /// The correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water wat = new Water();
            Assert.Equal<Size>(Size.Small, wat.Size);
        }

        /// <summary>
        /// The correct default lemon property
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemonProperty()
        {
            Water wat = new Water();
            Assert.False(wat.Lemon);
        }

        /// <summary>
        /// The correct price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// The correct price for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// The correct price for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// The correct calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal<double>(0, wat.Calories);
        }

        /// <summary>
        /// The correct calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(0, wat.Calories);
        }

        /// <summary>
        /// The correct calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(0, wat.Calories);
        }

        /// <summary>
        /// Invoking HoldIce sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIceResultsInFalseIce()
        {
            Water wat = new Water();
            wat.HoldIce();
            Assert.False(wat.Ice);
        }

        /// <summary>
        /// Invoking add lemon sets lemon to true
        /// </summary>
        [Fact]
        public void AddLemonResultsInTrueLemon()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.True(wat.Lemon);
        }

        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
            Assert.Equal<int>(1, wat.Ingredients.Count);
            wat.AddLemon();
            Assert.Contains<string>("Lemon", wat.Ingredients);
            Assert.Equal<int>(2, wat.Ingredients.Count);
        }
    }
}