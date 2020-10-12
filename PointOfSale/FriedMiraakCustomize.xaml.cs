/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
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
        public FriedMiraakCustomize(FriedMiraak fm)
        {
            InitializeComponent();
            fm.Size = BleakwindBuffet.Data.Enums.Size.Small;
            fmGrid.DataContext = fm;

            this.fm = fm;
        }

        
    }
}
