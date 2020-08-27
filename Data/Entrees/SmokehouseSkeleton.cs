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

        /// <summary>
        /// Getter and setter for the private backing sausageLink variable
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing egg variable
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing hashBrowns variable
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing pancake variable
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Property to get entree price
        /// </summary>
        public double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Property to get entree calories
        /// </summary>
        public uint Calories
        {
            get { return 602; }
        }

        /// <summary>
        /// Property to get entree special instructions
        /// </summary>
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
