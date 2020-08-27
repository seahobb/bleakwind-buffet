/*
 * Author: Ethan Wheeler
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Private backing ice variable
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Private backing lemon variable
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// Getter and setter for the private backing lemon variable
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
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
                    return 0.00;
                else if (size == Size.Medium)
                    return 0.00;
                else if (size == Size.Large)
                    return 0.00;
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
                    return 0;
                else if (size == Size.Medium)
                    return 0;
                else if (size == Size.Large)
                    return 0;
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
                if (!ice)
                    list.Add("Hold ice");
                if (lemon)
                    list.Add("Add lemon");
                return list;
            }
        }

        /// <summary>
        /// Gets string for drink
        /// </summary>
        /// <returns>String representation of drink</returns>
        public override string ToString()
        {
            return "" + size + " Warrior Water";
        }
    }
}
