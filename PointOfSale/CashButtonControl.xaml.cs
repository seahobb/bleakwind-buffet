/*
 * Author: Ethan Wheeler
 * Modified On: 10/18/2020
 * Class name: CashButtonControl.xaml.cs
 * Purpose: Class used to represent a control to add and subtract customer money
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
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashButtonControl.xaml
    /// </summary>
    public partial class CashButtonControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    
        /// <summary>
        /// Creates control UI.
        /// </summary>
        public CashButtonControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dependency property for the received customer money
        /// </summary>
        public static readonly DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CashButtonControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Property for above dependency property
        /// </summary>
        public int CustomerQuantity
        {
            get => (int)GetValue(CustomerQuantityProperty);
            set 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuantity"));
                SetValue(CustomerQuantityProperty, value);
            }
        }

        /// <summary>
        /// Dependency property for the received customer money
        /// </summary>
        public static readonly DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CashButtonControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Property for above dependency property
        /// </summary>
        public int ChangeQuantity
        {
            get => (int)GetValue(ChangeQuantityProperty);
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuantity"));
                SetValue(ChangeQuantityProperty, value);
            }
        }

        /// <summary>
        /// Event handler for when customer gives money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void IncreaseCashFromCustomer(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
            e.Handled = true;
        }

        /// <summary>
        /// Event handler for when money is given back to customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DecreaseCashFromCustomer(object sender, RoutedEventArgs e)
        {
            if (CustomerQuantity > 0)
                CustomerQuantity--;
            e.Handled = true;
        }
    }
}
