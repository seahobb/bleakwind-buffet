/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: OrderComponent.xaml.cs
 * Purpose: Class used to represent the order summary screen
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Entrees;
using System.Linq;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Creates the UI order component screen
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// Event handler for canceling the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

        /// <summary>
        /// Event handler for remove button press of a menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RemoveButton (object sender, RoutedEventArgs e) //e is button
        {
            //ideas:
            //if button name == name of item in o then remove it

            //string s = OrderListView.SelectedItem as string;

            //var theObject = OrderListView.SelectedItems[0] as IOrderItem;



        

            if (DataContext is Order o)
            {
                int index = o.IndexOf((IOrderItem)OrderListView.SelectedItem) + 1;
                o.Remove(o[index]);
               // o.Remove((IOrderItem)OrderListView.SelectedItem);
             /*   foreach (IOrderItem item in o)
                {

                }*/
            }
           
           
           /*
            if (DataContext is Order o)
            {
                if (sender is Button)
                {
                    foreach (IOrderItem item in o)
                    {
                        if (item.ToString() == ((Button)sender).Name)//(((Button)sender).Name)
                        {
                            o.Remove(item);
                        }
                    }
                    
                }
            

                int count = 0;
                foreach (IOrderItem item in o)
                {
                    if (sender == item)
                        o.Remove(o[count]);
                    else
                        count++;
                }
                //o.Remove(o[1]);
               /// o.Remove(o[sender]);*/

                /*foreach (IOrderItem item in o)
                {
                    //if (item.Equals(e))
                    o.Remove(item);
                }
            }*/
        }
       
        /// <summary>
        /// Event handler for change item select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeItemSelection(object sender, SelectionChangedEventArgs e)
        {
           //add not new, but new briarheartburgercustomize screen

            //bind customization screen to e



            //swap to order collection specific item's customization screen
            /*if (DataContext is Order o)
            {
                foreach(IOrderItem item in o)
                {
                    if (item == e)
                    {
                        ContainerBorder.Child = 
                    }
                }
                
                //change datacontext to 
                ContainerBorder.Child = new SmokehouseSkeletonCustomize(e);
            }*/

            
            //somethihng.Child = 
            
        }

        /*if (DataContext is Order o)
            {
    
                AretinoAppleJuice aj = new AretinoAppleJuice();
                o.Add(aj); 
                ContainerBorder.Child = new AretinoAppleJuiceCustomize(aj); 
           
            }*/

        

    }
}
