using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsAndHands
{
    internal class Monster : Creation
    {
        public Monster() : base() { }

        public Monster(int attack, int defence, int hitPoint, int M, int N) : base(attack, defence, hitPoint, M, N) { }
    }
}
