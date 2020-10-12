/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Xunit;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesSpecialInstructionsProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Lemon = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);
            ww.SpecialInstructions.Clear();

            ww.Lemon = includeLemon;
            if (includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            ww.SpecialInstructions.Clear();
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ChangingSizeChangedShouldChangeProperty()
        {
            WarriorWater x = new WarriorWater();
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
            WarriorWater x = new WarriorWater();
            Assert.Equal(x.ToString(), x.Name);
        }

        [Fact]
        public void ChangingIceShouldChangeProperties()
        {
            WarriorWater x = new WarriorWater();
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
            WarriorWater x = new WarriorWater();
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
        public void ChangingLemonShouldChangeProperties()
        {
            WarriorWater x = new WarriorWater();
            Assert.PropertyChanged(x, "Lemon", () =>
            {
                x.Lemon = true;
            });
            Assert.PropertyChanged(x, "Lemon", () =>
            {
                x.Lemon = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Lemon = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Lemon = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Lemon = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Lemon = false;
            });

        }
    }
}
