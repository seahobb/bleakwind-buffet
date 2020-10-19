/*
 * Author: Ethan Wheeler
 * Modified On: 10/18/2020
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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Entrees;
using System.Linq;
using BleakwindBuffet.Data.Drinks;

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
            MenuSelectionComponentName.ReturnToComboButton.IsEnabled = false;
            MenuSelectionComponentName.ReturnToMenuSelection.IsEnabled = true;
            MenuSelectionComponentName.ComboButton.IsEnabled = true;
            MenuSelectionComponentName.AddComboButton.IsEnabled = false;
            MenuSelectionComponentName.bbButton.IsEnabled = true;
            MenuSelectionComponentName.ddButton.IsEnabled = true;
            MenuSelectionComponentName.gooButton.IsEnabled = true;
            MenuSelectionComponentName.ppButton.IsEnabled = true;
            MenuSelectionComponentName.shsButton.IsEnabled = true;
            MenuSelectionComponentName.ttButton.IsEnabled = true;
            MenuSelectionComponentName.ttbButton.IsEnabled = true;
            MenuSelectionComponentName.ajButton.IsEnabled = true;
            MenuSelectionComponentName.ccButton.IsEnabled = true;
            MenuSelectionComponentName.mmButton.IsEnabled = true;
            MenuSelectionComponentName.ssButton.IsEnabled = true;
            MenuSelectionComponentName.wwButton.IsEnabled = true;
            MenuSelectionComponentName.dwfButton.IsEnabled = true;
            MenuSelectionComponentName.fmButton.IsEnabled = true;
            MenuSelectionComponentName.mogButton.IsEnabled = true;
            MenuSelectionComponentName.vsButton.IsEnabled = true;
            MenuSelectionComponentName.toDoTextBlock.Text = "";
            DataContext = new Order();
        }

     

        /// <summary>
        /// Event handler for remove button press of a menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RemoveButton (object sender, RoutedEventArgs e) 
        {
            //ideas:
            //if button name == name of item in o then remove it

            //string s = OrderListView.SelectedItem as string;

            //var theObject = OrderListView.SelectedItems[0] as IOrderItem;

            /////////////////////////////////////////
            //if (e.Source is Button button)
            //{








            if (DataContext is Order o)
            {
                
                List<IOrderItem> l = new List<IOrderItem>();
                foreach (IOrderItem item in OrderListView.SelectedItems)
                {
                    l.Add(item);
                }
                if (l.Count == 1)
                {
                    o.Remove(l[0]);
                }
            }













            /*if (DataContext is Order o)
            {
                var hi = OrderListView.
                int index = o.IndexOf((IOrderItem)hi); //returns -1 if object not found
                o.Remove(o[index]);
               
            }*/
            //}


            //below is what worked sort of 
            /* if (DataContext is Order o)
             {
                // if (OrderListView.Items[])
                 int index = o.IndexOf((IOrderItem)OrderListView.SelectedItem) + 1;
                 o.Remove(o[index]);
                // o.Remove((IOrderItem)OrderListView.SelectedItem);
              //   foreach (IOrderItem item in o)
                 //{

                 //}
             }*/
             //////////////////////////////////////

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
        /// Event handle for edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EditButton(object sender, RoutedEventArgs e)
        {
            EditTheButton.DataContext = MenuSelectionComponentName; 

            if (EditTheButton.DataContext is MenuSelectionComponent m) 
            {
                List<IOrderItem> l = new List<IOrderItem>();
                foreach (IOrderItem item in OrderListView.SelectedItems)
                {
                    l.Add(item);
                }
                if (l.Count == 1)
                {
                    if (l[0] is AretinoAppleJuice juice) 
                    {
                        m.ContainerBorder.Child = new AretinoAppleJuiceCustomize(juice); 
                    }
                    else if (l[0] is CandlehearthCoffee cc)
                    {
                        m.ContainerBorder.Child = new CandlehearthCoffeeCustomize(cc);
                    }
                    else if (l[0] is MarkarthMilk mm)
                    {
                        m.ContainerBorder.Child = new MarkarthMilkCustomize(mm);
                    }
                    else if (l[0] is SailorSoda ss)
                    {
                        m.ContainerBorder.Child = new SailorSodaCustomize(ss);
                    }
                    else if (l[0] is WarriorWater ww)
                    {
                        m.ContainerBorder.Child = new WarriorWaterCustomize(ww);
                    }
                    else if (l[0] is DragonbornWaffleFries dw)
                    {
                        m.ContainerBorder.Child = new DragonbornWaffleFriesCustomize(dw);
                    }
                    else if (l[0] is MadOtarGrits mog)
                    {
                        m.ContainerBorder.Child = new MadOtarGritsCustomize(mog);
                    }
                    else if (l[0] is FriedMiraak fm)
                    {
                        m.ContainerBorder.Child = new FriedMiraakCustomize(fm);
                    }
                    else if (l[0] is VokunSalad vs)
                    {
                        m.ContainerBorder.Child = new VokunSaladCustomize(vs);
                    }
                    else if (l[0] is BriarheartBurger bb)
                    {
                        m.ContainerBorder.Child = new BriarheartBurgerCustomize(bb);
                    }
                    else if (l[0] is DoubleDraugr dd)
                    {
                        m.ContainerBorder.Child = new DoubleDraugrCustomize(dd);
                    }
                    else if (l[0] is GardenOrcOmelette go)
                    {
                        m.ContainerBorder.Child = new GardenOrcOmeletteCustomize(go);
                    }
                    else if (l[0] is PhillyPoacher p)
                    {
                        m.ContainerBorder.Child = new PhillyPoacherCustomize(p);
                    }
                    else if (l[0] is SmokehouseSkeleton s)
                    {
                        m.ContainerBorder.Child = new SmokehouseSkeletonCustomize(s);
                    }
                    else if (l[0] is ThalmorTriple t)
                    {
                        m.ContainerBorder.Child = new ThalmorTripleCustomize(t);
                    }
                }
            }
        }
    }
}
