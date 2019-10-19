using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Equal("Small Meteor Mac and Cheese", m.Description);
        }

        [Fact]
        public void CorrectMediumDescription()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.MakeMedium();
            Assert.Equal("Medium Meteor Mac and Cheese", m.Description);
        }

        [Fact]
        public void CorrectLargeDescription()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.MakeLarge();
            Assert.Equal("Large Meteor Mac and Cheese", m.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Equal("Small Meteor Mac and Cheese", m.ToString());
        }

        [Fact]
        public void CorrectMediumToString()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.MakeMedium();
            Assert.Equal("Medium Meteor Mac and Cheese", m.ToString());
        }

        [Fact]
        public void CorrectLargeToString()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.MakeLarge();
            Assert.Equal("Large Meteor Mac and Cheese", m.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Empty(m.Special);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfDescriptionPropertyChange()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", m.MakeSmall);
        }

        [Fact]
        public void MakeSmallShouldNotifyOfPricePropertyChange()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Price", m.MakeSmall);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfDescriptionPropertyChange()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", m.MakeMedium);
        }

        [Fact]
        public void MakeMediumShouldNotifyOfPricePropertyChange()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Price", m.MakeMedium);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfDescriptionPropertyChange()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", m.MakeLarge);
        }

        [Fact]
        public void MakeLargeShouldNotifyOfPricePropertyChange()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Price", m.MakeLarge);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(0.99, mmc.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mmc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Pork Sausage", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(490, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(520, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
        }
    }
}
