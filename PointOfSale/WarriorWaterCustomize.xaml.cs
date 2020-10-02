/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: WarriorWaterCustomization.xaml.cs
 * Purpose: Class used to represent a Warrior Water drink customization screen
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
    /// Interaction logic for WarriorWaterCustomize.xaml
    /// </summary>
    public partial class WarriorWaterCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a WarriorWater instance
        /// </summary>
        WarriorWater ww;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public WarriorWaterCustomize()
        {
            InitializeComponent();
            ww = new WarriorWater();
            ww.Ice = true;
            ww.Lemon = false;
            ww.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = ww;
        }

        /// <summary>
        /// Event handler to customize Warrior Water
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            WaterContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
