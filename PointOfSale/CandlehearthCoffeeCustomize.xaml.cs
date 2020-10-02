/*
 * Author: Ethan Wheeler
 * Modified On: 9/30/2020
 * Class name: CandlehearthCoffeeCustomize.xaml.cs
 * Purpose: Class used to represent a Candlehearth Coffee drink customization screen
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
    /// Interaction logic for CandlehearthCoffeeCustomize.xaml
    /// </summary>
    public partial class CandlehearthCoffeeCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a CandlehearthCoffee instance
        /// </summary>
        CandlehearthCoffee cc;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public CandlehearthCoffeeCustomize()
        {
            InitializeComponent();
            cc = new CandlehearthCoffee();
            cc.Ice = false;
            cc.RoomForCream = false;
            cc.Decaf = false;
            cc.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = cc;
        }

        /// <summary>
        /// Event handler to customize Candlehearth Coffee
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            CoffeeContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
