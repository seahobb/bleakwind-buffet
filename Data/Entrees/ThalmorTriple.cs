/*
 * Author: Ethan Wheeler
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Thalmor Triple 
    /// </summary>
    public class ThalmorTriple
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

        /// <summary>
        /// Private backing bacon variable
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// Private backing egg variable
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Getter and setter for the private backing bun variable
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing ketchup variable
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing mustard variable
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing pickle variable
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing cheese variable
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing tomato variable
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing lettuce variable
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing mayo variable
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing bacon variable
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
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
        /// Property to get entree price
        /// </summary>
        public double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// Property to get entree calories
        /// </summary>
        public uint Calories
        {
            get { return 943; }
        }

        /// <summary>
        /// Property to get entree special instructions
        /// </summary>
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
                if (!tomato)
                    list.Add("Hold tomato");
                if (!lettuce)
                    list.Add("Hold lettuce");
                if (!mayo)
                    list.Add("Hold mayo");
                if (!bacon)
                    list.Add("Hold bacon");
                if (!egg)
                    list.Add("Hold egg");
                return list;
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
