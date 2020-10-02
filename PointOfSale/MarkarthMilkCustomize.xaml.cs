/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: MarkarthMilkCustomize.xaml.cs
 * Purpose: Class used to represent a Markarth Milk drink customization screen
 */

using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MarkarthMilkCustomize.xaml
    /// </summary>
    public partial class MarkarthMilkCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a MarkarthMilk instance
        /// </summary>
        MarkarthMilk mm;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public MarkarthMilkCustomize()
        {
            InitializeComponent();
            mm = new MarkarthMilk();
            mm.Ice = false; 
            mm.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = mm;
        }

        /// <summary>
        /// Event handler to customize Markarth Milk
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            MilkContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
