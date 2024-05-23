using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class RedRanger : Hero
    {
        public RedRanger() : this("Jadon")
        { 
        
        }
        public int Speed { get;set; }
        public int Flexibility { get;set; }
        public int Stealth { get;set; }

        public RedRanger(string name,int speed, int flexibility, int stealth) : base(name)
        {
            this.Speed = speed;
            this.Flexibility = flexibility;
            this.Stealth = stealth;
        }

        public RedRanger(string name) : base(name)
        {
            hitCount = 0;
        }

        private int hitCount;

        public override int Attack()
        {
            hitCount = hitCount + 4;
            int baseAttack = base.Attack();
            if (hitCount == 7)
            {
                baseAttack = baseAttack * 3;
                hitCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(78, 91);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
