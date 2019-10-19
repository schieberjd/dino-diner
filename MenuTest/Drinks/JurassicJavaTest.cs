/* JurassicJavaTest.cs
 * Author: Justin Schieber
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Contains the tests for the JurrasicJava menu item
    /// </summary>
    public class JurrasicJavaTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal("Small Jurassic Java", j.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", j.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal("Large Jurassic Java", j.Description);
        }

        [Fact]
        public void CorrectDefaultDecafDescription()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            Assert.Equal("Small Decaf Jurassic Java", j.Description);
        }

        [Fact]
        public void CorrectMediumDecafDescription()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            j.Size = Size.Medium;
            Assert.Equal("Medium Decaf Jurassic Java", j.Description);
        }

        [Fact]
        public void CorrectLargeDecafDescription()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            j.Size = Size.Large;
            Assert.Equal("Large Decaf Jurassic Java", j.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal("Small Jurassic Java", j.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", j.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal("Large Jurassic Java", j.ToString());
        }

        [Fact]
        public void CorrectDefaultDecafToString()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            Assert.Equal("Small Decaf Jurassic Java", j.ToString());
        }

        [Fact]
        public void CorrectMediumDecafToString()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            j.Size = Size.Medium;
            Assert.Equal("Medium Decaf Jurassic Java", j.ToString());
        }

        [Fact]
        public void CorrectLargeDecafToString()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            j.Size = Size.Large;
            Assert.Equal("Large Decaf Jurassic Java", j.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            JurassicJava j = new JurassicJava();
            Assert.Empty(j.Special);
        }

        [Fact]
        public void AddIceShouldBeInSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldBeInSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            j.LeaveRoomForCream();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            },
            item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", j.AddIce);
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", j.LeaveRoomForCream);
        }

        [Fact]
        public void MakeDecafShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Description", j.MakeDecaf);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Description", j.MakeMedium);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfPricePropertyChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Price", j.MakeMedium);
        }

        /// <summary>
        /// The correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// The correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// The correct default ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// The correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        /// <summary>
        /// The correct default room for cream property
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCreamProperty()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// The correct price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// The correct price for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// The correct price for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        /// <summary>
        /// The correct calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(2, java.Calories);
        }

        /// <summary>
        /// The correct calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(4, java.Calories);
        }

        /// <summary>
        /// The correct calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(8, java.Calories);
        }

        /// <summary>
        /// Invoking AddIce sets Ice to true
        /// </summary>
        [Fact]
        public void AddIceResultsInTrueIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        /// <summary>
        /// Invoking leave room for cream sets roomforcream to true
        /// </summary>
        [Fact]
        public void LeaveRoomForCreamResultsInTrueRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
    }
}
