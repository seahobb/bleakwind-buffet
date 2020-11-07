/*
 * Author: Ethan Wheeler
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class 
 */

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnListOfAllEntrees()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();

            Assert.Equal(7, entrees.Count());

            Assert.Collection(entrees,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString())
            );
        }

        [Fact]
        public void ShouldReturnListOfAllSides()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();

            Assert.Equal(12, sides.Count());

            Assert.Collection(sides,
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
            );
        }

        [Fact]
        public void ShouldReturnListOfAllDrinks()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();

            Assert.Equal(30, drinks.Count());

            Assert.Collection(drinks,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
            );
        }

        [Fact]
        public void ShouldReturnListOfAllMenuItems()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu(); 

            Assert.Equal(49, menu.Count());

            Assert.Collection(menu,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
            );
        }

        [Fact]
        public void SearchResultShouldContainCorrectItems()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            List<IOrderItem> list = (List<IOrderItem>)menu;


            var result = Menu.Search("earth"); //partial search for Candlehearth
            

            if (result != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem item in result)
                {
                    sb.Append(item.ToString());
                    sb.Append(" ");
                }
                string allSearchResults = sb.ToString();

                StringBuilder sb1 = new StringBuilder();
                foreach (IOrderItem item in list)
                {
                    sb1.Append(item.ToString());
                    sb1.Append(" ");
                }
                string allMenuItems = sb1.ToString();

                Assert.Contains(allSearchResults, allMenuItems);
            }
        }

        [Fact]
        public void ShouldReturnAllIfSearchIsNull()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            List<IOrderItem> list = (List<IOrderItem>)menu;
            var result = Menu.Search(null);

            if (result != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem item in result)
                {
                    sb.Append(item.ToString());
                    sb.Append(" ");
                }
                string allSearchResults = sb.ToString();

                StringBuilder sb1 = new StringBuilder();
                foreach (IOrderItem item in list)
                {
                    sb1.Append(item.ToString());
                    sb1.Append(" ");
                }
                string allMenuItems = sb1.ToString();

                Assert.Contains(allSearchResults, allMenuItems);
            }

        }

        [Fact]
        public void ShouldFilterByCategory()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            List<IOrderItem> list = (List<IOrderItem>)entrees;
            var result = Menu.Search(""); //returns all menu items

            var categories = new List<string>();
            categories.Add("Entrees"); 

            var filteredResult = Menu.FilterByCategory(result, categories);


            Assert.Equal(filteredResult.Count(), list.Count()); 



            if (filteredResult != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem item in filteredResult)
                {
                    sb.Append(item.ToString());
                    sb.Append(" ");
                }
                string allSearchResults = sb.ToString();

                StringBuilder sb1 = new StringBuilder();
                foreach (IOrderItem item in list)
                {
                    sb1.Append(item.ToString());
                    sb1.Append(" ");
                }
                string allMenuItems = sb1.ToString();

                Assert.Contains(allSearchResults, allMenuItems);
            }

        }

        [Fact]
        public void ShouldFilterByCalories()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            List<IOrderItem> list = (List<IOrderItem>)menu;
            var result = Menu.Search(""); //returns all menu items

            int min = 0;
            int max = 1;

            var filteredResult = Menu.FilterByCalories(result, min, max);


            Assert.Equal(3, filteredResult.Count()); //only should be water (small, med, large)



            if (filteredResult != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem item in filteredResult)
                {
                    sb.Append(item.ToString());
                    sb.Append(" ");
                }
                string allSearchResults = sb.ToString();

                StringBuilder sb1 = new StringBuilder();
                foreach (IOrderItem item in Menu.Drinks())
                {
                    if (item.Calories == 0) //only water
                    {
                        sb1.Append(item.ToString());
                        sb1.Append(" ");
                    }
                }
                string water = sb1.ToString();

                Assert.Contains(allSearchResults, water);
            }

        }

        [Fact]
        public void ShouldFilterByPrice()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            List<IOrderItem> list = (List<IOrderItem>)menu;
            var result = Menu.Search(""); //returns all menu items

            int min = 4;
            int max = 10;

            var filteredResult = Menu.FilterByPrice(result, min, max);


            Assert.Equal(7, filteredResult.Count()); //only should be all entree items



            if (filteredResult != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem item in filteredResult)
                {
                    sb.Append(item.ToString());
                    sb.Append(" ");
                }
                string allSearchResults = sb.ToString();

                StringBuilder sb1 = new StringBuilder();
                foreach (IOrderItem item in Menu.Entrees())
                {
                    sb1.Append(item.ToString());
                    sb1.Append(" ");
                }
                string entreeItems = sb1.ToString();

                Assert.Contains(allSearchResults, entreeItems);
            }

        }
    }
}
