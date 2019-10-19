using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MezzorellaSticksTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Equal("Small Mezzorella Sticks", m.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.MakeMedium();
            Assert.Equal("Medium Mezzorella Sticks", m.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.MakeLarge();
            Assert.Equal("Large Mezzorella Sticks", m.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Equal("Small Mezzorella Sticks", m.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.MakeMedium();
            Assert.Equal("Medium Mezzorella Sticks", m.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.MakeLarge();
            Assert.Equal("Large Mezzorella Sticks", m.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Empty(m.Special);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfDescriptionPropertyChange()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", m.MakeSmall);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfPricePropertyChange()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Price", m.MakeSmall);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfDescriptionPropertyChange()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", m.MakeMedium);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfPricePropertyChange()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Price", m.MakeMedium);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfDescriptionPropertyChange()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", m.MakeLarge);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfPricePropertyChange()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Price", m.MakeLarge);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal(0.99, ms.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<uint>(540, ms.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Contains<string>("Breading", ms.Ingredients);
            Assert.Contains<string>("Cheese Product", ms.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ms.Ingredients);
            Assert.Equal<int>(3, ms.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<Size>(Size.Small, ms.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal(1.45, ms.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<uint>(610, ms.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ms.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal(1.95, ms.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<uint>(720, ms.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ms.Size);
        }
    }
}
