/*
 * Author: Ethan Wheeler
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class 
 */

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnListOfAllEntrees()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();

            Assert.Collection(entrees,
                item => Assert.Equal(entrees.ElementAt(0), item),
                item => Assert.Equal(entrees.ElementAt(1), item),
                item => Assert.Equal(entrees.ElementAt(2), item),
                item => Assert.Equal(entrees.ElementAt(3), item),
                item => Assert.Equal(entrees.ElementAt(4), item),
                item => Assert.Equal(entrees.ElementAt(5), item),
                item => Assert.Equal(entrees.ElementAt(6), item)
            );
        }

        [Fact]
        public void ShouldReturnListOfAllSides()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();

            Assert.Collection(sides,
                item => Assert.Equal(sides.ElementAt(0), item),
                item => Assert.Equal(sides.ElementAt(1), item),
                item => Assert.Equal(sides.ElementAt(2), item),
                item => Assert.Equal(sides.ElementAt(3), item),
                item => Assert.Equal(sides.ElementAt(4), item),
                item => Assert.Equal(sides.ElementAt(5), item),
                item => Assert.Equal(sides.ElementAt(6), item),
                item => Assert.Equal(sides.ElementAt(7), item),
                item => Assert.Equal(sides.ElementAt(8), item),
                item => Assert.Equal(sides.ElementAt(9), item),
                item => Assert.Equal(sides.ElementAt(10), item),
                item => Assert.Equal(sides.ElementAt(11), item)
            );
        }

        [Fact]
        public void ShouldReturnListOfAllDrinks()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();

            Assert.Collection(drinks,
                item => Assert.Equal(drinks.ElementAt(0), item),
                item => Assert.Equal(drinks.ElementAt(1), item),
                item => Assert.Equal(drinks.ElementAt(2), item),
                item => Assert.Equal(drinks.ElementAt(3), item),
                item => Assert.Equal(drinks.ElementAt(4), item),
                item => Assert.Equal(drinks.ElementAt(5), item),
                item => Assert.Equal(drinks.ElementAt(6), item),
                item => Assert.Equal(drinks.ElementAt(7), item),
                item => Assert.Equal(drinks.ElementAt(8), item),
                item => Assert.Equal(drinks.ElementAt(9), item),
                item => Assert.Equal(drinks.ElementAt(10), item),
                item => Assert.Equal(drinks.ElementAt(11), item),
                item => Assert.Equal(drinks.ElementAt(12), item),
                item => Assert.Equal(drinks.ElementAt(13), item),
                item => Assert.Equal(drinks.ElementAt(14), item),
                item => Assert.Equal(drinks.ElementAt(15), item),
                item => Assert.Equal(drinks.ElementAt(16), item),
                item => Assert.Equal(drinks.ElementAt(17), item),
                item => Assert.Equal(drinks.ElementAt(18), item),
                item => Assert.Equal(drinks.ElementAt(19), item),
                item => Assert.Equal(drinks.ElementAt(20), item),
                item => Assert.Equal(drinks.ElementAt(21), item),
                item => Assert.Equal(drinks.ElementAt(22), item),
                item => Assert.Equal(drinks.ElementAt(23), item),
                item => Assert.Equal(drinks.ElementAt(24), item),
                item => Assert.Equal(drinks.ElementAt(25), item),
                item => Assert.Equal(drinks.ElementAt(26), item),
                item => Assert.Equal(drinks.ElementAt(27), item),
                item => Assert.Equal(drinks.ElementAt(28), item),
                item => Assert.Equal(drinks.ElementAt(29), item)
            );
        }

        [Fact]
        public void ShouldReturnListOfAllMenuItems()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
      
            Assert.Collection(menu,
                item => Assert.Equal(menu.ElementAt(0), item),
                item => Assert.Equal(menu.ElementAt(1), item),
                item => Assert.Equal(menu.ElementAt(2), item),
                item => Assert.Equal(menu.ElementAt(3), item),
                item => Assert.Equal(menu.ElementAt(4), item),
                item => Assert.Equal(menu.ElementAt(5), item),
                item => Assert.Equal(menu.ElementAt(6), item),
                item => Assert.Equal(menu.ElementAt(7), item),
                item => Assert.Equal(menu.ElementAt(8), item),
                item => Assert.Equal(menu.ElementAt(9), item),
                item => Assert.Equal(menu.ElementAt(10), item),
                item => Assert.Equal(menu.ElementAt(11), item),
                item => Assert.Equal(menu.ElementAt(12), item),
                item => Assert.Equal(menu.ElementAt(13), item),
                item => Assert.Equal(menu.ElementAt(14), item),
                item => Assert.Equal(menu.ElementAt(15), item),
                item => Assert.Equal(menu.ElementAt(16), item),
                item => Assert.Equal(menu.ElementAt(17), item),
                item => Assert.Equal(menu.ElementAt(18), item),
                item => Assert.Equal(menu.ElementAt(19), item),
                item => Assert.Equal(menu.ElementAt(20), item),
                item => Assert.Equal(menu.ElementAt(21), item),
                item => Assert.Equal(menu.ElementAt(22), item),
                item => Assert.Equal(menu.ElementAt(23), item),
                item => Assert.Equal(menu.ElementAt(24), item),
                item => Assert.Equal(menu.ElementAt(25), item),
                item => Assert.Equal(menu.ElementAt(26), item),
                item => Assert.Equal(menu.ElementAt(27), item),
                item => Assert.Equal(menu.ElementAt(28), item),
                item => Assert.Equal(menu.ElementAt(29), item),
                item => Assert.Equal(menu.ElementAt(30), item),
                item => Assert.Equal(menu.ElementAt(31), item),
                item => Assert.Equal(menu.ElementAt(32), item),
                item => Assert.Equal(menu.ElementAt(33), item),
                item => Assert.Equal(menu.ElementAt(34), item),
                item => Assert.Equal(menu.ElementAt(35), item),
                item => Assert.Equal(menu.ElementAt(36), item),
                item => Assert.Equal(menu.ElementAt(37), item),
                item => Assert.Equal(menu.ElementAt(38), item),
                item => Assert.Equal(menu.ElementAt(39), item),
                item => Assert.Equal(menu.ElementAt(40), item),
                item => Assert.Equal(menu.ElementAt(41), item),
                item => Assert.Equal(menu.ElementAt(42), item),
                item => Assert.Equal(menu.ElementAt(43), item),
                item => Assert.Equal(menu.ElementAt(44), item),
                item => Assert.Equal(menu.ElementAt(45), item),
                item => Assert.Equal(menu.ElementAt(46), item),
                item => Assert.Equal(menu.ElementAt(47), item),
                item => Assert.Equal(menu.ElementAt(48), item)
            );
        }
    }
}
