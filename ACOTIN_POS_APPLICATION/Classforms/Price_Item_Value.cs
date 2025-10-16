using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACOTIN_POS_APPLICATION
{
    internal class Price_Item_Value
    {
        public string price, itemname, discount_amount;

        public void SetPriceItemValue(string item_name, string item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }

        public String GetItemName()
        {
            return itemname;
        }

        public String GetPrice()
        {
            return price;
        }

        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
        {
            this.discount_amount = discount_amt;
            this.itemname = priceItem;
        }

        public String GetPriceItem()
        {
            return price;
        }

        public String GetDiscountAmount()
        {
            return discount_amount;
        }
    }
}
