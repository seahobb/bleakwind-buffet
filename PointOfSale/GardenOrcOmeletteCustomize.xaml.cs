/*
 * Author: Ethan Wheeler
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
        public GardenOrcOmeletteCustomize()
        {
            InitializeComponent();
            goo = new GardenOrcOmelette();
            goo.Broccoli = true;
            goo.Cheddar = true;
            goo.Mushrooms = true;
            goo.Tomato = true;

            this.DataContext = goo;
        }

        /// <summary>
        /// Event handler to customize Garden Orc Omelette
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            OmeletteContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
