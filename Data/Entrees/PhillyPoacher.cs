/*
 * Author: Ethan Wheeler
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Philly Poacher 
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// Private backing sirloin variable
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// Private backing onion variable
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Private backing roll variable
        /// </summary>
        private bool roll = true;

        /// <value>
        /// Getter and setter for the private backing sirloin variable
        /// </value>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <value>
        /// Getter and setter for the private backing onion variable
        /// </value>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <value>
        /// Getter and setter for the private backing roll variable
        /// </value>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public double Price
        {
            get { return 7.23; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public uint Calories
        {
            get { return 784; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                if (!sirloin)
                    list.Add("Hold sirloin");
                if (!onion)
                    list.Add("Hold onions");
                if (!roll)
                    list.Add("Hold roll");
                return list;
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
