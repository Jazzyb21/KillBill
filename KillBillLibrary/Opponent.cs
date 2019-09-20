using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillBillLibrary
{
    public class Opponent : Character
    {
        //fields
        private int _minDamage;

        ////properties
        
        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set {
                    // cant be more than maxdamage
                _minDamage = value > 0 && value <= MaxDamage ? _minDamage = value : _minDamage = 1;
            }
        }




        //ctor
        public Opponent(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon, int minDamage, int maxDamage) : base(name, hitChance, block, life, maxLife, equippedWeapon)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            

            return string.Format("\n-----{0}--------\nLife:{1} of {2}\nHit Chance: {3}%\nWeapon:\n{4}\nBlock: {5}%\nMin Damage: {6}\nMax Damage: {7}",
                                    Name, Life, MaxLife, HitChance, EquippedWeapon, Block, MinDamage, MaxDamage);

         }

        //public override int CalcDamage()
        //{
        //    Random rand = new Random();

        //    return rand.Next(MinDamage, MaxDamage + 1);
        //}

        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();

            //determine damamge
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        //public override int CalcHitChance()
        //{
        //    return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        //}
    }
}
