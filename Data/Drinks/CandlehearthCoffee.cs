/*
 * Author: Ethan Wheeler
  * Modified On: 10/11/2020
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents a Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Private backing ice variable
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Private backing roomForCream variable
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// Private backing decaf variable
        /// </summary>
        private bool decaf = false;

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

        /// <value>
        /// Getter and setter for the private backing decaf variable
        /// </value>
        public bool Decaf
        {
            get { return decaf; }
            set 
            { 
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing roomForCream variable
        /// </value>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set 
            { 
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing ice variable
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set 
            { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing size variable
        /// </value>
        public Size Size
        {
            get { return size; }
            set 
            { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));

            }
        }

        /// <summary>
        /// Private backing variable for changed size
        /// </summary>
        private bool sizeChangedMedium = false;

        /// <summary>
        /// Getter and setter for private backing variable and notifies properties
        /// </summary>
        public bool SizeChangedMedium
        {
            get
            {
                return sizeChangedMedium;
            }
            set
            {
                sizeChangedMedium = value;
                if (sizeChangedMedium == true)
                    size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeChangedMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Private backing variable for changed size
        /// </summary>
        private bool sizeChangedSmall = false;

        /// <summary>
        /// Getter and setter for private backing variable and notifies properties
        /// </summary>
        public bool SizeChangedSmall
        {
            get
            {
                return sizeChangedSmall;
            }
            set
            {
                sizeChangedSmall = value;
                if (sizeChangedSmall == true)
                    size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeChangedSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Private backing variable for changed size
        /// </summary>
        private bool sizeChangedLarge = false;

        /// <summary>
        /// Getter and setter for private backing variable and notifies properties
        /// </summary>
        public bool SizeChangedLarge
        {
            get
            {
                return sizeChangedLarge;
            }
            set
            {
                sizeChangedLarge = value;
                if (sizeChangedLarge == true)
                    size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeChangedLarge"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <value>
        /// Property to get drink price
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 0.75;
                else if (size == Size.Medium)
                    return 1.25;
                else if (size == Size.Large)
                    return 1.75;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get drink calories
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 7;
                else if (size == Size.Medium)
                    return 10;
                else if (size == Size.Large)
                    return 20;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get drink special instructions
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
                if (ice)
                    list.Add("Add ice");
                if (roomForCream)
                    list.Add("Add cream");
                if (decaf)
                    list.Add("Make decaf");
                return list;
            }
        }

        /// <summary>
        /// Gets string for drink
        /// </summary>
        /// <returns>String representation of drink</returns>
        public override string ToString()
        {
            //if (decaf)
               // return "" + size + " Decaf Candlehearth Coffee";
            //else 
            return "" + size + " Candlehearth Coffee";
        }
    }
}
