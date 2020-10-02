/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: DragonbornWaffleFriesCustomization.xaml.cs
 * Purpose: Class used to represent a Dragonborn Waffle Fries side customization screen
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
    /// Interaction logic for DragonbornWaffleFriesCustomize.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a DragonbornWaffleFries instance
        /// </summary>
        DragonbornWaffleFries dwf;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public DragonbornWaffleFriesCustomize()
        {
            InitializeComponent();
            dwf = new DragonbornWaffleFries();
            dwf.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = dwf;
        }

        /// <summary>
        /// Event handler to customize Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            FriesContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
