/*
 * Author: Ethan Wheeler
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Smokehouse Skeleton 
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Private backing sausageLink variable
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Private backing egg variable
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Private backing hashBrowns variable
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Private backing pancake variable
        /// </summary>
        private bool pancake = true;

        /// <value>
        /// Getter and setter for the private backing sausageLink variable
        /// </value>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <value>
        /// Getter and setter for the private backing egg variable
        /// </value>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <value>
        /// Getter and setter for the private backing hashBrowns variable
        /// </value>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }

        /// <value>
        /// Getter and setter for the private backing pancake variable
        /// </value>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public double Price
        {
            get { return 5.62; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public uint Calories
        {
            get { return 602; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                if (!sausageLink)
                    list.Add("Hold sausage");
                if (!egg)
                    list.Add("Hold eggs");
                if (!hashBrowns)
                    list.Add("Hold hash browns");
                if (!pancake)
                    list.Add("Hold pancakes");
                return list;
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
