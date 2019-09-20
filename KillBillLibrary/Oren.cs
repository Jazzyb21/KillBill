using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillBillLibrary;

namespace OpponentLibrary
{
    public class Oren : Opponent
    {
        // no fields or propeties at this time b/c they are inherited from the parent class

        //ctor
        public Oren(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon, int minDamage, int maxDamage) : base(name, hitChance, block, life, maxLife, equippedWeapon, minDamage, maxDamage)
        {

        }

        public override string ToString()
        {
            string description = "\nO-Ren Ishii, Code-name: Cottonmouth. She is the a leader of the Tokoyo crime world." +
                                       " She is the unofficial leader of Crazy 88 and Gogo Yubari. She is a highly proficient swordswoman" +
                                       ", and her weapong of shoice is a curved shirasaya that can be weilded with either one or two hands";
            return base.ToString() + "\nDescription: " + "\n" + description;
        }

        //public override int CalcBlock()
        //{
        //    int calculatedBlock = Block;

        //    return calculatedBlock += calculatedBlock * 2;

        //}

    }
}
