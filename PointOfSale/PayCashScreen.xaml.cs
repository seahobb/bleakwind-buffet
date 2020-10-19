/*
 * Author: Ethan Wheeler
 * Modified On: 10/18/2020
 * Class name: PayCashScreen.xaml.cs
 * Purpose: Class used to represent the pay cash screen
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
using BleakwindBuffet.Data;
using Microsoft.VisualBasic;
using RoundRegister;
using BleakwindBuffet.Data.Interfaces;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PayCashScreen.xaml
    /// </summary>
    public partial class PayCashScreen : UserControl
    {
        /// <summary>
        /// Private backing variable for CashModelView instance
        /// </summary>
        private CashModelView cmv;

        /// <summary>
        /// Constructs a new instance and sets DataContext
        /// </summary>
        /// <param name="o"></param>
        public PayCashScreen(Order o) 
        {
            InitializeComponent();
            cmv = new CashModelView(o);
            DataContext = cmv; 
            TotalSaleTextBlock.Text = o.Total.ToString();
        }

        /// <summary>
        /// Event handler for finalizing the sale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FinalizeSaleClick (object sender, RoutedEventArgs e)
        {
            cmv.FinalizeCashTransaction(); //opens drawer 
            cmv.PrintReceipt();
            CashDrawer.ResetDrawer();
            DataContext = new Order();
        }

        
    }
}
