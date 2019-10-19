using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            Fryceritops f = new Fryceritops();
            Assert.Equal("Small Fryceritops", f.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            Fryceritops f = new Fryceritops();
            f.MakeMedium();
            Assert.Equal("Medium Fryceritops", f.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            Fryceritops f = new Fryceritops();
            f.MakeLarge();
            Assert.Equal("Large Fryceritops", f.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            Fryceritops f = new Fryceritops();
            Assert.Equal("Small Fryceritops", f.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            Fryceritops f = new Fryceritops();
            f.MakeMedium();
            Assert.Equal("Medium Fryceritops", f.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            Fryceritops f = new Fryceritops();
            f.MakeLarge();
            Assert.Equal("Large Fryceritops", f.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            Fryceritops f = new Fryceritops();
            Assert.Empty(f.Special);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfDescriptionPropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", f.MakeSmall);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfPricePropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Price", f.MakeSmall);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfDescriptionPropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", f.MakeMedium);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfPricePropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Price", f.MakeMedium);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfDescriptionPropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", f.MakeLarge);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfPricePropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Price", f.MakeLarge);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }
    }
}
