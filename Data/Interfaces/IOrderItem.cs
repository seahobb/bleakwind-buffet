/*
 * Author: Ethan Wheeler
 * Class name: IOrderItem.cs
 * Purpose: Class used to represent items that can be ordered
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Interfaces
{
    /// <summary>
    /// An interface for items that can be ordered
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets the description of the item
        /// </summary>
        string Description { get; }
    }
}
