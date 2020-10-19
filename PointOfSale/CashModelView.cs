/*
 * Author: Ethan Wheeler
 * Modified On: 10/18/2020
 * Class name: CashModelView.cs
 * Purpose: Class used to represent the intermediate control in MVVC
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using RoundRegister;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interfaces;

namespace PointOfSale
{
    public class CashModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// EVent for changed property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for passed in Order instance
        /// </summary>
        private Order o;

        /// <summary>
        /// Private backing variable for total owed for order
        /// </summary>
        private double total = 0;

        /// <summary>
        /// Private backing variable to store the change to give to the customer
        /// </summary>
        private double change = 0;

        /// <summary>
        /// Constructs a new instance and initializes variabels
        /// </summary>
        /// <param name="o"></param>
        public CashModelView(Order o)
        {
            this.o = o;
            total = o.Total;
        }

        /// <summary>
        /// Represents pennies in the cash drawer
        /// </summary>
        public int PenniesInDrawer
        {
            get => CashDrawer.Pennies;
            set
            {
                CashDrawer.Pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents nickles in the cash drawer
        /// </summary>
        public int NicklesInDrawer
        {
            get => CashDrawer.Nickels;
            set
            {
                CashDrawer.Nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents dimes in the cash drawer
        /// </summary>
        public int DimesInDrawer
        {
            get => CashDrawer.Dimes;
            set
            {
                CashDrawer.Dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents quarters in the cash drawer
        /// </summary>
        public int QuartersInDrawer
        {
            get => CashDrawer.Quarters;
            set
            {
                CashDrawer.Quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents half dollars in the cash drawer
        /// </summary>
        public int HalfDollarsInDrawer
        {
            get => CashDrawer.HalfDollars;
            set
            {
                CashDrawer.HalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents ones in the cash drawer
        /// </summary>
        public int OnesInDrawer
        {
            get => CashDrawer.Ones;
            set
            {
                CashDrawer.Ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents twos in the cash drawer
        /// </summary>
        public int TwosInDrawer
        {
            get => CashDrawer.Twos;
            set
            {
                CashDrawer.Twos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents fives in the cash drawer
        /// </summary>
        public int FivesInDrawer
        {
            get => CashDrawer.Fives;
            set
            {
                CashDrawer.Fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents tens in the cash drawer
        /// </summary>
        public int TensInDrawer
        {
            get => CashDrawer.Tens;
            set
            {
                CashDrawer.Tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents twentys in the cash drawer
        /// </summary>
        public int TwentysInDrawer
        {
            get => CashDrawer.Twenties;
            set
            {
                CashDrawer.Twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentysInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents fiftys in the cash drawer
        /// </summary>
        public int FiftysInDrawer
        {
            get => CashDrawer.Fifties;
            set
            {
                CashDrawer.Fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftysInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents hundreds in the cash drawer
        /// </summary>
        public int HundredsInDrawer
        {
            get => CashDrawer.Hundreds;
            set
            {
                CashDrawer.Hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsInDrawer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        private int penniesFromCustomer = 0;
        private int nicklesFromCustomer = 0;
        private int dimesFromCustomer = 0;
        private int quartersFromCustomer = 0;
        private int halfDollarsFromCustomer = 0;
        private int onesFromCustomer = 0;
        private int twosFromCustomer = 0;
        private int fivesFromCustomer = 0;
        private int tensFromCustomer = 0;
        private int twentysFromCustomer = 0;
        private int fiftysFromCustomer = 0;
        private int hundredsFromCustomer = 0;

        /// <summary>
        /// Represents pennies from the customer
        /// </summary>
        public int PenniesFromCustomer
        {
            get => penniesFromCustomer;
            set
            {
                penniesFromCustomer = value;
                PenniesInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents nickles from the customer
        /// </summary>
        public int NicklesFromCustomer
        {
            get => nicklesFromCustomer;
            set
            {
                nicklesFromCustomer = value;
                NicklesInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents dimes from the customer
        /// </summary>
        public int DimesFromCustomer
        {
            get => dimesFromCustomer;
            set
            {
                dimesFromCustomer = value;
                DimesInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents quarters from the customer
        /// </summary>
        public int QuartersFromCustomer
        {
            get => quartersFromCustomer;
            set
            {
                quartersFromCustomer = value;
                QuartersInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents half dollars from the customer
        /// </summary>
        public int HalfDollarsFromCustomer
        {
            get => halfDollarsFromCustomer;
            set
            {
                halfDollarsFromCustomer = value;
                HalfDollarsInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents ones from the customer
        /// </summary>
        public int OnesFromCustomer
        {
            get => onesFromCustomer;
            set
            {
                onesFromCustomer = value;
                OnesInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents twos from the customer
        /// </summary>
        public int TwosFromCustomer
        {
            get => twosFromCustomer;
            set
            {
                twosFromCustomer = value;
                TwosInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents fives from the customer
        /// </summary>
        public int FivesFromCustomer
        {
            get => fivesFromCustomer;
            set
            {
                fivesFromCustomer = value;
                FivesInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents tens from the customer
        /// </summary>
        public int TensFromCustomer
        {
            get => tensFromCustomer;
            set
            {
                tensFromCustomer = value;
                TensInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents twentys from the customer
        /// </summary>
        public int TwentysFromCustomer
        {
            get => twentysFromCustomer;
            set
            {
                twentysFromCustomer = value;
                TwentysInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentysFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents fiftys from the customer
        /// </summary>
        public int FiftysFromCustomer
        {
            get => fiftysFromCustomer;
            set
            {
                fiftysFromCustomer = value;
                FiftysInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftysFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        /// <summary>
        /// Represents hundreds from the customer
        /// </summary>
        public int HundredsFromCustomer
        {
            get => hundredsFromCustomer;
            set
            {
                hundredsFromCustomer = value;
                HundredsInDrawer += value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsFromCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
            }
        }

        private int penniesAsChange = 0;
        private int nicklesAsChange = 0;
        private int dimesAsChange = 0;
        private int quartersAsChange = 0;
        private int halfDollarsAsChange = 0;
        private int onesAsChange = 0;
        private int twosAsChange = 0;
        private int fivesAsChange = 0;
        private int tensAsChange = 0;
        private int twentysAsChange = 0;
        private int fiftysAsChange = 0;
        private int hundredsAsChange = 0;

        /// <summary>
        /// Represents pennies to give as change
        /// </summary>
        public int PenniesAsChange
        {
            get => penniesAsChange;
            set
            {
                penniesAsChange = value;
                PenniesInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents nickles to give as change
        /// </summary>
        public int NicklesAsChange
        {
            get => nicklesAsChange;
            set
            {
                nicklesAsChange = value;
                NicklesInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents dimes to give as change
        /// </summary>
        public int DimesAsChange
        {
            get => dimesAsChange;
            set
            {
                dimesAsChange = value;
                DimesInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesAsChange"));
              //  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents quarters to give as change
        /// </summary>
        public int QuartersAsChange
        {
            get => quartersAsChange;
            set
            {
                quartersAsChange = value;
                QuartersInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents half dollars to give as change
        /// </summary>
        public int HalfDollarsAsChange
        {
            get => halfDollarsAsChange;
            set
            {
                halfDollarsAsChange = value;
                HalfDollarsInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsAsChange"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents ones to give as change
        /// </summary>
        public int OnesAsChange
        {
            get => onesAsChange;
            set
            {
                onesAsChange = value;
                OnesInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesAsChange"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents twos to give as change
        /// </summary>
        public int TwosAsChange
        {
            get => twosAsChange;
            set
            {
                twosAsChange = value;
                TwosInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents fives to give as change
        /// </summary>
        public int FivesAsChange
        {
            get => fivesAsChange;
            set
            {
                fivesAsChange = value;
                FivesInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents tens to give as change
        /// </summary>
        public int TensAsChange
        {
            get => tensAsChange;
            set
            {
                tensAsChange = value;
                TensInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents twentys to give as change
        /// </summary>
        public int TwentysAsChange
        {
            get => twentysAsChange;
            set
            {
                twentysAsChange = value;
                TwentysInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentysAsChange"));
              //  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents fiftys to give as change
        /// </summary>
        public int FiftysAsChange
        {
            get => fiftysAsChange;
            set
            {
                fiftysAsChange = value;
                FiftysInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftysAsChange"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents hundreds to give as change
        /// </summary>
        public int HundredsAsChange
        {
            get => hundredsAsChange;
            set
            {
                hundredsAsChange = value;
                HundredsInDrawer -= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsAsChange"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents text in the "ChangeOwedTextBlock"
        /// </summary>
        public double ChangeOwedTextBlock
        {
            get
            {


                if (AmountDueTextBlock * -1 > 0)
                {
                    // HundredsAsChange += 1; //-= somewhere too???

                    SetChangeBlocks();

                    return AmountDueTextBlock * -1;
                }
                   
                else
                    return 0;


                // if (total < 0)
                // {
                /* change = total * -1;
                 PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
                 return change;*/
                //    if (change > 0) return change;
                //    else return 0;
                // }    
                // else return 0;

                /*double returnme = 0;

                returnme += PenniesAsChange * 0.01;
                returnme += NicklesAsChange * 0.05;
                returnme += DimesAsChange * 0.1;
                returnme += QuartersAsChange * 0.25;
                returnme += HalfDollarsAsChange * 0.5;
                returnme += OnesAsChange;
                returnme += TwosAsChange * 2;
                returnme += FivesAsChange * 5;
                returnme += TensAsChange * 10;
                returnme += TwentysAsChange * 20;
                returnme += FiftysAsChange * 50;
                returnme += HundredsAsChange * 100;

                return returnme;*/
            }
            set
            {
                change = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock"));
            }
        }

        /// <summary>
        /// Represents text in the "AmountDueTextBlock"
        /// </summary>
        public double AmountDueTextBlock
        {
            get
            {
                double returnme = 0;

                returnme += PenniesFromCustomer * .01;
                returnme += NicklesFromCustomer * .05;
                returnme += DimesFromCustomer * .1;
                returnme += QuartersFromCustomer * .25;
                returnme += HalfDollarsFromCustomer * .5;
                returnme += OnesFromCustomer;
                returnme += TwosFromCustomer * 2;
                returnme += FivesFromCustomer * 5;
                returnme += TensFromCustomer * 10;
                returnme += TwentysFromCustomer * 20;
                returnme += FiftysFromCustomer * 50;
                returnme += HundredsFromCustomer * 100;

                return Math.Round(total - returnme, 2);
            }
            set
            {
                total = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTextBlock"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedTextBlock")); //possibly not, but above is good
            }
        }

        /// <summary>
        /// Updates the "give as change" text blocks in the UI
        /// </summary>
        public void SetChangeBlocks() 
        {
            
            
            double totNonNeg = 0;

            
            totNonNeg = AmountDueTextBlock * -1;
            //at some point, reset hundredsAsChange to 0 and update the property for when minus 1 is hit

            if (totNonNeg > 0) 
            {
                if ((int)Math.Floor(totNonNeg / 100) != 0)
                {
                    hundredsAsChange += (int)Math.Floor(totNonNeg / 100);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsAsChange"));
                    totNonNeg -= hundredsAsChange * 100;
                }
                    
                else if ((int)Math.Floor(totNonNeg / 50) != 0)
                {
                    fiftysAsChange += (int)Math.Floor(totNonNeg / 50);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftysAsChange"));
                    totNonNeg -= fiftysAsChange * 50;
                }
                else if ((int)Math.Floor(totNonNeg / 20) != 0)
                {
                    twentysAsChange += (int)Math.Floor(totNonNeg / 20);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentysAsChange"));
                    totNonNeg -= twentysAsChange * 20;
                }
                else if ((int)Math.Floor(totNonNeg / 10) != 0)
                {
                    tensAsChange += (int)Math.Floor(totNonNeg / 10);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensAsChange"));
                    totNonNeg -= tensAsChange * 10;
                }
                else if ((int)Math.Floor(totNonNeg / 5) != 0)
                {
                    fivesAsChange += (int)Math.Floor(totNonNeg / 5);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesAsChange"));
                    totNonNeg -= fivesAsChange * 5;
                }
                else if ((int)Math.Floor(totNonNeg / 1) != 0) //never true
                {
                    onesAsChange += (int)Math.Floor(totNonNeg / 1);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesAsChange"));
                    totNonNeg -= onesAsChange * 1;
                }
                else if ((int)Math.Floor(totNonNeg * 100) / 50 != 0)
                {
                    halfDollarsAsChange += (int)Math.Floor((totNonNeg * 100) / 50);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsAsChange"));
                    totNonNeg -= halfDollarsAsChange * .5;///////////
                }
                else if ((int)Math.Floor(totNonNeg * 100) / 25 != 0)
                {
                    quartersAsChange += (int)Math.Floor(totNonNeg * 100) / 25;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersAsChange"));
                    totNonNeg -= quartersAsChange * .25;
                }
                else if ((int)Math.Floor(totNonNeg * 100) / 50 != 0)
                {
                    dimesAsChange += (int)Math.Floor(totNonNeg * 100) / 10;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesAsChange"));
                    totNonNeg -= dimesAsChange * .1;
                }
                else if ((int)Math.Floor(totNonNeg * 100) / 5 != 0)
                {
                    nicklesAsChange += (int)Math.Floor(totNonNeg * 100) / 5;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesAsChange"));
                    totNonNeg -= nicklesAsChange * .05;
                }
                else if ((int)Math.Floor(totNonNeg * 100) / 1 != 0)
                {
                    penniesAsChange += (int)Math.Floor(totNonNeg * 100) / 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesAsChange"));
                    totNonNeg -= penniesAsChange * .01;
                }

                
            }



        }

        /// <summary>
        /// Opens cash drawer
        /// </summary>
        public void FinalizeCashTransaction() 
        {
            CashDrawer.OpenDrawer();
           
        }

        /// <summary>
        /// Prints reciept
        /// </summary>
        public void PrintReceipt()
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
            RecieptPrinter.PrintLine("Payment method: Cash");
            RecieptPrinter.PrintLine("Change: " + (AmountDueTextBlock * -1));

            RecieptPrinter.CutTape();
            
        }

        /// <summary>
        /// Helper method for PrintReceipt
        /// </summary>
        /// <param name="item">Menu item</param>
        /// <returns>String of special instructions for item</returns>
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
    }
}
