/*
 * Author: Ethan Wheeler
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent a Double Draugr entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
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

        /// <summary>
        /// Private backing tomato variable
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Private backing lettuce variable
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Private backing mayo variable
        /// </summary>
        private bool mayo = true;

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
        /// Getter and setter for the private backing tomato variable
        /// </value>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <value>
        /// Getter and setter for the private backing lettuce variable
        /// </value>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <value>
        /// Getter and setter for the private backing mayo variable
        /// </value>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public override double Price
        {
            get { return 7.32; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public override uint Calories
        {
            get { return 843; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
                if (!tomato)
                    list.Add("Hold tomato");
                if (!lettuce)
                    list.Add("Hold lettuce");
                if (!mayo)
                    list.Add("Hold mayo");
                return list;
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
