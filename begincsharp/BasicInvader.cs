using System;
using System.Collections.Generic;
using System.Text;

namespace begincsharp
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; }

        public BasicInvader(Path path) : base(path)
        {

        }
    }
}
