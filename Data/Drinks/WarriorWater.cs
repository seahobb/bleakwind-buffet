/*
 * Author: Ethan Wheeler
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
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

        /// <value>
        /// Getter and setter for the private backing lemon variable
        /// </value>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
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
        public override double Price
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

        /// <value>
        /// Property to get drink calories
        /// </value>
        public override uint Calories
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

        /// <value>
        /// Property to get drink special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
