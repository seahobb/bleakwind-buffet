/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 10/1/2020
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });
            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "SpecialInstructions", () =>
            {
                mm.Ice = true;
            });
            Assert.PropertyChanged(mm, "SpecialInstructions", () =>
            {
                mm.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Small;
            });
            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Medium;
            });
            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Small;
            });
            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Medium;
            });
            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Small;
            });
            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Medium;
            });
            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", mm.SpecialInstructions);
            else Assert.Empty(mm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }

        [Fact]
        public void ChangingSizeChangedShouldChangeProperty()
        {
            MarkarthMilk x = new MarkarthMilk();
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
            MarkarthMilk x = new MarkarthMilk();
            Assert.Equal(x.ToString(), x.Name);
        }

        [Fact]
        public void ChangingIceShouldChangeProperties()
        {
            MarkarthMilk x = new MarkarthMilk();
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
            MarkarthMilk x = new MarkarthMilk();
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

        
    }
}