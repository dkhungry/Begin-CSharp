using System;
using System.Collections.Generic;
using System.Text;

namespace begincsharp
{
    class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();

        public override int Health { get; protected set; }

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < 0.5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at invader and missed due to shielding!");
            }
            
        }
    }
}
