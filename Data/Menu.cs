/*
 * Author: Ethan Wheeler
 * Class name: Menu.cs
 * Purpose: Class used to represent the menu of Bleakwind Buffet
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Xml.Serialization;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing the entire menu for Bleakwind Buffet
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Returns IEnumerable contianing an instance of all available entrees
        /// </summary>
        /// <returns>List of available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();

            List<IOrderItem> entrees = new List<IOrderItem>();

            entrees.Add(bb);
            entrees.Add(dd);
            entrees.Add(goo);
            entrees.Add(pp);
            entrees.Add(ss);
            entrees.Add(tt);
            entrees.Add(tb);

            return entrees;
        }

        /// <summary>
        /// Returns IEnumerable contianing an instance of all available sides
        /// </summary>
        /// <returns>List of available sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        { 
            DragonbornWaffleFries dwfSmall = new DragonbornWaffleFries();
            DragonbornWaffleFries dwfMedium = new DragonbornWaffleFries();
            DragonbornWaffleFries dwfLarge = new DragonbornWaffleFries();
            dwfSmall.Size = Size.Small;
            dwfMedium.Size = Size.Medium;
            dwfLarge.Size = Size.Large;

            FriedMiraak fmSmall = new FriedMiraak();
            FriedMiraak fmMedium = new FriedMiraak();
            FriedMiraak fmLarge = new FriedMiraak();
            fmSmall.Size = Size.Small;
            fmMedium.Size = Size.Medium;
            fmLarge.Size = Size.Large;

            MadOtarGrits mogSmall = new MadOtarGrits();
            MadOtarGrits mogMedium = new MadOtarGrits();
            MadOtarGrits mogLarge = new MadOtarGrits();
            mogSmall.Size = Size.Small;
            mogMedium.Size = Size.Medium;
            mogLarge.Size = Size.Large;

            VokunSalad vsSmall = new VokunSalad();
            VokunSalad vsMedium = new VokunSalad();
            VokunSalad vsLarge = new VokunSalad();
            vsSmall.Size = Size.Small;
            vsMedium.Size = Size.Medium;
            vsLarge.Size = Size.Large;

            List<IOrderItem> sides = new List<IOrderItem>();

            sides.Add(dwfSmall);
            sides.Add(dwfMedium);
            sides.Add(dwfLarge);

            sides.Add(fmSmall);
            sides.Add(fmMedium);
            sides.Add(fmLarge);

            sides.Add(mogSmall);
            sides.Add(mogMedium);
            sides.Add(mogLarge);

            sides.Add(vsSmall);
            sides.Add(vsMedium);
            sides.Add(vsLarge);

            return sides;
        }

        /// <summary>
        /// Returns IEnumerable contianing an instance of all available drinks
        /// </summary>
        /// <returns>List of available drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            AretinoAppleJuice ajSmall = new AretinoAppleJuice();
            AretinoAppleJuice ajMedium = new AretinoAppleJuice();
            AretinoAppleJuice ajLarge = new AretinoAppleJuice();
            ajSmall.Size = Size.Small;
            ajMedium.Size = Size.Medium;
            ajLarge.Size = Size.Large;

            CandlehearthCoffee ccSmall = new CandlehearthCoffee();
            CandlehearthCoffee ccMedium = new CandlehearthCoffee();
            CandlehearthCoffee ccLarge = new CandlehearthCoffee();
            ccSmall.Size = Size.Small;
            ccMedium.Size = Size.Medium;
            ccLarge.Size = Size.Large;

            MarkarthMilk mmSmall = new MarkarthMilk();
            MarkarthMilk mmMedium = new MarkarthMilk();
            MarkarthMilk mmLarge = new MarkarthMilk();
            mmSmall.Size = Size.Small;
            mmMedium.Size = Size.Medium;
            mmLarge.Size = Size.Large;
            
            SailorSoda ssSmallBlackberry = new SailorSoda();
            SailorSoda ssMediumBlackberry = new SailorSoda();
            SailorSoda ssLargeBlackberry = new SailorSoda();
            SailorSoda ssSmallCherry = new SailorSoda();
            SailorSoda ssMediumCherry = new SailorSoda();
            SailorSoda ssLargeCherry = new SailorSoda();
            SailorSoda ssSmallGrapefruit = new SailorSoda();
            SailorSoda ssMediumGrapefruit = new SailorSoda();
            SailorSoda ssLargeGrapefruit = new SailorSoda();
            SailorSoda ssSmallLemon = new SailorSoda();
            SailorSoda ssMediumLemon = new SailorSoda();
            SailorSoda ssLargeLemon = new SailorSoda();
            SailorSoda ssSmallPeach = new SailorSoda();
            SailorSoda ssMediumPeach = new SailorSoda();
            SailorSoda ssLargePeach = new SailorSoda();
            SailorSoda ssSmallWatermelon = new SailorSoda();
            SailorSoda ssMediumWatermelon = new SailorSoda();
            SailorSoda ssLargeWatermelon = new SailorSoda();
            ssSmallBlackberry.Size = Size.Small;
            ssSmallBlackberry.Flavor = SodaFlavor.Blackberry;
            ssMediumBlackberry.Size = Size.Medium;
            ssMediumBlackberry.Flavor = SodaFlavor.Blackberry;
            ssLargeBlackberry.Size = Size.Large;
            ssLargeBlackberry.Flavor = SodaFlavor.Blackberry;
            ssSmallCherry.Size = Size.Small;
            ssSmallCherry.Flavor = SodaFlavor.Cherry;
            ssMediumCherry.Size = Size.Medium;
            ssMediumCherry.Flavor = SodaFlavor.Cherry;
            ssLargeCherry.Size = Size.Large;
            ssLargeCherry.Flavor = SodaFlavor.Cherry;
            ssSmallGrapefruit.Size = Size.Small;
            ssSmallGrapefruit.Flavor = SodaFlavor.Grapefruit;
            ssMediumGrapefruit.Size = Size.Medium;
            ssMediumGrapefruit.Flavor = SodaFlavor.Grapefruit;
            ssLargeGrapefruit.Size = Size.Large;
            ssLargeGrapefruit.Flavor = SodaFlavor.Grapefruit;
            ssSmallLemon.Size = Size.Small;
            ssSmallLemon.Flavor = SodaFlavor.Lemon;
            ssMediumLemon.Size = Size.Medium;
            ssMediumLemon.Flavor = SodaFlavor.Lemon;
            ssLargeLemon.Size = Size.Large;
            ssLargeLemon.Flavor = SodaFlavor.Lemon;
            ssSmallPeach.Size = Size.Small;
            ssSmallPeach.Flavor = SodaFlavor.Peach;
            ssMediumPeach.Size = Size.Medium;
            ssMediumPeach.Flavor = SodaFlavor.Peach;
            ssLargePeach.Size = Size.Large;
            ssLargePeach.Flavor = SodaFlavor.Peach;
            ssSmallWatermelon.Size = Size.Small;
            ssSmallWatermelon.Flavor = SodaFlavor.Watermelon;
            ssMediumWatermelon.Size = Size.Medium;
            ssMediumWatermelon.Flavor = SodaFlavor.Watermelon;
            ssLargeWatermelon.Size = Size.Large;
            ssLargeWatermelon.Flavor = SodaFlavor.Watermelon;

            WarriorWater wwSmall = new WarriorWater();
            WarriorWater wwMedium = new WarriorWater();
            WarriorWater wwLarge = new WarriorWater();
            wwSmall.Size = Size.Small;
            wwMedium.Size = Size.Medium;
            wwLarge.Size = Size.Large;
            
            List<IOrderItem> drinks = new List<IOrderItem>();

            drinks.Add(ajSmall);
            drinks.Add(ajMedium);
            drinks.Add(ajLarge);

            drinks.Add(ccSmall);
            drinks.Add(ccMedium);
            drinks.Add(ccLarge);

            drinks.Add(mmSmall);
            drinks.Add(mmMedium);
            drinks.Add(mmLarge);

            drinks.Add(ssSmallBlackberry);
            drinks.Add(ssMediumBlackberry);
            drinks.Add(ssLargeBlackberry);

            drinks.Add(ssSmallCherry);
            drinks.Add(ssMediumCherry);
            drinks.Add(ssLargeCherry);

            drinks.Add(ssSmallGrapefruit);
            drinks.Add(ssMediumGrapefruit);
            drinks.Add(ssLargeGrapefruit);

            drinks.Add(ssSmallLemon);
            drinks.Add(ssMediumLemon);
            drinks.Add(ssLargeLemon);

            drinks.Add(ssSmallPeach);
            drinks.Add(ssMediumPeach);
            drinks.Add(ssLargePeach);

            drinks.Add(ssSmallWatermelon);
            drinks.Add(ssMediumWatermelon);
            drinks.Add(ssLargeWatermelon);

            drinks.Add(wwSmall);
            drinks.Add(wwMedium);
            drinks.Add(wwLarge);

            return drinks;
        }  
        
        /// <summary>
        /// Returns IEnumerable containing an instance of all available menu items
        /// </summary>
        /// <returns>List of available menu items</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks = Drinks().ToList();
            foreach(var drink in drinks)
            {
                menu.Add(drink);
            }

            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees = Entrees().ToList();
            foreach (var entree in entrees)
            {
                menu.Add(entree);
            }

            List<IOrderItem> sides = new List<IOrderItem>();
            sides = Sides().ToList();
            foreach (var side in sides)
            {
                menu.Add(side);
            }

            return menu;
        }
    }
}
