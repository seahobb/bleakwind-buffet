/*
 * Author: Ethan Wheeler
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Thugs T-Bone 
    /// </summary>
    public class ThugsTBone
    {
        /// <value>
        /// Property to get entree price
        /// </value>
        public double Price
        {
            get { return 6.44; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public uint Calories
        {
            get { return 982; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
