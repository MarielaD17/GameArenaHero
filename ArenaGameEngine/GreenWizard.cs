using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class GreenWizard : Hero
    {
        public GreenWizard() : this("Sylas")
        {

        }
        public int Invisibility{ get; set; }
        public int Teleportation{ get; set; }
        public int Magic { get; set; }

        public GreenWizard(string name, int invisibility, int teleportation, int magic) : base(name)
        {
            this.Invisibility = invisibility;
            this.Teleportation = teleportation;
            this.Magic = magic;
        }

        public GreenWizard(string name) : base(name)
        {
            hitCount = 0;
        }

        private int hitCount;

        public override int Attack()
        {
            hitCount = hitCount + 6;
            int baseAttack = base.Attack();
            if (hitCount == 8)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(19, 31);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}