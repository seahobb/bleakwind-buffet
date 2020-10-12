﻿/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Class used to represent the menu selection screen
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
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
using System.Windows.Media.Converters;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        /// <summary>
        /// Creates UI menu selection screen
        /// </summary>
        public MenuSelectionComponent()
        {
            InitializeComponent();
            //this.DataContext = this;
        }

        /// <summary>
        /// Event handler to add thugs t bone to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBone(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                ThugsTBone ttb = new ThugsTBone();
                o.Add(ttb);
            }
        }

        /// <summary>
        /// Event handler to customize Briarheart Burger
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void BriarheartBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                BriarheartBurger bb = new BriarheartBurger();
                o.Add(bb);
                ContainerBorder.Child = new BriarheartBurgerCustomize(bb);
            }

            // ContainerBorder.Child = new BriarheartBurgerCustomize(); 
        }

        /// <summary>
        /// Event handler to customize Double Draugr
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void DoubleDraugr(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                DoubleDraugr dd = new DoubleDraugr();
                o.Add(dd);
                ContainerBorder.Child = new DoubleDraugrCustomize(dd);

            }
        }

        /// <summary>
        /// Event handler to customize Garden Orc Omelette
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void GardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                GardenOrcOmelette goo = new GardenOrcOmelette();
                o.Add(goo);
                ContainerBorder.Child = new GardenOrcOmeletteCustomize(goo);

            }
        }

        /// <summary>
        /// Event handler to customize Philly Poacher
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void PhillyPoacher(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                PhillyPoacher pp = new PhillyPoacher();
                o.Add(pp);
                ContainerBorder.Child = new PhillyPoacherCustomize(pp);

            }
        }

        /// <summary>
        /// Event handler to customize Smokehouse Skeleton
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void SmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                SmokehouseSkeleton shs = new SmokehouseSkeleton();
                o.Add(shs);
                ContainerBorder.Child = new SmokehouseSkeletonCustomize(shs);

            }
        }
        
        /// <summary>
        /// Event handler to customize Thalmor Triple
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void ThalmorTriple(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                ThalmorTriple tt = new ThalmorTriple();
                o.Add(tt);
                ContainerBorder.Child = new ThalmorTripleCustomize(tt);

            }
        }
        
        /// <summary>
        /// Event handler to customize Aretino Apple Juice
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void AretinoAppleJuice(object sender, RoutedEventArgs e)
        {
         

            if (DataContext is Order o)
            {
    
                AretinoAppleJuice aj = new AretinoAppleJuice(); //i want to use this object for removing it later
                o.Add(aj); 
                ContainerBorder.Child = new AretinoAppleJuiceCustomize(aj); //i want to use this value for customizing again
           
            }

            // ContainerBorder.Child = new AretinoAppleJuiceCustomize();
        }

        /// <summary>
        /// Event handler to customize Candlehearth Coffee
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void CandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                CandlehearthCoffee cc = new CandlehearthCoffee(); //i want to use this object for removing it later
                o.Add(cc);
                ContainerBorder.Child = new CandlehearthCoffeeCustomize(cc); //i want to use this value for customizing again

            }
           
        }

        /// <summary>
        /// Event handler to customize Markarth Milk
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void MarkarthMilk(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                MarkarthMilk mm = new MarkarthMilk(); //i want to use this object for removing it later
                o.Add(mm);
                ContainerBorder.Child = new MarkarthMilkCustomize(mm); ; //i want to use this value for customizing again

            }
            
        }

        /// <summary>
        /// Event handler to customize Sailor Soda
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void SailorSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                SailorSoda ss = new SailorSoda(); 
                o.Add(ss);
                ContainerBorder.Child = new SailorSodaCustomize(ss);

            }
        }

        /// <summary>
        /// Event handler to customize Warrior Water
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void WarriorWater(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                WarriorWater ww = new WarriorWater();
                o.Add(ww);
                ContainerBorder.Child = new WarriorWaterCustomize(ww);

            }
        }

        /// <summary>
        /// Event handler to customize Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void DragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                o.Add(dwf);
                ContainerBorder.Child = new DragonbornWaffleFriesCustomize(dwf);

            }
        }

        /// <summary>
        /// Event handler to customize Fried Miraak
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void FriedMiraak(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                FriedMiraak fm = new FriedMiraak();
                o.Add(fm);
                ContainerBorder.Child = new FriedMiraakCustomize(fm);

            }
        }

        /// <summary>
        /// Event handler to customize MadOtarGrits
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void MadOtarGrits(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                MadOtarGrits mog = new MadOtarGrits();
                o.Add(mog);
                ContainerBorder.Child = new MadOtarGritsCustomize(mog);

            }
        }

        /// <summary>
        /// Event handler to customize Vokun Salad
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void VokunSalad(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {

                VokunSalad vs = new VokunSalad();
                o.Add(vs);
                ContainerBorder.Child = new VokunSaladCustomize(vs);

            }
        }

        /// <summary>
        /// Event handler for return to menu button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToMenu (object sender, RoutedEventArgs e)
        {
            ComboButton.IsEnabled = true;
            ContainerBorder.Child = null;
        }

        /// <summary>
        /// Private backing variable for combo screen instance
        /// </summary>
        private ComboScreen cs;
        
        /// <summary>
        /// Private backing variable for combo instance
        /// </summary>
        private Combo c;

        /// <summary>
        /// Event handler for create combo button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CreateCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                c = new Combo(); 
                
                ComboButton.IsEnabled = false;
                
                AddComboButton.IsEnabled = true;
                RetrunToComboSelection.IsEnabled = true;
                cs = new ComboScreen();
                ContainerBorder.Child = cs;
            }
            
        }

        /// <summary>
        /// Event handler for add combo to order button press 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddComboToOrder(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(c);
            }
        }

        /// <summary>
        /// Event handler for return to combo selection button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToComboSelection(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = null;
        }
    }
}
