/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a Fried Miraak side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Fried Miraak 
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size = Size.Small;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
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
        /// Property to get side price
        /// </value>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                    return 1.78;
                else if (size == Size.Medium)
                    return 2.01;
                else if (size == Size.Large)
                    return 2.88;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get side calories
        /// </value>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                    return 151;
                else if (size == Size.Medium)
                    return 236;
                else if (size == Size.Large)
                    return 306;
                else
                    return 0;
            }
        }

        /// <value>
        /// Property to get side special instructions
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
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
        /// Gets string for side
        /// </summary>
        /// <returns>String representation of side</returns>
        public override string ToString()
        {
            return "" + size + " Fried Miraak";
        }
    }
}
