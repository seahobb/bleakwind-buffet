/*
 * Author: Ethan Wheeler
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent a Arentino Apple Juice drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Arentino Apple Juice
    /// </summary>
    public class ArentinoAppleJuice
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
                    return 0.62;
                else if (size == Size.Medium)
                    return 0.87;
                else if (size == Size.Large)
                    return 1.01;
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
                    return 44;
                else if (size == Size.Medium)
                    return 88;
                else if (size == Size.Large)
                    return 132;
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
                return list;
            }
        }

        /// <summary>
        /// Gets string for drink
        /// </summary>
        /// <returns>String representation of drink</returns>
        public override string ToString()
        {
            return "" + size + " Arentino Apple Juice";
        }

    }
}
