using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H_M_22
{
    internal class UzCard : Card_abstract
    {
        public UzCard(string num, string name, int money) : base(num, name, money){ }

        public override int Bonus { get; set; } = 5;

        public override bool Pay(int cost)
        {
            if (Money-cost<0)
            {
                return false;
            }
            else
            {
                Money-=cost;
                return true;
            }
        }
    }
}
