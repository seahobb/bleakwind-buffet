/*
 * Author: Ethan Wheeler
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a Fried Miraak side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Fried Miraak 
    /// </summary>
    public class FriedMiraak
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
                    return 1.78;
                else if (size == Size.Medium)
                    return 2.01;
                else if (size == Size.Large)
                    return 2.88;
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
                    return 151;
                else if (size == Size.Medium)
                    return 236;
                else if (size == Size.Large)
                    return 306;
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
            return "" + size + " Fried Miraak";
        }
    }
}
