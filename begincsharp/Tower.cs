using System;

namespace begincsharp
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
        protected virtual string Name => this.GetType().Name;
        
        private static readonly Random _random = new Random();
        
        private readonly MapLocation _location;
        
        public Tower(MapLocation location)
        {
            _location = location;
        }
        
        private bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    Console.WriteLine(Name + " is firing at invader at " + invader.Location + "!");
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit an invader!");
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}