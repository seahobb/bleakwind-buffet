/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: AretinoAppleJuiceCustomize.xaml.cs
 * Purpose: Class used to represent a Aretino Apple Juice drink customization screen
 */

using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BleakwindBuffet.Data;
using System.Runtime.CompilerServices;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceCustomize.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent an AretinoAppleJuice instance
        /// </summary>
        private AretinoAppleJuice aj; //put out here in case i make other methods

        
        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public AretinoAppleJuiceCustomize(AretinoAppleJuice aj)
        {
            InitializeComponent();
            aj.Ice = true; //whatever you change here is what happens when you run program (instad of xaml now)
            aj.Size = BleakwindBuffet.Data.Enums.Size.Small;
            ajGrid.DataContext = aj;
            this.aj = aj;
            
        }

        
    }
}
