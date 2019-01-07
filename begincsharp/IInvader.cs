using System;
using System.Collections.Generic;
using System.Text;

namespace begincsharp
{
    interface IInvader
    {
        //defines public members
        MapLocation Location{get;}

        // True if the invader has reached the end of the path
        bool HasScored { get; }

        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);
    }
}
