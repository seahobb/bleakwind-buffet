﻿/*
 * Author: Ethan Wheeler
 * Modified On: 11/14/2020
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Thugs T-Bone 
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Property to get entree price
        /// </value>
        public override double Price
        {
            get { return 6.44; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public override uint Calories
        {
            get { return 982; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }

        /// <summary>
        /// Name property representing if item is a combo or not
        /// </summary>
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the description as a string
        /// </summary>
        public string Description => "Juicy T-Bone, not much else to say.";

        /// <summary>
        /// Gets string for entree
        /// </summary>
        /// <returns>String representation of entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
