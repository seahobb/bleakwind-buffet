/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Philly Poacher 
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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

        /// <value>
        /// Getter and setter for the private backing sirloin variable
        /// </value>
        public bool Sirloin
        {
            get { return sirloin; }
            set 
            { 
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing onion variable
        /// </value>
        public bool Onion
        {
            get { return onion; }
            set 
            { 
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing roll variable
        /// </value>
        public bool Roll
        {
            get { return roll; }
            set 
            { 
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public override double Price
        {
            get { return 7.23; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public override uint Calories
        {
            get { return 784; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
        /// Converts special instructions list to a string
        /// </summary>
        public string ListToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                for (int i = 0; i < SpecialInstructions.Count; i++)
                {
                    sb.Append(SpecialInstructions[i] + " ");
                }
                sb.Append("]");
                string s = sb.ToString();
                return s;
            }
        }

        /// <summary>
        /// Property representing ToString
        /// </summary>
        public string Name
        {
            get
            {
                return this.ToString();
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
