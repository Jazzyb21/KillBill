﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillBillLibrary;

namespace OpponentLibrary
{
    class Vernita : Opponent
    {
        // no fields or properties this time b/b they aer inherited from the parent class

        //ctor
        public Vernita(string name, int hitChance, int block, int life, int maxLife, Weapon equippedWeapon, int minDamage, int maxDamage) : base(name, hitChance, block, life, maxLife, equippedWeapon, minDamage, maxDamage)
        {

        }

        public override string ToString()
        {
            string description = "\nVernita Green, Code-name: Copperhead.Her specialty is her skill with edged weapons." +
                                 " Vernita left her career as an assassin after the Two Pines Massacre, " +
                                 "and went on to marry a doctor. Sonn after she gave birth to herbdaughter.";
            return base.ToString() + "\nDescription: " + description; 
        }
    }
}
