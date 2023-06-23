using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_M_22
{
    internal abstract class Card_abstract
    {
        public Card_abstract(string num,string name,int money) 
        {
            Number = num;
            HolderName = name;
            Money = money;
        }

        public abstract int Bonus { get; set; }
        public string Number { get; set; }
        public string HolderName { get; set; }
        public int Money { get; set; }

        public abstract bool Pay(int cost);
        
        public int Add(int amount)
        {
            return Money += amount;
        }

        public int AddWithBonus(int amount)
        {
            return Money += amount+Bonus;
        }
    }
}
