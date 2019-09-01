using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillBillLibrary
{
    public abstract class Character
    {
        //fields
        private int _life;

        //properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public int Life
        {
            get { return _life; }
            set { _life = value >= 0 && value < MaxLife ? _life = value : value = 1; }
        }

        //ctor
        public Character(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            EquippedWeapon = equippedWeapon;
        }

        //without name
        public Character(int hitChance, int block, int life, int maxLife, Weapon equippedWeapon)
        {
            MaxLife = maxLife;
            HitChance = hitChance;
            Block = block;
            Life = life;
            EquippedWeapon = equippedWeapon;
            
        }

        public virtual int CalcBlock()
        {
            //The virtual keyword allows child classes to override this but they dont have to
            //IF this is not overridden in a child clas, then the child will use the bas functionality below
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            //starting w/ just returning 0. We will override the method in opponent and player
            return 0;
        }
    }
}