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

        /// <summary>
        /// Getter and setter for the private backing decaf variable
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing roomForCream variable
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing ice variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing size variable
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Property to get drink price
        /// </summary>
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

        /// <summary>
        /// Property to get drink calories
        /// </summary>
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

        /// <summary>
        /// Property to get drink special instructions
        /// </summary>
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
