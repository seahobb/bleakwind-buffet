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
        /// <summary>
        /// Property to get entree price
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// Property to get entree calories
        /// </summary>
        public uint Calories
        {
            get { return 982; }
        }

        /// <summary>
        /// Property to get entree special instructions
        /// </summary>
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
