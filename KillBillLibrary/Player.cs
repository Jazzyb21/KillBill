using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillBillLibrary
{
    public sealed class Player : Character
    //The sealed keyword indicates that this class cannot be used as a base class for other classes
    //no more inheritance can occur
    {

        // no fields or propeties at this time b/c they are inherited from the parent class

        //ctor
        public Player(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon) : base(name, hitChance, block, life, maxLife, equippedWeapon)
        {
           
        }

        public override string ToString()
        {
            string playerDescription = "\n\nBeatrix Kiddo, also known as \"The Bride\"." +
                "After her premature retirement from her assassination career upon becoming pregnant, " +
                "Beatrix left the squad to escape the life of an assassin and start a new one for her " +
                "unborn daughter. However, Beatrix's friends and her fiance were murdered at the marriage " +
                "rehearsal. But Beatrix herself was shot in the head and put into a four-year coma. " +
                "Once she woke up from her coma, Beatrix plots her deadly vengeance against all members " +
                "of the Deadly Viper Assassination Squad, " +
                "including Bill himself.";

            return string.Format("\n-----{0}--------\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon: {4}\nBlock: {5}\nPlayer Description: {6}",
                                    Name, Life, MaxLife, HitChance, EquippedWeapon, Block, playerDescription);
        }

        //We are overriding the calc damage in player to use their weapon properties of MinDamage and MaxDamage
        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();

            //determine damamge
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
