/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
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
        SmokehouseSkeleton shs;

        /// <summary>
        /// Creates the UI customization screen
        /// </summary>
        public SmokehouseSkeletonCustomize(SmokehouseSkeleton shs)
        {
            InitializeComponent();
            shs.Egg = true;
            shs.HashBrowns = true;
            shs.Pancake = true;
            shs.SausageLink = true;

            shsGrid.DataContext = shs;
            this.shs = shs;
        }

        
    }
}
