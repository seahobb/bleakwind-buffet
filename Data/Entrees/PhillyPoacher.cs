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

        /// <summary>
        /// Getter and setter for the private backing sirloin variable
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing onion variable
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing roll variable
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <summary>
        /// Property to get entree price
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Property to get entree calories
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// Property to get entree special instructions
        /// </summary>
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
