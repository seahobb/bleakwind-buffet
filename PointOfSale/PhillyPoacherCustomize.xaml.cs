/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: PhillyPoacherCustomize.xaml.cs
 * Purpose: Class used to represent a Philly Poacher entree customization screen
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
    /// Interaction logic for PhillyPoacherCustomize.xaml
    /// </summary>
    public partial class PhillyPoacherCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a PhillyPoacher instance
        /// </summary>
        PhillyPoacher pp;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public PhillyPoacherCustomize(PhillyPoacher pp)
        {
            InitializeComponent();
            pp.Sirloin = true;
            pp.Onion = true;
            pp.Roll = true;

            ppGrid.DataContext = pp;
            this.pp = pp;
        }

        
    }
}
