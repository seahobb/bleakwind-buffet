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

        /// <summary>
        /// Getter and setter for the private backing broccoli variable
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; } 
            set { broccoli = value; }
        }

        /// <summary>
        /// Getter and setter for the private backing mushrooms variable
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; } 
            set { mushrooms = value; }
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
        /// Getter and setter for the private backing cheddar variable
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; } 
            set { cheddar = value; }
        }

        /// <summary>
        /// Property to get entree price
        /// </summary>
        public double Price
        {
            get { return 4.57; } 
        }

        /// <summary>
        /// Property to get entree calories
        /// </summary>
        public uint Calories 
        {
            get { return 404; } 
        }

        /// <summary>
        /// Property to get entree special instructions
        /// </summary>
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
