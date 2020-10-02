﻿/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent a Dragonborn Waffle Fries side
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
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
                    return 0.42;
                else if (size == Size.Medium)
                    return 0.76;
                else if (size == Size.Large)
                    return 0.96;
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
                    return 77;
                else if (size == Size.Medium)
                    return 89;
                else if (size == Size.Large)
                    return 100;
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
        /// Gets string for side
        /// </summary>
        /// <returns>String representation of side</returns>
        public override string ToString()
        {
            return "" + size + " Dragonborn Waffle Fries"; 
        }
    }
}
