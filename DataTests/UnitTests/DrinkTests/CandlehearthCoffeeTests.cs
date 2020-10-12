/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 9/30/2020
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using NuGet.Frameworks;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cc);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Decaf", () =>
            {
                cc.Decaf = true;
            });
            Assert.PropertyChanged(cc, "Decaf", () =>
            {
                cc.Decaf = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "RoomForCream", () =>
            {
                cc.RoomForCream = true;
            });
            Assert.PropertyChanged(cc, "RoomForCream", () =>
            {
                cc.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesSpecialInstructionsProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.RoomForCream = true;
            });
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Ice", () =>
            {
                cc.Ice = true;
            });
            Assert.PropertyChanged(cc, "Ice", () =>
            {
                cc.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.Ice = true;
            });
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", cc.SpecialInstructions);
            else Assert.Empty(cc.SpecialInstructions);
            cc.SpecialInstructions.Clear();
            cc.RoomForCream = includeCream;
            if (includeCream) Assert.Contains("Add cream", cc.SpecialInstructions);
            cc.SpecialInstructions.Clear();
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            cc.Decaf = decaf;
            Assert.Equal(name, cc.ToString());
        }

        [Fact]
        public void ChangingSizeChangedShouldChangeProperty()
        {
            CandlehearthCoffee x = new CandlehearthCoffee();
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
            CandlehearthCoffee x = new CandlehearthCoffee();
            Assert.Equal(x.ToString(), x.Name);
        }

        [Fact]
        public void ChangingIceShouldChangeProperties()
        {
            CandlehearthCoffee x = new CandlehearthCoffee();
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
            CandlehearthCoffee x = new CandlehearthCoffee();
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
        public void ChangingCreamShouldChangeProperties()
        {
            CandlehearthCoffee x = new CandlehearthCoffee();
            Assert.PropertyChanged(x, "RoomForCream", () =>
            {
                x.RoomForCream = true;
            });
            Assert.PropertyChanged(x, "RoomForCream", () =>
            {
                x.RoomForCream = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.RoomForCream = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.RoomForCream = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.RoomForCream = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.RoomForCream = false;
            });

        }

        [Fact]
        public void ChangingDecafShouldChangeProperties()
        {
            CandlehearthCoffee x = new CandlehearthCoffee();
            Assert.PropertyChanged(x, "Decaf", () =>
            {
                x.Decaf = true;
            });
            Assert.PropertyChanged(x, "Decaf", () =>
            {
                x.Decaf = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Decaf = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Decaf = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Decaf = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Decaf = false;
            });

        }
    }
}
