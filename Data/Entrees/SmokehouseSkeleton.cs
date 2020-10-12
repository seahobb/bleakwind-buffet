/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Smokehouse Skeleton 
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
            set 
            { 
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing egg variable
        /// </value>
        public bool Egg
        {
            get { return egg; }
            set 
            { 
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing hashBrowns variable
        /// </value>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set 
            { 
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing pancake variable
        /// </value>
        public bool Pancake
        {
            get { return pancake; }
            set 
            { 
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public override double Price
        {
            get { return 5.62; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public override uint Calories
        {
            get { return 602; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
            return "Smokehouse Skeleton";
        }
    }
}
