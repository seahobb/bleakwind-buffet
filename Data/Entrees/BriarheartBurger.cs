/*
 * Author: Ethan Wheeler
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Private backing bun variable
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Private backing ketchup variable
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Private backing mustard variable
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Private backing pickle variable
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Private backing cheese variable
        /// </summary>
        private bool cheese = true;

        /// <value>
        /// Getter and setter for the private backing bun variable
        /// </value>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <value>
        /// Getter and setter for the private backing ketchup variable
        /// </value>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <value>
        /// Getter and setter for the private backing mustard variable
        /// </value>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <value>
        /// Getter and setter for the private backing pickle variable
        /// </value>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <value>
        /// Getter and setter for the private backing cheese variable
        /// </value>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public double Price
        {
            get { return 6.32; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public uint Calories
        {
            get { return 743; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                if (!bun)
                    list.Add("Hold bun");
                if (!ketchup)
                    list.Add("Hold ketchup");
                if (!mustard)
                    list.Add("Hold mustard");
                if (!pickle)
                    list.Add("Hold pickle");
                if (!cheese)
                    list.Add("Hold cheese");
                return list;
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
