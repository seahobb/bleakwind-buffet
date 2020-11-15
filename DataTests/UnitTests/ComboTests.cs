/*
 * Author: Ethan Wheeler
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class 
 */

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        [Fact]
        public void ShouldReturnCorrectPriceAndCalories()
        {
            Combo c = new Combo();
            SailorSoda s = new SailorSoda();
            s.Flavor = SodaFlavor.Cherry;
            s.Ice = false;
            s.Size = Size.Large;
            c.Drink = s;
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = true;
            b.Cheese = false;
            c.Entree = b;
            VokunSalad v = new VokunSalad();
            v.Size = Size.Medium;
            c.Side = v;

            uint calories = 0;
            calories += s.Calories;
            calories += b.Calories;
            calories += v.Calories;
            Assert.Equal(calories, c.Calories);

            double price = 0;
            price += s.Price;
            price += b.Price;
            price += v.Price;
            price -= 1;
            Assert.Equal(price, c.Price);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Combo c = new Combo();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            cc.Size = Size.Large;
            c.Drink = cc;
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Tomato = false;
            g.Mushrooms = false;
            c.Entree = g;
            MadOtarGrits m = new MadOtarGrits();
            m.Size = Size.Small;
            c.Side = m;

            List<string> list = new List<string>();
            list.Add("Garden Orc Omelette");
            list.Add("Hold mushrooms");
            list.Add("Hold tomato");
            list.Add("Small Mad Otar Grits");
            list.Add("Large Candlehearth Coffee");
            list.Add("Add cream");

            Assert.Equal(list, c.SpecialInstructions);
        }

        [Fact]
        public void SettingEntreeShouldChangeProperties()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Entree = new ThugsTBone();
            });
        }

        [Fact]
        public void SettingDrinkShouldChangeProperty()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = new WarriorWater();
            });
        }

        [Fact]
        public void SettingSideShouldChangeProperty()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = new MadOtarGrits();
            });
        }

        [Fact]
        public void DescriptionShouldThrowNotImplementedException()
        {
            Combo c = new Combo();
            try
            {
                string s = c.Description;
            }
            catch (System.NotImplementedException e)
            {
                Assert.Equal("The method or operation is not implemented.", e.Message);
            }
            
        }

    }
}
