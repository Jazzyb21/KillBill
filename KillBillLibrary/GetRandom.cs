using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillBillLibrary
{
    public class GetRandom
    {
        public static string GetRoom()
        {
            string[] rooms =
            {
                "\nThe House of Blue Leaves is a Japanese bar and the headquarters of O-Ren Ishii and the Crazy 88." +
                " It is a big open space with a second floor. On the first floor the 5,6,7,8's are performing Woo-Hoo." +
                "Outside there is Blue Leaves Pond area.",

                "\nA surburban house in quiet neighbor. Vernita Green's living room and kitchen is the perfect place for a fight.",

                "\nA wood coffin--compliments of Budd after he shot you in the chest with rock salt and sedated you." +
                "You are trapped 6 feet under with a flashlight in grave that was meant for a woman named Paula Schulz.",

                "\nBudd's small trailer, in the California desert. It has wood panels and stacks of cash all over the floor.",

                "\nBill's House. A wide open estate in Mexico. You walk in to find that your daughter is very much alive."
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }

        public static Weapon GetWeaponPlayer()
        {
            Weapon hanzoSword = new Weapon("Hatorri Hanzo Sword", 3, 7, 10);
            Weapon blackMamba = new Weapon("Black Mamba", 8, 10, 8);
            Weapon fivePtExplodingHeart = new Weapon("Five Point Exploding Death Heart", 10, 10, 10);
            Weapon kaboomCereal = new Weapon("Kaboom Cereal", 3, 5, 5);
            Weapon threeInchPunch = new Weapon("Three Inch Punch", 1, 3, 5);

            Weapon[] weaponsPlayer = { hanzoSword, blackMamba, fivePtExplodingHeart, kaboomCereal, threeInchPunch };

            Random rand = new Random();
            int randNbr = rand.Next(weaponsPlayer.Length);

            Weapon weaponP = weaponsPlayer[randNbr];

            return weaponP;

        }


        public static Weapon GetWeaponOpponent()
        {
            Weapon hanzoSword = new Weapon("Hatorri Hanzo Sword", 3, 7, 6);
            Weapon blackMamba = new Weapon("Black Mamba", 8, 10, 2);
            Weapon fivePtExplodingHeart = new Weapon("Five Point Exlpoding Death Heart", 10, 10, 10);
            Weapon kaboomCereal = new Weapon("Kaboom Cereal", 3, 5, 4);
            Weapon threeInchPunch = new Weapon("Three Inch Punch", 1, 3, 4);

            Weapon[] weapons = { hanzoSword, blackMamba, fivePtExplodingHeart, kaboomCereal, threeInchPunch };

            Random rand = new Random();
            int randNbr = rand.Next(weapons.Length);

            Weapon weapon = weapons[randNbr];

            return weapon;

        }

        public static Opponent GetOpponent()
        {

            Opponent orenIshii = new Opponent(DeadlyViperAssassinationSquad.ORen, 70, 35, 1, 1, GetWeaponOpponent(), 3, 8);
            Opponent vernitaGreen = new Opponent(DeadlyViperAssassinationSquad.Vernita, 40, 30, 5, 10, GetWeaponOpponent(), 1, 5);
            Opponent bud = new Opponent(DeadlyViperAssassinationSquad.Budd, 20, 30, 2, 8, GetWeaponOpponent(), 2, 6);
            Opponent elle = new Opponent(DeadlyViperAssassinationSquad.Elle, 80, 55, 6, 9, GetWeaponOpponent(), 5, 9);
            Opponent bill = new Opponent(DeadlyViperAssassinationSquad.Bill, 90, 60, 5, 10, GetWeaponOpponent(), 7, 9);

            Opponent[] opponents = { orenIshii, vernitaGreen, bud, elle, bill };

            Random rand = new Random();
            int randNbr = rand.Next(opponents.Length);

            Opponent opponent = opponents[randNbr];

            return opponent;
        }
    }
}
