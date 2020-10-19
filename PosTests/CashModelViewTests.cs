/*
 * Author: Ethan Wheeler
 * Class: CashModelViewTests.cs
 * Purpose: Test the CashModelView.cs class 
 */

using System;
using Xunit;
using RoundRegister;
using PointOfSale;
using BleakwindBuffet.Data;
using System.Windows.Media;
using System.ComponentModel;

namespace PosTests
{
    public class CashModelViewTests
    {
        [Fact]
        public void ClassShouldImplementINotifyPropertyChangedInterface()
        {
            var cmv = new CashModelView(new Order());
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cmv);
        }

        [Fact]
        public void ShouldReturnCorrectChangeAmount()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());
            double total = cmv.AmountDueTextBlock;
            double change = total * -1;

            Assert.Equal(cmv.ChangeOwedTextBlock, change);

        }


        [Fact]
        public void AddingMoneyToDrawerNotifiesMoneyProperties()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "PenniesInDrawer", () =>
            {
                cmv.PenniesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "NicklesInDrawer", () =>
            {
                cmv.NicklesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "DimesInDrawer", () =>
            {
                cmv.DimesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "QuartersInDrawer", () =>
            {
                cmv.QuartersInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "HalfDollarsInDrawer", () =>
            {
                cmv.HalfDollarsInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "OnesInDrawer", () =>
            {
                cmv.OnesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "TwosInDrawer", () =>
            {
                cmv.TwosInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "FivesInDrawer", () =>
            {
                cmv.FivesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "TensInDrawer", () =>
            {
                cmv.TensInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "TwentysInDrawer", () =>
            {
                cmv.TwentysInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "FiftysInDrawer", () =>
            {
                cmv.FiftysInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "HundredsInDrawer", () =>
            {
                cmv.HundredsInDrawer += 1;
            });
        }


        [Fact]
        public void AddingMoneyToDrawerNotifiesTextBlockProperties() //2 properties: change due, amount due
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.PenniesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.NicklesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.DimesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.QuartersInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.HalfDollarsInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.OnesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.TwosInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.FivesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.TensInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.TwentysInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.FiftysInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.HundredsInDrawer += 1;
            });

            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.PenniesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.NicklesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.DimesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.QuartersInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.HalfDollarsInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.OnesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.TwosInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.FivesInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.TensInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.TwentysInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.FiftysInDrawer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.HundredsInDrawer += 1;
            });
        }

        [Fact]
        public void ChangingMoneyFromCustomerNotifiesMoneyProperties()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "PenniesFromCustomer", () =>
            {
                cmv.PenniesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "NicklesFromCustomer", () =>
            {
                cmv.NicklesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "DimesFromCustomer", () =>
            {
                cmv.DimesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "QuartersFromCustomer", () =>
            {
                cmv.QuartersFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "HalfDollarsFromCustomer", () =>
            {
                cmv.HalfDollarsFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "OnesFromCustomer", () =>
            {
                cmv.OnesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "TwosFromCustomer", () =>
            {
                cmv.TwosFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "FivesFromCustomer", () =>
            {
                cmv.FivesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "TensFromCustomer", () =>
            {
                cmv.TensFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "TwentysFromCustomer", () =>
            {
                cmv.TwentysFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "FiftysFromCustomer", () =>
            {
                cmv.FiftysFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "HundredsFromCustomer", () =>
            {
                cmv.HundredsFromCustomer += 1;
            });
        }

        [Fact]
        public void ChangingMoneyFromCustomerNotifiesAmountDueTextBlockProperty()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.PenniesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.NicklesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.DimesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.QuartersFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.HalfDollarsFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.OnesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.TwosFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.FivesFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.TensFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.TwentysFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.FiftysFromCustomer += 1;
            });
            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.HundredsFromCustomer += 1;
            });
        }

        [Fact]
        public void ChangingMoneyAsChangeNotifiesMoneyProperties()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "PenniesAsChange", () =>
            {
                cmv.PenniesAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "NicklesAsChange", () =>
            {
                cmv.NicklesAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "DimesAsChange", () =>
            {
                cmv.DimesAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "QuartersAsChange", () =>
            {
                cmv.QuartersAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "HalfDollarsAsChange", () =>
            {
                cmv.HalfDollarsAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "OnesAsChange", () =>
            {
                cmv.OnesAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "TwosAsChange", () =>
            {
                cmv.TwosAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "FivesAsChange", () =>
            {
                cmv.FivesAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "TensAsChange", () =>
            {
                cmv.TensAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "TwentysAsChange", () =>
            {
                cmv.TwentysAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "FiftysAsChange", () =>
            {
                cmv.FiftysAsChange += 1;
            });
            Assert.PropertyChanged(cmv, "HundredsAsChange", () =>
            {
                cmv.HundredsAsChange += 1;
            });
        }

        [Fact]
        public void ChangingChangeOwedTextBlockNotifiesChangeOwedTextBlock()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.ChangeOwedTextBlock = 1;
            });

        }

        [Fact]
        public void ChangingAmountDueTextBlockNotifiesChangeAndAmountProperties()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            Assert.PropertyChanged(cmv, "AmountDueTextBlock", () =>
            {
                cmv.AmountDueTextBlock = 1;
            });
            Assert.PropertyChanged(cmv, "ChangeOwedTextBlock", () =>
            {
                cmv.AmountDueTextBlock = 2;
            });

        }

        [Fact]
        public void CallingSetChangeBlocksNotifiesMoneyAsChangeProperties()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());
            cmv.AmountDueTextBlock = -186.91; //1 of every money type (negative)

            Assert.PropertyChanged(cmv, "PenniesAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "NicklesAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "DimesAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "QuartersAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "HalfDollarsAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "OnesAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "TwosAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "FivesAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "TensAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "TwentysAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "FiftysAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
            Assert.PropertyChanged(cmv, "HundredsAsChange", () =>
            {
                cmv.SetChangeBlocks();
            });
        }

        [Fact]
        public void PropertiesShouldUpdateCashDrawer()
        {
            CashDrawer.ResetDrawer();
            CashModelView cmv = new CashModelView(new Order());

            cmv.PenniesInDrawer = 1;
            cmv.NicklesInDrawer = 1;
            cmv.DimesInDrawer = 1;
            cmv.QuartersInDrawer = 1;
            cmv.HalfDollarsInDrawer = 1;
            cmv.OnesInDrawer = 1;
            cmv.TwosInDrawer = 1;
            cmv.FivesInDrawer = 1;
            cmv.TensInDrawer = 1;
            cmv.TwentysInDrawer = 1;
            cmv.FiftysInDrawer = 1;
            cmv.HundredsInDrawer = 1;

            Assert.Equal(CashDrawer.Pennies, cmv.PenniesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.NicklesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.DimesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.QuartersInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.HalfDollarsInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.OnesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TwosInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.FivesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TensInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TwentysInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.FiftysInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.HundredsInDrawer);

            cmv.PenniesFromCustomer = 1;
            cmv.NicklesFromCustomer = 1;
            cmv.DimesFromCustomer = 1;
            cmv.QuartersFromCustomer = 1;
            cmv.HalfDollarsFromCustomer = 1;
            cmv.OnesFromCustomer = 1;
            cmv.TwosFromCustomer = 1;
            cmv.FivesFromCustomer = 1;
            cmv.TensFromCustomer = 1;
            cmv.TwentysFromCustomer = 1;
            cmv.FiftysFromCustomer = 1;
            cmv.HundredsFromCustomer = 1;

            Assert.Equal(CashDrawer.Pennies, cmv.PenniesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.NicklesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.DimesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.QuartersInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.HalfDollarsInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.OnesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TwosInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.FivesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TensInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TwentysInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.FiftysInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.HundredsInDrawer);

            cmv.PenniesAsChange = 1;
            cmv.NicklesAsChange = 1;
            cmv.DimesAsChange = 1;
            cmv.QuartersAsChange = 1;
            cmv.HalfDollarsAsChange = 1;
            cmv.OnesAsChange = 1;
            cmv.TwosAsChange = 1;
            cmv.FivesAsChange = 1;
            cmv.TensAsChange = 1;
            cmv.TwentysAsChange = 1;
            cmv.FiftysAsChange = 1;
            cmv.HundredsAsChange = 1;

            Assert.Equal(CashDrawer.Pennies, cmv.PenniesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.NicklesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.DimesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.QuartersInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.HalfDollarsInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.OnesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TwosInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.FivesInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TensInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.TwentysInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.FiftysInDrawer);
            Assert.Equal(CashDrawer.Pennies, cmv.HundredsInDrawer);

        }

        
    }
}
