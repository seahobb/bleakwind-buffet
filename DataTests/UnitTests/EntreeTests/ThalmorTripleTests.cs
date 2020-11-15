﻿/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 11/14/2020
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = true;
            });
            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bun = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = true;
            });
            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ketchup = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = true;
            });
            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mustard = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = true;
            });
            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Pickle = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = true;
            });
            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Cheese = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = true;
            });
            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Tomato = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = true;
            });
            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lettuce = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = true;
            });
            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mayo = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = true;
            });
            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bacon = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = true;
            });
            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Egg = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Egg = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(943, (double)tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Mayo = includeMayo;
            if (!includeMayo) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Bacon = includeBacon;
            if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();

            tt.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
            tt.SpecialInstructions.Clear();
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void NameShouldReturnToString()
        {
            ThalmorTriple x = new ThalmorTriple();
            Assert.Equal(x.ToString(), x.Name);
        }


        [Fact]
        public void ChangingBunShouldChangeProperties()
        {
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
            ThalmorTriple x = new ThalmorTriple();
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
        public void ChangingBaconShouldChangeProperties()
        {
            ThalmorTriple x = new ThalmorTriple();
            Assert.PropertyChanged(x, "Bacon", () =>
            {
                x.Bacon = true;
            });
            Assert.PropertyChanged(x, "Bacon", () =>
            {
                x.Bacon = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Bacon = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Bacon = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Bacon = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Bacon = false;
            });

        }

        [Fact]
        public void ChangingEggShouldChangeProperties()
        {
            ThalmorTriple x = new ThalmorTriple();
            Assert.PropertyChanged(x, "Egg", () =>
            {
                x.Egg = true;
            });
            Assert.PropertyChanged(x, "Egg", () =>
            {
                x.Egg = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Egg = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Egg = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Egg = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Egg = false;
            });

        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            ThalmorTriple x = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? " +
            "Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, " +
            "pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", x.Description);
        }
    }
}