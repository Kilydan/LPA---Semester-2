using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    interface ISellable
    {
        int price { get; }
        int SellItem();
    }
}
