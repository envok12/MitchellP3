using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitchellP3
{
    class LogoOrderItem
    {

        private bool hasLogo = false;
        private string itemType = "mug";
        private int numColors = 0;
        private int numItems = 0;
        private string theText = "none";
        private int itemID = -1;
        private decimal totalPrice;


        public LogoOrderItem(bool hasLogo, string itemType, int numColors, int numItems, string text, int itemID)
        {
            HasLogo = hasLogo;
            ItemType = itemType;
            NumColors = numColors;
            NumItems = numItems;
            TheText = theText;
            ItemID = itemID;

        }

        public LogoOrderItem(string text, bool hasLogo) : this(false, "mug", 0, 0, "none", -1)
        {

        }

        public LogoOrderItem() : this(false, "mug", 0, 0, "none", -1)
        {

        }
        public bool HasLogo
        {
            get
            {
                return hasLogo;
            }

            set
            {
                hasLogo = value;
                Calc();
            }
        }

        public string ItemType
        {
            get
            {
                return itemType;
            }
            set
            {
                itemType = value;
                Calc();
            }

        }

        public int NumColors
        {
            get
            {
                return numColors;
            }
            set
            {
                numColors = value;
                Calc();
            }

        }

        public int NumItems
        {
            get
            {
                return numItems;
            }
            set
            {
                numItems = value;
                Calc();
            }
        }

        public string TheText
        {
            get
            {
                return theText;
            }
            set
            {
                theText = value;
                Calc();
            }
        }

        public int ItemID
        {
            get;
            set;
        }

        public decimal TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        private void Calc()
        {
            double basePrice = 0.0;
            double pen = 1.0;
            double mug = 3.5;
            double usb = 4.0;
            double costOfText = 0.1;
            double numColorsPrice = 0.3;

            if (itemType == "Pen")
            {
                basePrice = pen * numItems * costOfText;

            }
            if(itemType == "Mug")
            {
                basePrice = mug * numItems * costOfText;

            }
            if(itemType == "USB")
            {
                basePrice = usb * numItems * costOfText;
            }
            
            if(numColors != 0)
            {
                totalPrice = (decimal)(basePrice * numColorsPrice);
            }
            
        }
    
        public string GetOrderSummary()
        {
            string s = " ";
            //return summary box output??
            return s;
        }
    }
    
}