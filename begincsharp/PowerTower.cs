using System;
using System.Collections.Generic;
using System.Text;

namespace begincsharp
{
    class PowerTower : Tower
    {
        protected override int Power => 2;
        protected override int Range => 2;

        public PowerTower(MapLocation location) : base(location)
        {

        }
    }
}
