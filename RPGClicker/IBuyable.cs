using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClicker
{
    interface IBuyable
    {
        int price { get; }
        int BuyPrice();
    }
}
