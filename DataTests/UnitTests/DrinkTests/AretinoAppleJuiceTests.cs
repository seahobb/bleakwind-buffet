﻿/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 11/14/2020
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Size", () =>
            {
                aj.Size = Size.Small;
            });
            Assert.PropertyChanged(aj, "Size", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Size", () =>
            {
                aj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty() 
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Small;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Calories", () =>
            {
                aj.Size = Size.Small;
            });
            Assert.PropertyChanged(aj, "Calories", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Calories", () =>
            {
                aj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "SpecialInstructions", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "SpecialInstructions", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }

       
        [Fact]
        public void ChangingSizeChangedShouldChangeProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "SizeChangedSmall", () =>
            {
                aj.SizeChangedSmall = true;
            });
            Assert.PropertyChanged(aj, "SizeChangedMedium", () =>
            {
                aj.SizeChangedMedium = true;
            });
            Assert.PropertyChanged(aj, "SizeChangedLarge", () =>
            {
                aj.SizeChangedLarge = true;
            });
        }

        [Fact]
        public void NameShouldReturnToString()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(aj.ToString(), aj.Name);
        }

        [Fact]
        public void ChangingIceShouldChangeProperties()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
            Assert.PropertyChanged(aj, "SpecialInstructions", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "SpecialInstructions", () =>
            {
                aj.Ice = false;
            });
            Assert.PropertyChanged(aj, "ListToString", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "ListToString", () =>
            {
                aj.Ice = false;
            });

        }
        
        [Fact]
        public void ChangingSizeShouldChangeProperties()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Size", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Size", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Size", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Name", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Name", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Name", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Calories", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(aj, "Calories", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Calories", () =>
            {
                aj.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", aj.Description);
        }

        //how to know if to use these tests above:
        //ice (invoke)
        //size (invoke)

        //ice, more properties to notify that are unique to each menu item...
    }
}