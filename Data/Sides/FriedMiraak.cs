/*
 * Author: Ethan Wheeler
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a Fried Miraak side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Fried Miraak 
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
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
        public override double Price
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

        /// <value>
        /// Property to get side calories
        /// </value>
        public override uint Calories
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

        /// <value>
        /// Property to get side special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
            return "" + size + " Fried Miraak";
        }
    }
}
