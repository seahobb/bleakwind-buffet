/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda drink
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
    /// Represents a Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
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
        private bool ice = true;

        /// <summary>
        /// Private backing flavor variable
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

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

        private bool flavorChangedCherry = false;
        public bool FlavorChangedCherry
        {
            get
            {
                return flavorChangedCherry;
            }
            set
            {
                flavorChangedCherry = value;
                if (flavorChangedCherry == true)
                    flavor = SodaFlavor.Cherry;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorChangedCherry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private bool flavorChangedBlackberry = false;
        public bool FlavorChangedBlackberry
        {
            get
            {
                return flavorChangedBlackberry;
            }
            set
            {
                flavorChangedBlackberry = value;
                if (flavorChangedBlackberry == true)
                    flavor = SodaFlavor.Blackberry;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorChangedBlackberry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private bool flavorChangedGrapefruit = false;
        public bool FlavorChangedGrapefruit
        {
            get
            {
                return flavorChangedGrapefruit;
            }
            set
            {
                flavorChangedGrapefruit = value;
                if (flavorChangedGrapefruit == true)
                    flavor = SodaFlavor.Grapefruit;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorChangedGrapefruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private bool flavorChangedLemon = false;
        public bool FlavorChangedLemon
        {
            get
            {
                return flavorChangedLemon;
            }
            set
            {
                flavorChangedLemon = value;
                if (flavorChangedLemon == true)
                    flavor = SodaFlavor.Lemon;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorChangedLemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private bool flavorChangedPeach = false;
        public bool FlavorChangedPeach
        {
            get
            {
                return flavorChangedPeach;
            }
            set
            {
                flavorChangedPeach = value;
                if (flavorChangedPeach == true)
                    flavor = SodaFlavor.Peach;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorChangedPeach"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private bool flavorChangedWatermelon = false;
        public bool FlavorChangedWatermelon
        {
            get
            {
                return flavorChangedWatermelon;
            }
            set
            {
                flavorChangedWatermelon = value;
                if (flavorChangedWatermelon == true)
                    flavor = SodaFlavor.Watermelon;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorChangedWatermelon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <value>
        /// Getter and setter for the private backing flavor variable
        /// </value>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set 
            { 
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
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
                    return 1.42;
                else if (size == Size.Medium)
                    return 1.74;
                else if (size == Size.Large)
                    return 2.07;
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
                    return 117;
                else if (size == Size.Medium)
                    return 153;
                else if (size == Size.Large)
                    return 205;
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
                if (!ice)
                    list.Add("Hold ice");
                return list;
            }
        }

        /// <summary>
        /// Gets string for drink
        /// </summary>
        /// <returns>String representation of drink</returns>
        public override string ToString()
        {
            return "" + size + " " + flavor + " Sailor Soda";
        }
    }
}
