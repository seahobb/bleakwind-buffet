/*
 * Author: Ethan Wheeler
 * Modified On: 10/1/2020
 * Class name: SmokehouseSkeletonCustomize.xaml.cs
 * Purpose: Class used to represent a Smokehouse Skeleton entree customization screen
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
    /// Interaction logic for SmokehouseSkeletonCustomize.xaml
    /// </summary>
    public partial class SmokehouseSkeletonCustomize : UserControl
    {
        /// <summary>
        /// Variable to represent a SmokehouseSkeleton instance
        /// </summary>
        SmokehouseSkeleton ss;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public SmokehouseSkeletonCustomize()
        {
            InitializeComponent();
            ss = new SmokehouseSkeleton();
            ss.Egg = true;
            ss.HashBrowns = true;
            ss.Pancake = true;
            ss.SausageLink = true;

            this.DataContext = ss;
        }

        /// <summary>
        /// Event handler to customize Smokehouse Skeleton
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void Done(object sender, RoutedEventArgs e)
        {
            //add item to list here?
            SkeletonContainerBorder.Child = new MenuSelectionComponent();
        }
    }
}
