using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", t.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", t.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void HoldBunShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void HoldKetchupShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldKetchup();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldMustardShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMustard();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldPickleShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldPickle();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Pickles", item);
            });
        }

        [Fact]
        public void HoldTomatoShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldTomato();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Tomato", item);
            });
        }

        [Fact]
        public void HoldOnionShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldOnion();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }

        [Fact]
        public void HoldLettuceShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldLettuce();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }

        [Fact]
        public void HoldMayoShouldBeInSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMayo();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Mayo", item);
            });
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            t.HoldKetchup();
            t.HoldMustard();
            t.HoldPickle();
            t.HoldTomato();
            t.HoldOnion();
            t.HoldLettuce();
            t.HoldMayo();
            Assert.Collection<string>(t.Special, item =>
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
            },
            item =>
            {
                Assert.Equal("Hold Tomato", item);
            },
            item =>
            {
                Assert.Equal("Hold Onion", item);
            },
            item =>
            {
                Assert.Equal("Hold Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Mayo", item);
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
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldPickle);
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldMustard);
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldKetchup);
        }

        [Fact]
        public void HoldMayoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldMayo);
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldLettuce);
        }

        [Fact]
        public void HoldTomatoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldTomato);
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", t.HoldOnion);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

    }

}
