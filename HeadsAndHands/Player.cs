using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsAndHands
{
    internal class Player : Creation
    {
        private int chargesOfHeal = 3;
        public override void Heal()
        {
            if (!IsHeal())
                return;

            CurrentHitPoint += (HitPoint / 2) + (HitPoint % 2);
            if(CurrentHitPoint > HitPoint)
                CurrentHitPoint = HitPoint;

            chargesOfHeal--;
        }

        public override bool IsHeal()
        {
            return !(chargesOfHeal == 0) && IsAlive();
        }

        public Player() : base() { }

        public Player(int attack, int defence, int hitPoint, int M, int N) : base(attack, defence, hitPoint, M, N) { }
    }
}
