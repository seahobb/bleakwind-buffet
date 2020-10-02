/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: SailorSodaCustomize.xaml.cs
 * Purpose: Class used to represent a Sailor Soda drink customization screen
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
    /// Interaction logic for SailorSodaCustomize.xaml
    /// </summary>
    public partial class SailorSodaCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a SailorSoda instance
        /// </summary>
        SailorSoda ss;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public SailorSodaCustomize()
        {
            InitializeComponent();
            ss = new SailorSoda();
            ss.Ice = true;
            ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            ss.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = ss;
        }

        /// <summary>
        /// Event handler to customize Sailor Soda
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            SodaContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
