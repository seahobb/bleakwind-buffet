﻿/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 11/14/2020
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var ss = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = true;
            });
            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Ice = true;
            });
            Assert.PropertyChanged(ss, "SpecialInstructions", () =>
            {
                ss.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Small;
            });
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Medium;
            });
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Small;
            });
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Medium;
            });
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Small;
            });
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Medium;
            });
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Blackberry;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Cherry;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Grapefruit;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Lemon;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Peach;
            });
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = SodaFlavor.Watermelon;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = true;
            Assert.True(ss.Ice);
            ss.Ice = false;
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            ss.Flavor = flavor;
            Assert.Equal(name, ss.ToString());
        }

        [Fact]
        public void ChangingSizeChangedShouldChangeProperty()
        {
            SailorSoda x = new SailorSoda();
            Assert.PropertyChanged(x, "SizeChangedSmall", () =>
            {
                x.SizeChangedSmall = true;
            });
            Assert.PropertyChanged(x, "SizeChangedMedium", () =>
            {
                x.SizeChangedMedium = true;
            });
            Assert.PropertyChanged(x, "SizeChangedLarge", () =>
            {
                x.SizeChangedLarge = true;
            });
        }

        [Fact]
        public void NameShouldReturnToString()
        {
            SailorSoda x = new SailorSoda();
            Assert.Equal(x.ToString(), x.Name);
        }

        [Fact]
        public void ChangingIceShouldChangeProperties()
        {
            SailorSoda x = new SailorSoda();
            Assert.PropertyChanged(x, "Ice", () =>
            {
                x.Ice = true;
            });
            Assert.PropertyChanged(x, "Ice", () =>
            {
                x.Ice = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Ice = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Ice = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Ice = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Ice = false;
            });

        }

        [Fact]
        public void ChangingSizeShouldChangeProperties()
        {
            SailorSoda x = new SailorSoda();
            Assert.PropertyChanged(x, "Size", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Size", () =>
            {
                x.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Size", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Name", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Name", () =>
            {
                x.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Name", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Price", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Price", () =>
            {
                x.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Price", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Calories", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Calories", () =>
            {
                x.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Calories", () =>
            {
                x.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingFlavorChangedShouldChangeProperty()
        {
            SailorSoda x = new SailorSoda();
            Assert.PropertyChanged(x, "FlavorChangedCherry", () =>
            {
                x.FlavorChangedCherry = true;
            });
            Assert.PropertyChanged(x, "FlavorChangedBlackberry", () =>
            {
                x.FlavorChangedBlackberry = true;
            });
            Assert.PropertyChanged(x, "FlavorChangedGrapefruit", () =>
            {
                x.FlavorChangedGrapefruit = true;
            });
            Assert.PropertyChanged(x, "FlavorChangedLemon", () =>
            {
                x.FlavorChangedLemon = true;
            });
            Assert.PropertyChanged(x, "FlavorChangedPeach", () =>
            {
                x.FlavorChangedPeach = true;
            });
            Assert.PropertyChanged(x, "FlavorChangedWatermelon", () =>
            {
                x.FlavorChangedWatermelon = true;
            });
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            SailorSoda x = new SailorSoda();
            Assert.Equal("An old-fashioned jerked soda, carbonated " +
            "water and flavored syrup poured over a bed of crushed ice.", x.Description);
        }


    }
}
