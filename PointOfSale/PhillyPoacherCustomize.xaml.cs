/*
 * Author: Ethan Wheeler
 * Class name: PhillyPoacherCustomize.xaml.cs
 * Purpose: Class used to represent a Philly Poacher entree customization screen
 */

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
        /// Creates the UI customization screen
        /// </summary>
        public PhillyPoacherCustomize()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to customize Philly Poacher
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            PoacherContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
