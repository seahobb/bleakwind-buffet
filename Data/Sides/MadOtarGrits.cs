/*
 * Author: Ethan Wheeler
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent a Mad Otar Grits side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size = Size.Small;

        /// <value>
        /// Getter and setter for the private backing size variable
        /// </value>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// Property to get side price
        /// </value>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.22;
                else if (size == Size.Medium)
                    return 1.58;
                else if (size == Size.Large)
                    return 1.93;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get side calories
        /// </value>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 105;
                else if (size == Size.Medium)
                    return 142;
                else if (size == Size.Large)
                    return 179;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get side special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                return list;
            }
        }

        /// <summary>
        /// Gets string for side
        /// </summary>
        /// <returns>String representation of side</returns>
        public override string ToString()
        {
            return "" + size + " Mad Otar Grits";
        }
    }
}
