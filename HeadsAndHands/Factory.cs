using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HeadsAndHands
{
    internal class Factory
    {
        static public Creation Create(int attack, int defence, int hitPoint, int M, int N, bool isPlayer)
        {
            if (attack > 20)
                attack = 20;
            else if (attack < 1)
                attack = 1;

            if (defence > 20)
                defence = 20;
            else if (defence < 1)
                defence = 1;

            if (hitPoint < 1)
                hitPoint = 1;

            if (N < 1)
                N = 1;
            if (M < 1)
                M = 1;
            if (N < M)
            {
                int forSwap;
                forSwap = N;
                N = M;
                M = forSwap;
            }

           if (isPlayer)
                return new Player(attack, defence, hitPoint, M, N);
            else
                return new Monster(attack, defence, hitPoint, M, N);
        }

        public static Creation CreateDemon() => new Monster(12, 12, 66, 9, 15);
    }
}
