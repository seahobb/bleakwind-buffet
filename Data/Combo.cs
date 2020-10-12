/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: Combo.cs
 * Purpose: Class used to represent a combo order (1 drink, side, and entree)
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for price
        /// </summary>
        private double price = 0;

        /// <summary>
        /// Private backing variable for calories
        /// </summary>
        private uint calories = 0;

        /// <summary>
        /// Private backing variable for drink
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Private backing variable for entree
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Private backing variable for side
        /// </summary>
        private Side side;

        //you can add constructor to pass in drink, side, and entree if you need


        /// <value>
        /// Property to get item price
        /// </value>
        public double Price 
        {
            get
            {
                price += Drink.Price;
                price += Entree.Price;
                price += Side.Price;
                price -= 1;
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                return price;
            }

           
        }

        /// <value>
        /// Property to get item calories
        /// </value>
        public uint Calories 
        {
            get
            {
                calories += Drink.Calories;
                calories += Entree.Calories;
                calories += Side.Calories;
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
               //above no bc it changes automatically when drink ,etnree, or side changes, creo
                return calories;
            }
        }

        /// <value>
        /// Property to get item special instructions
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> list = new List<string>();
    
                list.Add(Entree.ToString()); //gives size and name
                if (Entree.SpecialInstructions != null)
                {
                    foreach(String s in Entree.SpecialInstructions)
                    {
                        list.Add(s);
                    }
                }

                list.Add(Side.ToString());

                if (Side.SpecialInstructions != null)
                {
                    foreach(String s in Side.SpecialInstructions)
                    {
                        list.Add(s);
                    }
                }

                list.Add(Drink.ToString());

                if (Drink.SpecialInstructions != null)
                {
                    foreach(String s in Drink.SpecialInstructions)
                    {
                        list.Add(s);
                    }
                }

                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                return list;
            }
        }



        //below returns a bunch of drinks in a list fyi

      /*  public IEnumerable<IOrderItem> Drink
        {
            get //return collecction 
            {
                AretinoAppleJuice ajSmall = new AretinoAppleJuice();
                ajSmall.Size = Size.Small;
                List<IOrderItem> drinks = new List<IOrderItem>();

                drinks.Add(ajSmall);
                return drinks; 
            }
            set
            {
                //add to collection
                
            }
        }*/

        /// <summary>
        /// Drink property getter and setter; also updates changed propeties
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Entree property getter and setter; also updates changed propeties
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Side property getter and setter; also updates changed propeties
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        

        
    }
}
