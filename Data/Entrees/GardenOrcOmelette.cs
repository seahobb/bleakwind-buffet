﻿/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent a Garden Orc Omelette entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
            set 
            { 
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing mushrooms variable
        /// </value>
        public bool Mushrooms
        {
            get { return mushrooms; } 
            set 
            { 
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing tomato variable
        /// </value>
        public bool Tomato
        {
            get { return tomato; } 
            set 
            { 
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing cheddar variable
        /// </value>
        public bool Cheddar
        {
            get { return cheddar; } 
            set 
            { 
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Property to get entree price
        /// </value>
        public override double Price
        {
            get { return 4.57; } 
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public override uint Calories 
        {
            get { return 404; } 
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
