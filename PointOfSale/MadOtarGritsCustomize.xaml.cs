/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: MadOtarGritsCustomize.xaml.cs
 * Purpose: Class used to represent a Mad Otar Grits side customization screen
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
    /// Interaction logic for MadOtarGritsCustomize.xaml
    /// </summary>
    public partial class MadOtarGritsCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a MadOtarGrits instance
        /// </summary>
        MadOtarGrits mog;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public MadOtarGritsCustomize()
        {
            InitializeComponent();
            mog = new MadOtarGrits();
            mog.Size = BleakwindBuffet.Data.Enums.Size.Small;

            this.DataContext = mog;
        }

        /// <summary>
        /// Event handler to customize Mad Otar Grits
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            GritsContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
