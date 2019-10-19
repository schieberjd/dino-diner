using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            VelociWrap v = new VelociWrap();
            Assert.Equal("Veloci-Wrap", v.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            VelociWrap v = new VelociWrap();
            Assert.Equal("Veloci-Wrap", v.ToString());
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDeafult()
        {
            VelociWrap v = new VelociWrap();
            Assert.Empty(v.Special);
        }

        [Fact]
        public void HoldCheeseShouldBeInSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Cheese", item);
            });
        }

        [Fact]
        public void HoldLettuceShouldBeInSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldLettuce();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }

        [Fact]
        public void HoldDressingShouldBeInSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldDressing();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Dressing", item);
            });
        }

        [Fact]
        public void SpecialShouldContainNeccessaryInstructions()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            v.HoldDressing();
            v.HoldLettuce();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Cheese", item);
            },
            item =>
            {
                Assert.Equal("Hold Dressing", item);
            },
            item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }

        [Fact]
        public void HoldCheeseShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", v.HoldCheese);
        }

        [Fact]
        public void HoldDressingShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", v.HoldDressing);
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", v.HoldLettuce);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }
    }
}
