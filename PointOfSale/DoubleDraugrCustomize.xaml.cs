/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: DoubleDraugrCustomize.xaml.cs
 * Purpose: Class used to represent a Double Draugr entree customization screen
 */

using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for DoubleDraugrCustomize.xaml
    /// </summary>
    public partial class DoubleDraugrCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a DoubleDraugr instance
        /// </summary>
        DoubleDraugr dd;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public DoubleDraugrCustomize()
        {
            InitializeComponent();
            dd = new DoubleDraugr();
            dd.Bun = true;
            dd.Ketchup = true;
            dd.Mustard = true;
            dd.Pickle = true;
            dd.Cheese = true;
            dd.Tomato = true;
            dd.Lettuce = true;
            dd.Mayo = true;

            this.DataContext = dd;
        }

        /// <summary>
        /// Event handler to customize Double Draugr
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            DraugrContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
