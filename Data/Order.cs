/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: Order.cs
 * Purpose: Class used to represent an order
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Interfaces;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>, ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing backing variable for sales tax rate
        /// </summary>
        private double salesTaxRate = 0.12;

        /// <summary>
        /// Private backing variable for subtotal
        /// </summary>
        private double subtotal = 0;

        /// <summary>
        /// Private backing variable for calories
        /// </summary>
        private uint calories = 0;

        /// <summary>
        /// Private backing variable for next order number
        /// </summary>
        private static uint nextOrderNumber = 1;

        /// <summary>
        /// Property to get and set sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; } 
            set { salesTaxRate = value; }
        }

        /// <summary>
        /// Property to get and set subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach (IOrderItem item in this)
                 {
                     subtotal += item.Price;
                 }

                return Math.Round(subtotal, 2);
            }
        }

        /// <summary>
        /// Property to get and set tax
        /// </summary>
        public double Tax
        {
            get
            {
                return Math.Round(Subtotal * salesTaxRate, 2); 
            }
        }

        /// <summary>
        /// Property to get and set total price
        /// </summary>
        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax, 2); 
            }
        }

        /// <summary>
        /// Property to get and set order number
        /// </summary>
        public uint Number
        {
            get; set;
        }

        /// <summary>
        /// Constructs a new Order and creates new collection changed event
        /// </summary>
        public Order()
        {
            this.Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Property to get and set calories
        /// </summary>
        public uint Calories
        {
            get
            {
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }


        /// <summary>
        /// Event listener for any change in collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Replace:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        /// <summary>
        /// Event listener for any item change in collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
           
            
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
