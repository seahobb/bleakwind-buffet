/*
 * Author: Ethan Wheeler
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent a Garden Orc Omelette entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette 
    {
        /// <summary>
        /// Private backing broccoli variable
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// Private backing mushrooms variable
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// Private backing tomato variable
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Private backing cheddar variable
        /// </summary>
        private bool cheddar = true;

        /// <value>
        /// Getter and setter for the private backing broccoli variable
        /// </value>
        public bool Broccoli
        {
            get { return broccoli; } 
            set { broccoli = value; }
        }

        /// <value>
        /// Getter and setter for the private backing mushrooms variable
        /// </value>
        public bool Mushrooms
        {
            get { return mushrooms; } 
            set { mushrooms = value; }
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
        /// Getter and setter for the private backing cheddar variable
        /// </value>
        public bool Cheddar
        {
            get { return cheddar; } 
            set { cheddar = value; }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public double Price
        {
            get { return 4.57; } 
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public uint Calories 
        {
            get { return 404; } 
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                if (!broccoli)
                    list.Add("Hold broccoli");
                if (!mushrooms)
                    list.Add("Hold mushrooms");
                if (!tomato)
                    list.Add("Hold tomato");
                if (!cheddar)
                    list.Add("Hold cheddar");
                return list;
            }
        }

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
