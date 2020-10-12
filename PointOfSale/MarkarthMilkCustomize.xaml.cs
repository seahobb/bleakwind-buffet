/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
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
        public MarkarthMilkCustomize(MarkarthMilk mm)
        {
            InitializeComponent();
            mm.Ice = false; 
            mm.Size = BleakwindBuffet.Data.Enums.Size.Small;
            mmGrid.DataContext = mm;

            this.mm = mm;
        }

       
    }
}
