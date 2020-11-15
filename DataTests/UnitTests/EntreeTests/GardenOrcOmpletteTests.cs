/*
 * Author: Zachery Brunner
 * Edited by: Ethan Wheeler on 11/14/2020
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = true;
            });
            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingBroccoliNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Broccoli = true;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = true;
            });
            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Mushrooms = true;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = true;
            });
            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Tomato = true;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Tomato = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = true;
            });
            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Cheddar = true;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Cheddar = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItem()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = true;
            Assert.True(goo.Tomato);
            goo.Tomato = false;
            Assert.False(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(404, (double)goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);
            goo.SpecialInstructions.Clear();

            goo.Mushrooms = includeMushrooms;
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);
            goo.SpecialInstructions.Clear();

            goo.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);
            goo.SpecialInstructions.Clear();

            goo.Cheddar = includeCheddar;
            if (!includeCheddar) Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);
            goo.SpecialInstructions.Clear();
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        [Fact]
        public void NameShouldReturnToString()
        {
            ThalmorTriple x = new ThalmorTriple();
            Assert.Equal(x.ToString(), x.Name);
        }


        [Fact]
        public void ChangingBroccoliShouldChangeProperties()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Broccoli", () =>
            {
                x.Broccoli = true;
            });
            Assert.PropertyChanged(x, "Broccoli", () =>
            {
                x.Broccoli = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Broccoli = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Broccoli = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Broccoli = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Broccoli = false;
            });

        }

        [Fact]
        public void ChangingMushroomsShouldChangeProperties()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Mushrooms", () =>
            {
                x.Mushrooms = true;
            });
            Assert.PropertyChanged(x, "Mushrooms", () =>
            {
                x.Mushrooms = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mushrooms = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mushrooms = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Mushrooms = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Mushrooms = false;
            });

        }

        [Fact]
        public void ChangingTomatoShouldChangeProperties()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
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
        public void ChangingCheddarShouldChangeProperties()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Cheddar", () =>
            {
                x.Cheddar = true;
            });
            Assert.PropertyChanged(x, "Cheddar", () =>
            {
                x.Cheddar = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Cheddar = true;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Cheddar = false;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Cheddar = true;
            });
            Assert.PropertyChanged(x, "ListToString", () =>
            {
                x.Cheddar = false;
            });

        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed " +
            "with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", x.Description);
        }
    }
}