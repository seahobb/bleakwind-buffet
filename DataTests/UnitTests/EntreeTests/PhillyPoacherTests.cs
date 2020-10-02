﻿/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 10/1/2020
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pp);
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = true;
            });
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingSirloinNotifiesSpecialInstructionsProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Sirloin = true;
            });
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = true;
            });
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = false;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesSpecialInstructionsProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Onion = true;
            });
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Onion = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = true;
            });
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesSpecialInstructionsProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Roll = true;
            });
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Roll = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784, (double)pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            if (!includeSirloin) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            else Assert.Empty(pp.SpecialInstructions);
            pp.SpecialInstructions.Clear();

            pp.Onion = includeOnion;
            if (!includeOnion) Assert.Contains("Hold onions", pp.SpecialInstructions);
            else Assert.Empty(pp.SpecialInstructions);
            pp.SpecialInstructions.Clear();

            pp.Roll = includeRoll;
            if (!includeRoll) Assert.Contains("Hold roll", pp.SpecialInstructions);
            else Assert.Empty(pp.SpecialInstructions);
            pp.SpecialInstructions.Clear();
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}