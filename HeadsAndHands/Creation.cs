using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsAndHands
{
    internal abstract class Creation
    {
        public int Attack { get; }

        public int Defence { get; }

        public int HitPoint { get; }

        public int CurrentHitPoint { get; set; }

        public int DamageMin { get; }
        public int DamageMax { get; }

        public Creation() : this(1, 1, 10, 1, 1)
        {
        }

        public Creation(int attack, int defence, int hitPoint, int M, int N)
        {
            Attack = attack;

            Defence = defence;

            HitPoint = hitPoint;
            CurrentHitPoint = hitPoint;

            DamageMin = M;
            DamageMax = N;
        }
        public int Hit(Creation defending)
        {
            if (!this.IsAlive())
                return 0;

            int modifOfAttack = this.Attack - defending.Defence + 1;

            if (IsSuccessfulHit(modifOfAttack))
            {
                Random rnd = new Random();
                int takenDamage = rnd.Next(this.DamageMin, this.DamageMax);
                defending.TakenDamage(takenDamage);
                return takenDamage;
            }

            return 0;
        }

        private bool IsSuccessfulHit(int modifier)
        {
            Random rnd = new Random();
            int valueOfDice;
            if (modifier < 1)
            {
                valueOfDice = rnd.Next(1, 6);
                if (valueOfDice > 4)
                    return true;
            }
            else
            {
                for (int i = 0; i < modifier; i++)
                {
                    valueOfDice = rnd.Next(1, 6);
                    if (valueOfDice > 4)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void TakenDamage(int damage)
        {
            CurrentHitPoint -= damage;
            if (CurrentHitPoint < 0)
                CurrentHitPoint = 0;
        }

        public bool IsAlive()
        {
            return CurrentHitPoint != 0;
        }

        public virtual void Heal()
        {

        }

        public virtual bool IsHeal()
        {
            return false;
        }
    }
}
