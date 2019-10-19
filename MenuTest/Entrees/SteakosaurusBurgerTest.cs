using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", s.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", s.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void HoldBunShouldBeInSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void HoldMustardShouldBeInSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldKetchupShouldBeInSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldKetchup();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldPicklesShouldBeInSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Pickles", item);
            });
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            s.HoldKetchup();
            s.HoldMustard();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickles", item);
            });
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", s.HoldBun);
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", s.HoldPickle);
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", s.HoldMustard);
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", s.HoldKetchup);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }
    }

}
