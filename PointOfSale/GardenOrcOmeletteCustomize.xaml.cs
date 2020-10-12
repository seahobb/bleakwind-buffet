/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: GardenOrcOmeletteCustomize.xaml.cs
 * Purpose: Class used to represent a Garden Orc Omelette entree customization screen
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
    /// Interaction logic for GardenOrcOmeletteCustomize.xaml
    /// </summary>
    public partial class GardenOrcOmeletteCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a GardenOrcOmelette instance
        /// </summary>
        GardenOrcOmelette goo;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public GardenOrcOmeletteCustomize(GardenOrcOmelette goo)
        {
            InitializeComponent();
            goo.Broccoli = true;
            goo.Cheddar = true;
            goo.Mushrooms = true;
            goo.Tomato = true;
            gooGrid.DataContext = goo;

            this.goo = goo;
        }

       
    }
}
