/*
 * Author: Ethan Wheeler
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class 
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
using Xunit.Sdk;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }

        [Fact]
        public void ClassShouldImplementINotifyCollectionChangedInterface()
        {
            var o = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }

        [Fact]
        public void ClassShouldImplementObservableCollectionChangedInterface()
        {
            var o = new Order();
            Assert.IsAssignableFrom<ObservableCollection<IOrderItem>>(o);
        }

        [Fact]
        public void ClassShouldImplementICollectionChangedInterface()
        {
            var o = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(o);
        }

        [Fact]
        public void ShouldGiveCorrectPropertyValues()//calories, order, combo, price, number
        {
            Order o = new Order();
            var b = new BriarheartBurger();
            o.Add(b);

            Combo c = new Combo();
            var entree = new GardenOrcOmelette();
            entree.Broccoli = false;
            c.Entree = entree;
            var mog = new MadOtarGrits();
            mog.Size = Size.Small;
            c.Side = mog;
            var cc = new CandlehearthCoffee();
            cc.Size = Size.Medium;
            c.Drink = cc;

            //o.Add(c);
            

            var dd = new DoubleDraugr();
            o.Add(dd);

           // Assert.Equal((uint)1, o.Number);

            double subtotal = b.Price + dd.Price; //+ c.Price;
            double tax = subtotal * 0.12;
            Assert.Equal(0.12, o.SalesTaxRate);
            Assert.Equal(subtotal, o.Subtotal); 
            Assert.Equal(Math.Round(tax, 2), o.Tax);
            Assert.Equal(Math.Round(subtotal + tax, 2), o.Total);

            uint calories = b.Calories + dd.Calories; //+ o.Calories;
            Assert.Equal(calories, o.Calories); 

            

        }

        [Fact]
        public void AddingItemNotifiesSubtotalProperty() 
        {
            Order o = new Order();
            
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(new AretinoAppleJuice());
                o.Add(new CandlehearthCoffee());
            });
            
        }
        [Fact]
        public void AddingItemNotifiesTaxProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(new AretinoAppleJuice());
                o.Add(new CandlehearthCoffee());
            });

        }
        [Fact]
        public void AddingItemNotifiesTotalProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(new AretinoAppleJuice());
                o.Add(new CandlehearthCoffee());
            });

        }
    
        [Fact]
        public void AddingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Add(new AretinoAppleJuice());
                o.Add(new CandlehearthCoffee());
            });

        }

        [Fact]
        public void RemovingItemRemovesFromOrder()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);
            o.Remove(vs);
            Assert.True(o.Count == 0);
        }

        [Fact]
        public void AddingItemAddsToOrder()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);
            Assert.True(o.Count == 1);
        }

        [Fact]
        public void ReplacingItemReplacesFromOrder()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);
            o.Remove(vs);
            o.Add(new BriarheartBurger());
            Assert.True(o.Count == 1);
        }

        [Fact]
        public void RemovingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);

            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Remove(vs);
            });

        }
        [Fact]
        public void RemovingItemNotifiesTaxProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Remove(vs);
            });

        }
        [Fact]
        public void RemovingItemNotifiesTotalProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);

            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Remove(vs);
            });

        }

        [Fact]
        public void RemovingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            o.Add(vs);

            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Remove(vs);
            });

        }

        [Fact]
        public void ReplacingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            MadOtarGrits mog = new MadOtarGrits();

            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(vs);
                o.Remove(vs);
                o.Add(mog);
            });

        }
        [Fact]
        public void ReplacingItemNotifiesTaxProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            MadOtarGrits mog = new MadOtarGrits();

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(vs);
                o.Remove(vs);
                o.Add(mog);
            });

        }
        [Fact]
        public void ReplacingItemNotifiesTotalProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            MadOtarGrits mog = new MadOtarGrits();

            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(vs);
                o.Remove(vs);
                o.Add(mog);
            });

        }

        [Fact]
        public void ReplacingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();
            VokunSalad vs = new VokunSalad();
            MadOtarGrits mog = new MadOtarGrits();
            
            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Add(vs);
                o.Remove(vs);
                o.Add(mog);
            });
        }

        //replacing...


    }
}
