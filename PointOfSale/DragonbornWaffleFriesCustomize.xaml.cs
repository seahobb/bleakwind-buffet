/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
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
        public DragonbornWaffleFriesCustomize(DragonbornWaffleFries dwf)
        {
            InitializeComponent();
            dwf.Size = BleakwindBuffet.Data.Enums.Size.Small;
            dwfGrid.DataContext = dwf;

            this.dwf = dwf;
        }

        
    }
}
