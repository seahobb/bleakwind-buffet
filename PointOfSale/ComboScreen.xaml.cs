/*
 * Author: Ethan Wheeler
 * Modified On: 10/11/2020
 * Class name: ComboScreen.xaml.cs
 * Purpose: Class used to represent a combo selection screen
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboScreen.xaml
    /// </summary>
    public partial class ComboScreen : UserControl
    {
       
        /// <summary>
        /// Creates the UI customization screen 
        /// </summary>
        public ComboScreen()
        {
            InitializeComponent();
            
            //comboGrid.DataContext = comboObj;
            
        }

        /// <summary>
        /// Event handler for entree button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBone(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo c)
            {
                ThugsTBone ttb = new ThugsTBone();
                c.Entree = ttb;
            }
        }

        /// <summary>
        /// Event handler to customize Briarheart Burger
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void BriarheartBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo c)
            {
                BriarheartBurger bb = new BriarheartBurger();
                c.Entree = bb;
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
            if (DataContext is Combo c)
            {

                DoubleDraugr dd = new DoubleDraugr();
                c.Entree = dd;
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
            if (DataContext is Combo c)
            {

                GardenOrcOmelette goo = new GardenOrcOmelette();
                c.Entree = goo;
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
            if (DataContext is Combo c)
            {

                PhillyPoacher pp = new PhillyPoacher();
                c.Entree = pp;
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
            if (DataContext is Combo c)
            {

                SmokehouseSkeleton shs = new SmokehouseSkeleton();
                c.Entree = shs;
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
            if (DataContext is Combo c)
            {

                ThalmorTriple tt = new ThalmorTriple();
                c.Entree = tt;
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


            if (DataContext is Combo c)
            {

                AretinoAppleJuice aj = new AretinoAppleJuice(); //i want to use this object for removing it later
                c.Drink = aj;
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
            if (DataContext is Combo c)
            {

                CandlehearthCoffee cc = new CandlehearthCoffee(); //i want to use this object for removing it later
                c.Drink = cc;
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
            if (DataContext is Combo c)
            {

                MarkarthMilk mm = new MarkarthMilk(); //i want to use this object for removing it later
                c.Drink = mm;
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
            if (DataContext is Combo c)
            {

                SailorSoda ss = new SailorSoda();
                c.Drink = ss;
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
            if (DataContext is Combo c)
            {

                WarriorWater ww = new WarriorWater();
                c.Drink = ww;
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
            if (DataContext is Combo c)
            {

                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                c.Side = dwf;
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
            if (DataContext is Combo c)
            {

                FriedMiraak fm = new FriedMiraak();
                c.Side = fm;
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
            if (DataContext is Combo c)
            {

                MadOtarGrits mog = new MadOtarGrits();
                c.Side = mog;
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
            if (DataContext is Combo c)
            {

                VokunSalad vs = new VokunSalad();
                c.Side = vs;
                ContainerBorder.Child = new VokunSaladCustomize(vs);

            }
        }

        /// <summary>
        /// Event handler for return to menu button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToMenu(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = null;
        }

        /// <summary>
        /// Event handler for changing a selected item in the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeItemSelection(object sender, SelectionChangedEventArgs e)
        { }
    
    }

    
}
