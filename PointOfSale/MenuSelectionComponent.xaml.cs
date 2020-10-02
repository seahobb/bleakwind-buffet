/*
 * Author: Ethan Wheeler
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Class used to represent the menu selection screen
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
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
        }

        /// <summary>
        /// Event handler to customize Briarheart Burger
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void BriarheartBurger(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new BriarheartBurgerCustomize(); 
        }

        /// <summary>
        /// Event handler to customize Double Draugr
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void DoubleDraugr(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new DoubleDraugrCustomize();
        }

        /// <summary>
        /// Event handler to customize Garden Orc Omelette
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void GardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new GardenOrcOmeletteCustomize();
        }

        /// <summary>
        /// Event handler to customize Philly Poacher
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void PhillyPoacher(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new PhillyPoacherCustomize();
        }

        /// <summary>
        /// Event handler to customize Smokehouse Skeleton
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void SmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new SmokehouseSkeletonCustomize();
        }
        
        /// <summary>
        /// Event handler to customize Thalmor Triple
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void ThalmorTriple(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new ThalmorTripleCustomize();
        }

        /// <summary>
        /// Event handler to customize Aretino Apple Juice
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void AretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new AretinoAppleJuiceCustomize();
        }

        /// <summary>
        /// Event handler to customize Candlehearth Coffee
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void CandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new CandlehearthCoffeeCustomize();
        }

        /// <summary>
        /// Event handler to customize Markarth Milk
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void MarkarthMilk(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new MarkarthMilkCustomize();
        }

        /// <summary>
        /// Event handler to customize Sailor Soda
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void SailorSoda(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new SailorSodaCustomize();
        }

        /// <summary>
        /// Event handler to customize Warrior Water
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void WarriorWater(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new WarriorWaterCustomize();
        }

        /// <summary>
        /// Event handler to customize Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void DragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new DragonbornWaffleFriesCustomize();
        }

        /// <summary>
        /// Event handler to customize Fried Miraak
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void FriedMiraak(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new FriedMiraakCustomize();
        }

        /// <summary>
        /// Event handler to customize MadOtarGrits
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void MadOtarGrits(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new MadOtarGritsCustomize();
        }

        /// <summary>
        /// Event handler to customize Vokun Salad
        /// </summary>
        /// <param name="sender">The object sending a message</param>
        /// <param name="e">The event data</param>
        void VokunSalad(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = new VokunSaladCustomize();
        }
    }
}
