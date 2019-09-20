using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillBillLibrary;

namespace OpponentLibrary
{
    class Bill : Opponent
    {
        // no fields or propeties at this time b/c they are inherited from the parent class

        //ctor
        public Bill(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon, int minDamage, int maxDamage) : base(name, hitChance, block, life, maxLife, equippedWeapon, minDamage, maxDamage)
        {

        }

        public override string ToString()
        {
            string description = "\nBill, Code-name: Snake Charmer. He is the leader of the Deadly Viper Assassination Squad." +
                            " At one point, Beatrix was his love interest. Bill frequently used handguns on his targets and demonstrates a " +
                           "lightning-quick draw with his revolver and precise aim with his truth-serum gun. He is also a master swordsman.";
            return base.ToString() + "\nDescription: " + "\n" + description;
        }
    }
}
