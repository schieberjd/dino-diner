using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class TriceritotsTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            Triceritots t = new Triceritots();
            Assert.Equal("Small Triceritots", t.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            Triceritots t = new Triceritots();
            t.MakeMedium();
            Assert.Equal("Medium Triceritots", t.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            Triceritots t = new Triceritots();
            t.MakeLarge();
            Assert.Equal("Large Triceritots", t.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            Triceritots t = new Triceritots();
            Assert.Equal("Small Triceritots", t.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            Triceritots t = new Triceritots();
            t.MakeMedium();
            Assert.Equal("Medium Triceritots", t.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            Triceritots t = new Triceritots();
            t.MakeLarge();
            Assert.Equal("Large Triceritots", t.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            Triceritots t = new Triceritots();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfDescriptionPropertyChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", t.MakeSmall);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfPricePropertyChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Price", t.MakeSmall);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfDescriptionPropertyChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", t.MakeMedium);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfPricePropertyChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Price", t.MakeMedium);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfDescriptionPropertyChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", t.MakeLarge);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfPricePropertyChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Price", t.MakeLarge);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal(0.99, tt.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<uint>(352, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots tt = new Triceritots();
            Assert.Contains<string>("Potato", tt.Ingredients);
            Assert.Contains<string>("Salt", tt.Ingredients);
            Assert.Contains<string>("Vegetable Oil", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal(1.45, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(410, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal(1.95, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<uint>(590, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
        }
    }
}
