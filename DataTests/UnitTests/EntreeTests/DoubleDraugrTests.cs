/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 11/14/2020
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Bun = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Ketchup = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mustard = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Pickle = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Cheese = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Tomato = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Lettuce = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mayo = true;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mayo = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843, (double)dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();

            dd.Mayo = includeMayo;
            if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
            dd.SpecialInstructions.Clear();
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        ////////////////////////////////////

        [Fact]
        public void NameShouldReturnToString()
        {
            DoubleDraugr x = new DoubleDraugr();
            Assert.Equal(x.ToString(), x.Name);
        }


        [Fact]
        public void ChangingBunShouldChangeProperties()
        {
            DoubleDraugr x = new DoubleDraugr();
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
            DoubleDraugr x = new DoubleDraugr();
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
            DoubleDraugr x = new DoubleDraugr();
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
            DoubleDraugr x = new DoubleDraugr();
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
            DoubleDraugr x = new DoubleDraugr();
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

        [Fact]
        public void ChangingTomatoShouldChangeProperties()
        {
            DoubleDraugr x = new DoubleDraugr();
            Assert.PropertyChanged(x, "Tomato", () =>
            {
                x.Tomato = true;
            });
            Assert.PropertyChanged(x, "Tomato", () =>
            {
                x.Tomato = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Tomato = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Tomato = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Tomato = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Tomato = false;
            });

        }

        [Fact]
        public void ChangingLettuceShouldChangeProperties()
        {
            DoubleDraugr x = new DoubleDraugr();
            Assert.PropertyChanged(x, "Lettuce", () =>
            {
                x.Lettuce = true;
            });
            Assert.PropertyChanged(x, "Lettuce", () =>
            {
                x.Lettuce = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Lettuce = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Lettuce = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Lettuce = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Lettuce = false;
            });

        }

        [Fact]
        public void ChangingMayoShouldChangeProperties()
        {
            DoubleDraugr x = new DoubleDraugr();
            Assert.PropertyChanged(x, "Mayo", () =>
            {
                x.Mayo = true;
            });
            Assert.PropertyChanged(x, "Mayo", () =>
            {
                x.Mayo = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mayo = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mayo = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Mayo = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Mayo = false;
            });

        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            DoubleDraugr x = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun." +
            " Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", x.Description);
        }
    }
}