using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillBillLibrary;
namespace OpponentLibrary
{
    class Budd : Opponent
    {
        // no fields or properties this time b/b they aer inherited from the parent class

        //ctor
        public Budd(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon, int minDamage, int maxDamage) : base(name, hitChance, block, life, maxLife, equippedWeapon, minDamage, maxDamage)
        {

        }

        public override string ToString()
        {
            string description = "\nBudd: Code-name, Sidewinder. Bud is recognized by Bill as\"the only man her ever loved\"." +
                                " Budd's choice of weapon is a shotgun and is very strategic.";
            return base.ToString() + "\nDescription: " + description;
        }
    }
}
}
