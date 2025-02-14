﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Arena
    {
        public Hero HeroA { get; private set; }

        public Hero HeroB { get; private set;}

        public Hero HeroC{ get; private set; }

        public Hero HeroD { get; private set; }

        public Hero HeroF { get; private set; }

        public GameEventListener EventListener { get; set; }

        public Arena(Hero a, Hero b, Hero c, Hero d,Hero f)
        {
            HeroA = a;
            HeroB = b;
            HeroC = c;
            HeroD = d;
            HeroF = f;
        }

        public Hero Battle()
        {
            Hero attacker, defender;
            attacker = HeroA;
            defender = HeroB;
            while (true)
            {
                int damage = attacker.Attack();
                defender.TakeDamage(damage);

                if (EventListener != null)
                {
                    EventListener.GameRound(attacker, defender, damage);
                }

                if (defender.IsDead) return attacker;

                Hero temp = attacker;
                attacker = defender;
                defender = temp;
            }
        }
    }
}
