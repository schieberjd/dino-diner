using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            Brontowurst b = new Brontowurst();
            Assert.Equal("Brontowurst", b.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            Brontowurst b = new Brontowurst();
            Assert.Equal("Brontowurst", b.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }

        [Fact]
        public void HoldBunShouldBeInSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void HoldOnionShouldBeInSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }

        [Fact]
        public void HoldPeppersShouldBeInSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldOnion();
            b.HoldPeppers();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Onion", item);
            },
            item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", b.HoldBun);
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", b.HoldOnion);
        }

        [Fact]
        public void HoldPeppersShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", b.HoldPeppers);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }
    }

}
