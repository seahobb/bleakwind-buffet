/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 10/1/2020
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Bun = true;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = true;
            });
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Ketchup = true;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Mustard = true;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = true;
            });
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Pickle = true;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Cheese = true;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Cheese = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = true;
            Assert.True(bb.Bun);
            bb.Bun = false;
            Assert.False(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = true;
            Assert.True(bb.Mustard);
            bb.Mustard = false;
            Assert.False(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = true;
            Assert.True(bb.Pickle);
            bb.Pickle = false;
            Assert.False(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = true;
            Assert.True(bb.Cheese);
            bb.Cheese = false;
            Assert.False(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(743, (double)bb.Calories); 
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", bb.SpecialInstructions);
            else Assert.Empty(bb.SpecialInstructions);
            bb.SpecialInstructions.Clear();

            bb.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            else Assert.Empty(bb.SpecialInstructions);
            bb.SpecialInstructions.Clear();

            bb.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", bb.SpecialInstructions);
            else Assert.Empty(bb.SpecialInstructions);
            bb.SpecialInstructions.Clear();

            bb.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", bb.SpecialInstructions);
            else Assert.Empty(bb.SpecialInstructions);
            bb.SpecialInstructions.Clear();

            bb.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", bb.SpecialInstructions);
            else Assert.Empty(bb.SpecialInstructions);
            bb.SpecialInstructions.Clear();
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }

        
        /// ///////////////////////////////////////////////
        

        [Fact]
        public void NameShouldReturnToString()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.Equal(x.ToString(), x.Name);
        }


        [Fact]
        public void ChangingBunShouldChangeProperties()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.PropertyChanged(x, "Bun", () =>
            {
                x.Bun = true;
            });
            Assert.PropertyChanged(x, "Bun", () =>
            {
                x.Bun = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Bun = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Bun = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Bun = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Bun = false;
            });

        }

        [Fact]
        public void ChangingKetchupShouldChangeProperties()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.PropertyChanged(x, "Ketchup", () =>
            {
                x.Ketchup = true;
            });
            Assert.PropertyChanged(x, "Ketchup", () =>
            {
                x.Ketchup = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Ketchup = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Ketchup = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Ketchup = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Ketchup = false;
            });

        }

        [Fact]
        public void ChangingMustardShouldChangeProperties()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.PropertyChanged(x, "Mustard", () =>
            {
                x.Mustard = true;
            });
            Assert.PropertyChanged(x, "Mustard", () =>
            {
                x.Mustard = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mustard = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mustard = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Mustard = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Mustard = false;
            });

        }

        [Fact]
        public void ChangingPickleShouldChangeProperties()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.PropertyChanged(x, "Pickle", () =>
            {
                x.Pickle = true;
            });
            Assert.PropertyChanged(x, "Pickle", () =>
            {
                x.Pickle = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Pickle = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Pickle = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Pickle = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Pickle = false;
            });

        }

        [Fact]
        public void ChangingCheeseShouldChangeProperties()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.PropertyChanged(x, "Cheese", () =>
            {
                x.Cheese = true;
            });
            Assert.PropertyChanged(x, "Cheese", () =>
            {
                x.Cheese = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Cheese = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Cheese = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Cheese = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Cheese = false;
            });

        }
    }
}
 