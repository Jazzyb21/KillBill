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
            //string opponentDescription = "";

            //switch (OpponentName)
            //{
            //    case DeadlyViperAssassinationSquad.ORen:
            //        opponentDescription = "\nO-Ren Ishii, Code-name: Cottonmouth. She is the a leader of the Tokoyo crime world." +
            //                                " She is the unofficial leader of Crazy 88 and Gogo Yubari. She is a highly proficient swordswoman" +
            //                                ", and her weapong of shoice is a curved shirasaya that can be weilded with either one or two hands";
            //        break;
            //    case DeadlyViperAssassinationSquad.Vernita:
            //        opponentDescription = "\nVernita Green, Code-name: Copperhead. Her specialty is her skill with edged weapons." +
            //                                " Vernita left her career as an assassin after the Two Pines Massacre, " +
            //                                "and went on to marry a doctor. Sonn after she gave birth to herbdaughter.";
            //        break;
            //    case DeadlyViperAssassinationSquad.Budd:
            //        opponentDescription = "\nBudd: Code-name, Sidewinder. Bud is recognized by Bill as\"the only man her ever loved\"." +
            //                                " Budd's choice of weapon is a shotgun and is very strategic.";
            //        break;
            //    case DeadlyViperAssassinationSquad.Elle:
            //        opponentDescription = "\nElle Driver, Code-name: California Mountain Snake. Her and Beatrix absolutely despised " +
            //            " each other while in the squad together. She is proficient in Hand-to-Hand combat, toxicology, and Swordsmanship.";
            //        break;
            //    case DeadlyViperAssassinationSquad.Bill:
            //        opponentDescription = "\nBill, Code-name: Snake Charmer. He is the leader of the Deadly Viper Assassination Squad." +
            //            " At one point, Beatrix was his love interest. Bill frequently used handguns on his targets and demonstrates a " +
            //            "lightning-quick draw with his revolver and precise aim with his truth-serum gun. He is also a master swordsman.";
            //        break;
            //}

            return string.Format("\n-----{0}--------\nLife:{1} of {2}\nHit Chance: {3}%\nWeapon:\n{4}\nBlock: {5}\nMin Damage: {6}\nMax Damage: {7}",
                                    Name, Life, MaxLife, HitChance, EquippedWeapon, Block, MinDamage, MaxDamage);
         }

        public override int CalcDamage()
        {
            Random rand = new Random();

            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
