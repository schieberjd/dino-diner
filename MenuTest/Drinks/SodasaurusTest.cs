/* SodasaurusTest.cs
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
    /// Contains the tests for the sodasaurus menu item
    /// </summary>
    public class SodasaurusTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal("Small Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeMedium();
            Assert.Equal("Medium Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeLarge();
            Assert.Equal("Large Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectDefaultDescriptionOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeOrange();
            Assert.Equal("Small Orange Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectMediumDescriptionOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeOrange();
            s.MakeMedium();
            Assert.Equal("Medium Orange Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectLargeDescriptionOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeOrange();
            s.MakeLarge();
            Assert.Equal("Large Orange Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectDefaultDescriptionVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeVanilla();
            Assert.Equal("Small Vanilla Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectMediumDescriptionVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeVanilla();
            s.MakeMedium();
            Assert.Equal("Medium Vanilla Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectLargeDescriptionVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeVanilla();
            s.MakeLarge();
            Assert.Equal("Large Vanilla Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectDefaultDescriptionChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeChocolate();
            Assert.Equal("Small Chocolate Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectMediumDescriptionChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeChocolate();
            s.MakeMedium();
            Assert.Equal("Medium Chocolate Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectLargeDescriptionChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeChocolate();
            s.MakeLarge();
            Assert.Equal("Large Chocolate Sodasaurus", s.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal("Small Cola Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeMedium();
            Assert.Equal("Medium Cola Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeLarge();
            Assert.Equal("Large Cola Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectDefaultToStringOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeOrange();
            Assert.Equal("Small Orange Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectMediumToStringOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeOrange();
            s.MakeMedium();
            Assert.Equal("Medium Orange Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectLargeToStringOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeOrange();
            s.MakeLarge();
            Assert.Equal("Large Orange Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectDefaultToStringVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeVanilla();
            Assert.Equal("Small Vanilla Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectMediumToStringVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeVanilla();
            s.MakeMedium();
            Assert.Equal("Medium Vanilla Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectLargeToStringVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeVanilla();
            s.MakeLarge();
            Assert.Equal("Large Vanilla Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectDefaultToStringChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeChocolate();
            Assert.Equal("Small Chocolate Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectMediumToStringChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeChocolate();
            s.MakeMedium();
            Assert.Equal("Medium Chocolate Sodasaurus", s.ToString());
        }

        [Fact]
        public void CorrectLargeToStringChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.MakeChocolate();
            s.MakeLarge();
            Assert.Equal("Large Chocolate Sodasaurus", s.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void HoldIceShouldNotifyOfSpecialPropertyChange()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Special", s.HoldIce);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Description", s.MakeMedium);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfPricePropertyChange()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Price", s.MakeMedium);
        }

        [Fact]
        public void ChangingFlavorShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Description", s.MakeLime);
        }

        /// <summary>
        /// The ability to set cola flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        /// <summary>
        /// The ability to set Orange flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        /// <summary>
        /// The ability to set Vanilla flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        /// <summary>
        /// The ability to set Chocolate flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        /// <summary>
        /// The ability to set RootBeer flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        /// <summary>
        /// The ability to set Cheery flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// The ability to set Lime flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// The correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// The correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(112, soda.Calories);
        }

        /// <summary>
        /// The correct default ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// The correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        /// <summary>
        /// The correct price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// The correct price for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        /// <summary>
        /// The correct price for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        /// <summary>
        /// The correct calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// The correct calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        /// <summary>
        /// The correct calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        /// <summary>
        /// Invoking HoldIce sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIceResultsInFalseIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }
    }
}
