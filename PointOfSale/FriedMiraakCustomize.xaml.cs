/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: FriedMiraakCustomize.xaml.cs
 * Purpose: Class used to represent a Fried Miraak side customization screen
 */

using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for FriedMiraakCustomize.xaml
    /// </summary>
    public partial class FriedMiraakCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a FriedMiraak instance
        /// </summary>
        FriedMiraak fm;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public FriedMiraakCustomize()
        {
            InitializeComponent();
            fm = new FriedMiraak();
            fm.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = fm;
        }

        /// <summary>
        /// Event handler to customize Fried Miraak
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            MiraakContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
