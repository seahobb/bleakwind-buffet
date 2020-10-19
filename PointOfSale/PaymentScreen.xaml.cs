/*
 * Author: Ethan Wheeler
 * Modified On: 10/18/2020
 * Class name: PaymentScreen.xaml.cs
 * Purpose: Class used to represent the payment options screen
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
using RoundRegister;
using BleakwindBuffet.Data;
using System.Security.Cryptography.Pkcs;
using BleakwindBuffet.Data.Interfaces;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentScreen.xaml
    /// </summary>
    public partial class PaymentScreen : UserControl
    {
        /// <summary>
        /// Constructs a new instance and sets DataContexts
        /// </summary>
        public PaymentScreen()
        {
            InitializeComponent();
            paymentGrid.DataContext = this;
        }

        /// <summary>
        /// Finishes transaction with card 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CreditDebit(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                var result = CardReader.RunCard(o.Total);
                switch (result)
                {
                    case CardTransactionResult.Approved:
                        PrintReceipt();
                        DataContext = new Order();
                        break;
                }
            }
        }

        /// <summary>
        /// Prints receipt using RoundRegister.dll
        /// </summary>
        private void PrintReceipt()
        {
            if (DataContext is Order o)
            {
                StringBuilder sbLineOne = new StringBuilder();
                sbLineOne.Append("Order #");
                sbLineOne.Append(o.Number.ToString());
                sbLineOne.Append("   " + DateTime.Now.ToString());
                string sLineOne = sbLineOne.ToString();
                RecieptPrinter.PrintLine(sLineOne);

                foreach (IOrderItem item in o)
                {
                    StringBuilder sbNextline = new StringBuilder();
                    sbNextline.Append("$" + item.Price + " " + item.ToString());
                    RecieptPrinter.PrintLine(sbNextline.ToString());
                    if (GetListAsString(item).Length > 40 && GetListAsString(item).Length < 76)
                    {
                        string s = GetListAsString(item);
                        int half = (int)(GetListAsString(item).Length / 2);
                        int lastHalf = GetListAsString(item).Length - half;
                        string partOne = s.Substring(0, half);
                        string partTwo = s.Substring(half + 1, lastHalf - 1);
                        RecieptPrinter.PrintLine(partOne);
                        RecieptPrinter.PrintLine(partTwo);
                    }
                    else if (GetListAsString(item).Length <= 40)
                    {
                        RecieptPrinter.PrintLine(GetListAsString(item));
                    }
                    else //divide 3 ways (115 max characters)
                    {
                        string s = GetListAsString(item);
                        int oneThird = (int)(GetListAsString(item).Length / 3);
                        int twoThirds = oneThird * 2;
                        int lastThird = GetListAsString(item).Length - (oneThird + twoThirds);
                        string partOne = s.Substring(0, oneThird);
                        string partTwo = s.Substring(oneThird + 1, twoThirds - 1);
                        string partThree = s.Substring(twoThirds, lastThird - 1);
                        RecieptPrinter.PrintLine(partOne);
                        RecieptPrinter.PrintLine(partTwo);
                        RecieptPrinter.PrintLine(partThree);
                    }
                }

                RecieptPrinter.PrintLine(" Subtotal $" + o.Subtotal.ToString());
                RecieptPrinter.PrintLine("Tax $" + o.Tax.ToString());
                RecieptPrinter.PrintLine("Total $" + o.Total.ToString());
                RecieptPrinter.PrintLine("Payment method: Card");
                RecieptPrinter.PrintLine("Change: None");

                RecieptPrinter.CutTape();
            }
        }

        /// <summary>
        /// Returns list as a string
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private string GetListAsString(IOrderItem item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < item.SpecialInstructions.Count; i++)
            {
                sb.Append(item.SpecialInstructions[i] + " ");
            }
            sb.Append("]");
            string s = sb.ToString();
            return s;
        }

        /// <summary>
        /// event for when cash button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Cash(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                PaymentContainerBorder.Child = new PayCashScreen(o);
            }
        }
    }
}