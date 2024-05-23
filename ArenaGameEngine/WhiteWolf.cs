using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class WhiteWolf : Hero
    {
        public WhiteWolf(string name) : base(name)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 45)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 45)
            {
                baseAttack = Health * 3;
                baseAttack = Strength * 4;
            }
            return baseAttack;
        }
    }
}
