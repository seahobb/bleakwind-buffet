/*
 * Author: Ethan Wheeler
 * Class name: VokunSaladCustomize.xaml.cs
 * Purpose: Class used to represent a Vokun Salad side customization screen
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
    /// Interaction logic for VokunSaladCustomize.xaml
    /// </summary>
    public partial class VokunSaladCustomize : UserControl
    {
        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public VokunSaladCustomize()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to customize Vokun Salad
        /// </summary>
        /// <param name="sender">The object sending a message></param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            SaladContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
