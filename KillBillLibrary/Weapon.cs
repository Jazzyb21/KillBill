using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillBillLibrary
{
    public class Weapon
    {
        // field
        private int _minDamage;
        
        //properties
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }



        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value >= 0 && value <= MaxDamage ? _minDamage = value: _minDamage = 1; }
        }

        //ctor
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance)
        {
            //if you have any properties that have business rules that are based off any properties
            //Set the 'other' property first
            MaxDamage = maxDamage; // we set this property first because MinDamage business logic is dependent upon it
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\nBonus Hit: {3}", Name, MinDamage, MaxDamage, BonusHitChance);
        }

    }
}
