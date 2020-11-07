/*
 * Author: Ethan Wheeler
 * Class name: MenuDatabase.cs
 * Purpose: Class used to represent the menu of Bleakwind Buffet for html use
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interfaces;

namespace Website
{
    /// <summary>
    /// Represents all menu items
    /// </summary>
    public static class MenuDatabase
    {
        /// <summary>
        /// List to hold all entree menu items
        /// </summary>
        private static List<IOrderItem> entrees = new List<IOrderItem>();

        /// <summary>
        /// List to hold all drink menu items
        /// </summary>
        private static List<IOrderItem> drinks = new List<IOrderItem>();

        /// <summary>
        /// List to hold all side menu items
        /// </summary>
        private static List<IOrderItem> sides = new List<IOrderItem>();
        
        /// <summary>
        /// Fires only once, when class is instantiated and adds items to above lists
        /// </summary>
        static MenuDatabase()
        {
            foreach(IOrderItem entree in Menu.Entrees())
            {
                entrees.Add(entree);
            }

            foreach (IOrderItem drink in Menu.Drinks())
            {
                drinks.Add(drink);
            }

            foreach (IOrderItem side in Menu.Sides())
            {
                sides.Add(side);
            }
        }

        /// <summary>
        /// Gets the local entree list
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees { get { return entrees; } }

        /// <summary>
        /// Gets the local drink list
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks { get { return drinks; } }

        /// <summary>
        /// Gets the local side list
        /// </summary>
        public static IEnumerable<IOrderItem> Sides { get { return sides; } }
    
        /// <summary>
        /// Holds each type of category for a order item.
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }
    }
}
