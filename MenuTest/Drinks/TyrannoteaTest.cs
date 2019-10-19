/* TyrannoteaTest.cs
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
    /// Contains the tests for the Tyrannotea menu item
    /// </summary>
    public class TyrannoteaTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal("Small Tyrannotea", t.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal("Medium Tyrannotea", t.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal("Large Tyrannotea", t.Description);
        }

        [Fact]
        public void CorrectDefaultSweetDescription()
        {
            Tyrannotea t = new Tyrannotea();
            t.MakeSweet();
            Assert.Equal("Small Sweet Tyrannotea", t.Description);
        }

        [Fact]
        public void CorrectMediumSweetDescription()
        {
            Tyrannotea t = new Tyrannotea();
            t.MakeSweet();
            t.Size = Size.Medium;
            Assert.Equal("Medium Sweet Tyrannotea", t.Description);
        }

        [Fact]
        public void CorrectLargeSweetDescription()
        {
            Tyrannotea t = new Tyrannotea();
            t.MakeSweet();
            t.Size = Size.Large;
            Assert.Equal("Large Sweet Tyrannotea", t.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal("Small Tyrannotea", t.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal("Medium Tyrannotea", t.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal("Large Tyrannotea", t.ToString());
        }

        [Fact]
        public void CorrectDefaultSweetToString()
        {
            Tyrannotea t = new Tyrannotea();
            t.MakeSweet();
            Assert.Equal("Small Sweet Tyrannotea", t.ToString());
        }

        [Fact]
        public void CorrectMediumSweetToString()
        {
            Tyrannotea t = new Tyrannotea();
            t.MakeSweet();
            t.Size = Size.Medium;
            Assert.Equal("Medium Sweet Tyrannotea", t.ToString());
        }

        [Fact]
        public void CorrectLargeSweetToString()
        {
            Tyrannotea t = new Tyrannotea();
            t.MakeSweet();
            t.Size = Size.Large;
            Assert.Equal("Large Sweet Tyrannotea", t.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void HoldIceShouldBeInSpecial()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldBeInSpecial()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            t.AddLemon();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            },
            item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", t.HoldIce);
        }

        [Fact]
        public void AddLemonShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", t.AddLemon);
        }

        [Fact]
        public void MakeSweetShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Description", t.MakeSweet);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Description", t.MakeMedium);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Price", t.MakeMedium);
        }

        /// <summary>
        /// The correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// The correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// The correct default ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// The correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        /// <summary>
        /// The correct default lemon property
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemonProperty()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// The correct default sweet property
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweetProperty()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        /// <summary>
        /// The correct price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// The correct price for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// The correct price for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// The correct calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// The correct calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// The correct calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Invoking HoldIce sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIceResultsInFalseIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Invoking AddLemon sets Lemon to true
        /// </summary>
        [Fact]
        public void AddLemonResultsInTrueLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// The sweet property doubles the calories for small
        /// </summary>
        [Fact]
        public void SweetPropertyDoublesCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// The sweet property doubles the calories for medium
        /// </summary>
        [Fact]
        public void SweetPropertyDoublesCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// The sweet property doubles the calories for large
        /// </summary>
        [Fact]
        public void SweetPropertyDoublesCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<double>(64, tea.Calories);
        }

        /// <summary>
        /// The sweet property doubles the calories for small
        /// </summary>
        [Fact]
        public void SweetPropertyResultsInCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// The sweet property doubles the calories for medium
        /// </summary>
        [Fact]
        public void SweetPropertyResultsInCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// The sweet property doubles the calories for large
        /// </summary>
        [Fact]
        public void SweetPropertyResultsInCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
            tea.AddLemon();
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
            tea.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }
    }
}
