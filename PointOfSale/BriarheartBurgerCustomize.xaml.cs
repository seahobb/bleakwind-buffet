/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: BriarheartBurgerCustomize.xaml.cs
 * Purpose: Class used to represent a Briarheart Burger entree customization screen
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
    /// Interaction logic for BriarheartBurgerCustomize.xaml
    /// </summary>
    public partial class BriarheartBurgerCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a BriarheartBurger instance
        /// </summary>
        BriarheartBurger bb;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public BriarheartBurgerCustomize()
        {
            InitializeComponent();
            bb = new BriarheartBurger();
            bb.Bun = true;
            bb.Ketchup = true;
            bb.Mustard = true;
            bb.Pickle = true;
            bb.Cheese = true;

            this.DataContext = bb;
        }

        /// <summary>
        /// Event handler to customize Briarheart Burger
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            BurgerContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
