using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpponentLibrary;

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
            Weapon hanzoSword = new Weapon("Hatorri Hanzo Sword", 3, 7, 9);
            Weapon blackMamba = new Weapon("Black Mamba", 8, 10, 8);
            Weapon fivePtExplodingHeart = new Weapon("Five Point Exploding Death Heart", 10, 10, 10);
            Weapon kaboomCereal = new Weapon("Kaboom Cereal", 3, 5, 5);
            Weapon threeInchPunch = new Weapon("Three Inch Punch", 1, 3, 5);

            Weapon[] weaponsPlayer = { hanzoSword, blackMamba, fivePtExplodingHeart, kaboomCereal, threeInchPunch };

            Random rand = new Random();
            int randNbr = rand.Next(weaponsPlayer.Length);

            Weapon weaponP = weaponsPlayer[randNbr];

            Thread.Sleep(125);

            return weaponP;

        }


        public static Weapon GetWeaponOpponent()
        {
            Weapon hanzoSword = new Weapon("Hatorri Hanzo Sword", 3, 7, 6);
            Weapon blackMamba = new Weapon("Black Mamba", 8, 10, 2);
            Weapon fivePtExplodingHeart = new Weapon("Five Point Exploding Death Heart", 10, 10, 10);
            Weapon kaboomCereal = new Weapon("Kaboom Cereal", 3, 5, 4);
            Weapon threeInchPunch = new Weapon("Three Inch Punch", 1, 3, 4);

            Weapon[] weapons = { hanzoSword, blackMamba, fivePtExplodingHeart, kaboomCereal, threeInchPunch };

            Random rand = new Random();
            int randNbr = rand.Next(weapons.Length);

            Weapon weapon = weapons[randNbr];

            Thread.Sleep(100); // delay the random pick to make sure opponenet and player doesn't get the same weapon

            return weapon;

        }

        public static Opponent GetOpponent()
        {

            Vernita vernita = new Vernita("Vernita", 80, 2, 50, 50, GetWeaponOpponent(), 2, 5);

            Budd budd = new Budd("Budd",  60, 3, 50, 50, GetWeaponOpponent(), 2, 6);

            Elle elle = new Elle("Elle", 86, 4, 50, 50, GetWeaponOpponent(), 5, 9);

            Bill bill = new Bill("Bill", 90, 6, 50, 50, GetWeaponOpponent(), 7, 9);

            Oren oren = new Oren("O-Ren", 79, 5, 50, 50, GetWeaponOpponent(), 1, 5);

            Opponent[] opponents = { oren, vernita, budd, elle, bill };

            Random rand = new Random();
            int randNbr = rand.Next(opponents.Length);

            Opponent opponent = opponents[randNbr];

            return opponent;
        }
    }
}
