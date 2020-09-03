/*
 * Author: Ethan Wheeler
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Private backing ice variable
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Private backing roomForCream variable
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// Private backing decaf variable
        /// </summary>
        private bool decaf = false;

        /// <value>
        /// Getter and setter for the private backing decaf variable
        /// </value>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <value>
        /// Getter and setter for the private backing roomForCream variable
        /// </value>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <value>
        /// Getter and setter for the private backing ice variable
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <value>
        /// Getter and setter for the private backing size variable
        /// </value>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// Property to get drink price
        /// </value>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.75;
                else if (size == Size.Medium)
                    return 1.25;
                else if (size == Size.Large)
                    return 1.75;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get drink calories
        /// </value>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 7;
                else if (size == Size.Medium)
                    return 10;
                else if (size == Size.Large)
                    return 20;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get drink special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                if (ice)
                    list.Add("Add ice");
                if (roomForCream)
                    list.Add("Add cream");
                return list;
            }
        }

        /// <summary>
        /// Gets string for drink
        /// </summary>
        /// <returns>String representation of drink</returns>
        public override string ToString()
        {
            if (decaf)
                return "" + size + " Decaf Candlehearth Coffee";
            else 
                return "" + size + " Candlehearth Coffee";
        }
    }
}
