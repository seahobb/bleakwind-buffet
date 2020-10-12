/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
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
        public WarriorWaterCustomize(WarriorWater ww)
        {
            InitializeComponent();
            ww.Ice = true;
            ww.Lemon = false;
            ww.Size = BleakwindBuffet.Data.Enums.Size.Small;
            wwGrid.DataContext = ww;

            this.ww = ww;
        }

        
    }
}
