﻿/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: ThalmorTripleCustomize.xaml.cs
 * Purpose: Class used to represent a Thalmor Triple entree customization screen
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
    /// Interaction logic for ThalmorTripleCustomize.xaml
    /// </summary>
    public partial class ThalmorTripleCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a ThalmorTriple instance
        /// </summary>
        ThalmorTriple tt;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public ThalmorTripleCustomize(ThalmorTriple tt)
        {
            InitializeComponent();
            tt.Bun = true;
            tt.Ketchup = true;
            tt.Mustard = true;
            tt.Pickle = true;
            tt.Cheese = true;
            tt.Tomato = true;
            tt.Lettuce = true;
            tt.Mayo = true;
            tt.Bacon = true;
            tt.Egg = true;

            ttGrid.DataContext = tt;
            this.tt = tt;
        }

        
    }
}
