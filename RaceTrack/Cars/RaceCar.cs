using System;

namespace RaceTrack.RaceTrack.Cars
{
    public abstract class RaceCar
    {
        protected RaceCar()
        {
            Position = 0;
        }

        public string Name { get; set; }
        public int Position { get; set; }
        protected int TopSpeed { get; set; }

        public void Accelerate(int driverSkill)
        {
            // applying a random amount of variability to affect the outcome
            var random = new Random();
            var randomRange = random.Next(-1, 20);
            Position += driverSkill * TopSpeed * randomRange;

            switch (Position)
            {
                case > 0:
                    Console.WriteLine($"{Name} moves ahead to {Position}!");
                    break;
                case < 0:
                    Console.WriteLine($"{Name} moves backwards to {Position}!??");
                    break;
                default:
                    Console.WriteLine($"{Name} has stopped!?");
                    break;
            }
        }

        public abstract void StartEngine();

        public virtual void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine has shut down");
        }

        public virtual void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
    }
}