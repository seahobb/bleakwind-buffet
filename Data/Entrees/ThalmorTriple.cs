/*
 * Author: Ethan Wheeler
 * Modified On: 11/14/2020
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Thalmor Triple 
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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

        /// <value>
        /// Getter and setter for the private backing bun variable
        /// </value>
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing ketchup variable
        /// </value>
        public bool Ketchup
        {
            get { return ketchup; }
            set 
            { 
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing mustard variable
        /// </value>
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing pickle variable
        /// </value>
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing cheese variable
        /// </value>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing lettuce variable
        /// </value>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing mayo variable
        /// </value>
        public bool Mayo
        {
            get { return mayo; }
            set 
            { 
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListToString"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing bacon variable
        /// </value>
        public bool Bacon
        {
            get { return bacon; }
            set 
            { 
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
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
        /// Property to get entree price
        /// </value>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <value>
        /// Property to get entree calories
        /// </value>
        public override uint Calories
        {
            get { return 943; }
        }

        /// <value>
        /// Property to get entree special instructions
        /// </value>
        public override List<String> SpecialInstructions
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
        /// Private backing variable default for if the item is combo
        /// </summary>
        private bool isACombo = false;

        /// <summary>
        /// Property that if set to true, determines if item is a combo
        /// </summary>
        public bool IsACombo
        {
            get { return isACombo; }
            set { isACombo = value; }
        }

        /// <summary>
        /// Name property representing if item is a combo or not
        /// </summary>
        public string Name
        {
            get
            {
                if (isACombo)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(this.ToString());
                    sb.Append(" ((Combo))");
                    return sb.ToString();
                }
                else
                    return this.ToString();

            }
        }

        /// <summary>
        /// Gets the description as a string
        /// </summary>
        public string Description => "Think you are strong enough to take on the Thalmor? " +
            "Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, " +
            "pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

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
