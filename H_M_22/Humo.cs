﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_M_22
{
    internal class Humo : Card_abstract
    {
        public Humo(int num,string name,int money):base(num,name,money) { }
        public override int Bonus { get; set; } = 0;

        public override bool Pay(int cost)
        {
            if (Money - cost < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }

        public bool PayWireless(int cost)
        {
            if (Money-cost<0 && cost>50000)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }
    }
}
