using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class CretaceousComboTest
    {
        [Fact]
        public void CorrectDefaultDescription()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            Assert.Equal("Brontowurst Combo", c.Description);
        }

        [Fact]
        public void CorrectDefaultToString()
        {
            CretaceousCombo c = new CretaceousCombo(new PterodactylWings());
            Assert.Equal("Pterodactyl Wings Combo", c.Description);
        }

        [Fact]
        public void ShouldHaveThisSpecialListByDeafult()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            Assert.Collection<string>(c.Special, item =>
            {
                Assert.Equal("Small Fryceritops", item);
            },
            item =>
            {
                Assert.Equal("Small Cola Sodasaurus", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialInstructions()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Triceritots t = new Triceritots();
            Sodasaurus ss = new Sodasaurus();
            s.HoldBun();
            s.HoldKetchup();
            t.MakeMedium();
            ss.HoldIce();
            CretaceousCombo c = new CretaceousCombo(s);
            c.Side = t;
            c.Drink = ss;
            Assert.Collection<string>(c.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Medium Triceritots", item);
            },
            item =>
            {
                Assert.Equal("Small Cola Sodasaurus", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialInstructions2()
        {
            DinoNuggets d = new DinoNuggets();
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Tyrannotea t = new Tyrannotea();
            d.AddNugget();
            m.MakeLarge();
            t.MakeMedium();
            t.MakeSweet();
            t.HoldIce();
            CretaceousCombo c = new CretaceousCombo(d);
            c.Side = m;
            c.Drink = t;
            Assert.Collection<string>(c.Special, item =>
            {
                Assert.Equal("1 Extra Nuggets", item);
            },
            item =>
            {
                Assert.Equal("Large Meteor Mac and Cheese", item);
            },
            item =>
            {
                Assert.Equal("Medium Sweet Tyrannotea", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialInstructions3()
        {
            PterodactylWings p = new PterodactylWings();
            MezzorellaSticks m = new MezzorellaSticks();
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            CretaceousCombo c = new CretaceousCombo(p);
            c.Side = m;
            c.Drink = j;
            c.Size = Size.Medium;
            Assert.Collection<string>(c.Special, item =>
            {
                Assert.Equal("Medium Mezzorella Sticks", item);
            },
            item =>
            {
                Assert.Equal("Medium Jurassic Java", item);
            },
            item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }
    }
}
