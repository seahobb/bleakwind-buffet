/*
 * Author: Ethan Wheeler
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
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
        /// Private backing flavor variable
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
        /// Getter and setter for the private backing flavor variable
        /// </value>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <value>
        /// Property to get drink price
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.42;
                else if (size == Size.Medium)
                    return 1.74;
                else if (size == Size.Large)
                    return 2.07;
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
                    return 117;
                else if (size == Size.Medium)
                    return 153;
                else if (size == Size.Large)
                    return 205;
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
                return list;
            }
        }

        /// <summary>
        /// Gets string for drink
        /// </summary>
        /// <returns>String representation of drink</returns>
        public override string ToString()
        {
            return "" + size + " " + flavor + " Sailor Soda";
        }
    }
}
