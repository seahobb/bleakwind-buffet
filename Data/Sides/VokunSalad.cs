/*
 * Author: Ethan Wheeler
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent a Vokun Salad side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Getter and setter for the private backing size variable
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Property to get side price
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.93;
                else if (size == Size.Medium)
                    return 1.28;
                else if (size == Size.Large)
                    return 1.82;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Property to get side calories
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 41;
                else if (size == Size.Medium)
                    return 52;
                else if (size == Size.Large)
                    return 73;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Gets string for side
        /// </summary>
        /// <returns>String representation of side</returns>
        public override string ToString()
        {
            return "" + size + " Vokun Salad";
        }
    }
}
