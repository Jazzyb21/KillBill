using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillBillLibrary;

namespace OpponentLibrary
{
    class Elle : Opponent
    {
        // no fields or propeties at this time b/c they are inherited from the parent class

        //ctor
        public Elle(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon, int minDamage, int maxDamage) : base(name, hitChance, block, life, maxLife, equippedWeapon, minDamage, maxDamage)
        {

        }

        public override string ToString()
        {
            string description = "\nElle Driver, Code-name: California Mountain Snake. Her and Beatrix absolutely despised " +
                        " each other while in the squad together. She is proficient in Hand-to-Hand combat, toxicology, and Swordsmanship.";
            return base.ToString() + "\nDescription: " + description;
        }
    }
}
