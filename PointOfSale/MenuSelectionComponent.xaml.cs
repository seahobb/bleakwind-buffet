/*
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
using BleakwindBuffet.Data.Interfaces;

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
            
            //OrderComponent oc = new OrderComponent(this);
            //this.DataContext = this;
        }

        
        void FinishOrder(object sender, RoutedEventArgs e)
        {
            ComboButton.IsEnabled = false;
            AddComboButton.IsEnabled = false;
            // RetrunToComboSelection.IsEnabled = false;


            AddComboButton.Visibility = Visibility.Hidden;
            ComboButton.Visibility = Visibility.Hidden;
            ReturnToComboButton.Visibility = Visibility.Hidden;
            PaymentButton.Visibility = Visibility.Hidden;
          
            PaymentScreen ps = new PaymentScreen();

            ContainerBorder.Child = ps;
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
                if (c != null)
                {
                    c.Entree = ttb;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToMenuSelection.IsEnabled = false;
                    ReturnToComboButton.IsEnabled = true;
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
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
                if (c != null)
                {
                    bb.IsACombo = true;
                    c.Entree = bb;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new BriarheartBurgerCustomize(bb);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                        
                }
                else
                {
                    o.Add(bb);
                    ContainerBorder.Child = new BriarheartBurgerCustomize(bb);
                }
            }

            
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
                DoubleDraugr d = new DoubleDraugr();
                if (c != null)
                {
                    d.IsACombo = true;
                    c.Entree = d;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new DoubleDraugrCustomize(d);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(d);
                    ContainerBorder.Child = new DoubleDraugrCustomize(d);
                }
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
                GardenOrcOmelette g = new GardenOrcOmelette();
                if (c != null)
                {
                    g.IsACombo = true;
                    c.Entree = g;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new GardenOrcOmeletteCustomize(g);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(g);
                    ContainerBorder.Child = new GardenOrcOmeletteCustomize(g);
                }
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
                PhillyPoacher p = new PhillyPoacher();
                if (c != null)
                {
                    p.IsACombo = true;
                    c.Entree = p;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new PhillyPoacherCustomize(p);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(p);
                    ContainerBorder.Child = new PhillyPoacherCustomize(p);
                }
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
                if (c != null)
                {
                    shs.IsACombo = true;
                    c.Entree = shs;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new SmokehouseSkeletonCustomize(shs);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(shs);
                    ContainerBorder.Child = new SmokehouseSkeletonCustomize(shs);
                }
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
                ThalmorTriple x = new ThalmorTriple();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Entree = x;

                    bbButton.IsEnabled = false;
                    ddButton.IsEnabled = false;
                    gooButton.IsEnabled = false;
                    ppButton.IsEnabled = false;
                    shsButton.IsEnabled = false;
                    ttButton.IsEnabled = false;
                    ttbButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new ThalmorTripleCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new ThalmorTripleCustomize(x);
                }
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
                AretinoAppleJuice x = new AretinoAppleJuice();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Drink = x;

                    ajButton.IsEnabled = false;
                    ccButton.IsEnabled = false;
                    ssButton.IsEnabled = false;
                    mmButton.IsEnabled = false;
                    wwButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new AretinoAppleJuiceCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new AretinoAppleJuiceCustomize(x);
                }
            }


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
                CandlehearthCoffee x = new CandlehearthCoffee();
                if (c != null)
                {
                    x.IsACombo = true; 
                    c.Drink = x;

                    ajButton.IsEnabled = false;
                    ccButton.IsEnabled = false;
                    ssButton.IsEnabled = false;
                    mmButton.IsEnabled = false;
                    wwButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new CandlehearthCoffeeCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new CandlehearthCoffeeCustomize(x);
                }
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
                MarkarthMilk x = new MarkarthMilk();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Drink = x;

                    ajButton.IsEnabled = false;
                    ccButton.IsEnabled = false;
                    ssButton.IsEnabled = false;
                    mmButton.IsEnabled = false;
                    wwButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new MarkarthMilkCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new MarkarthMilkCustomize(x);
                }
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
                SailorSoda x = new SailorSoda();
                if (c != null)
                {
                    x.IsACombo = true; 
                    c.Drink = x;

                    ajButton.IsEnabled = false;
                    ccButton.IsEnabled = false;
                    ssButton.IsEnabled = false;
                    mmButton.IsEnabled = false;
                    wwButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new SailorSodaCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new SailorSodaCustomize(x);
                }
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
                WarriorWater x = new WarriorWater();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Drink = x;

                    ajButton.IsEnabled = false;
                    ccButton.IsEnabled = false;
                    ssButton.IsEnabled = false;
                    mmButton.IsEnabled = false;
                    wwButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new WarriorWaterCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new WarriorWaterCustomize(x);
                }
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
                DragonbornWaffleFries x = new DragonbornWaffleFries();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Side = x;

                    dwfButton.IsEnabled = false;
                    fmButton.IsEnabled = false;
                    mogButton.IsEnabled = false;
                    vsButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new DragonbornWaffleFriesCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new DragonbornWaffleFriesCustomize(x);
                }
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
                FriedMiraak x = new FriedMiraak();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Side = x;

                    dwfButton.IsEnabled = false;
                    fmButton.IsEnabled = false;
                    mogButton.IsEnabled = false;
                    vsButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new FriedMiraakCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new FriedMiraakCustomize(x);
                }
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
                MadOtarGrits x = new MadOtarGrits();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Side = x;

                    dwfButton.IsEnabled = false;
                    fmButton.IsEnabled = false;
                    mogButton.IsEnabled = false;
                    vsButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new MadOtarGritsCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new MadOtarGritsCustomize(x);
                }
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
                VokunSalad x = new VokunSalad();
                if (c != null)
                {
                    x.IsACombo = true;
                    c.Side = x;

                    dwfButton.IsEnabled = false;
                    fmButton.IsEnabled = false;
                    mogButton.IsEnabled = false;
                    vsButton.IsEnabled = false;

                    ReturnToComboButton.IsEnabled = true;
                    ReturnToMenuSelection.IsEnabled = false;
                    ContainerBorder.Child = new VokunSaladCustomize(x);
                    toDoTextBlock.Text = "Select a Combo Item";
                    if (c.Entree != null && c.Drink != null && c.Side != null)
                    {
                        toDoTextBlock.Text = "Add Combo To Order";
                        AddComboButton.IsEnabled = true;
                    }
                }
                else
                {
                    o.Add(x);
                    ContainerBorder.Child = new VokunSaladCustomize(x);
                }
            }
        }

        /// <summary>
        /// Event handler for return to menu button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToMenu (object sender, RoutedEventArgs e)
        {
            c = null;
            ComboButton.IsEnabled = true;
            ContainerBorder.Child = null;
            AddComboButton.Visibility = Visibility.Visible;
            ComboButton.Visibility = Visibility.Visible;
            ReturnToComboButton.Visibility = Visibility.Visible;
            PaymentButton.Visibility = Visibility.Visible;
        }
        
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
                ReturnToMenuSelection.IsEnabled = false;
                toDoTextBlock.Text = "Select a Combo Item";
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
                o.Add((IOrderItem)c.Entree);
                o.Add((IOrderItem)c.Drink);
                o.Add((IOrderItem)c.Side);
                ComboButton.IsEnabled = true;
                AddComboButton.IsEnabled = false;
                ReturnToMenuSelection.IsEnabled = true;
                ReturnToComboButton.IsEnabled = false;
                bbButton.IsEnabled = true;
                ddButton.IsEnabled = true;
                gooButton.IsEnabled = true;
                ppButton.IsEnabled = true;
                shsButton.IsEnabled = true;
                ttButton.IsEnabled = true;
                ttbButton.IsEnabled = true;
                ajButton.IsEnabled = true;
                ccButton.IsEnabled = true;
                mmButton.IsEnabled = true;
                ssButton.IsEnabled = true;
                wwButton.IsEnabled = true;
                dwfButton.IsEnabled = true;
                fmButton.IsEnabled = true;
                mogButton.IsEnabled = true;
                vsButton.IsEnabled = true;
                toDoTextBlock.Text = "";
                ContainerBorder.Child = null;
                c = null;
            }
        }

        /// <summary>
        /// Event handler for return to combo selection button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToComboSelection(object sender, RoutedEventArgs e)
        {
            ComboButton.IsEnabled = false;
            ContainerBorder.Child = null;
        }
    }
}
