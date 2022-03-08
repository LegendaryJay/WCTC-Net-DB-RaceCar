using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class YourMother : RaceCar
    {
        public YourMother()
        {
            Name = "Your Mom";
            TopSpeed = 70;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Name} turns on with ease.");
        }
        public override void Brake()
        {
            Console.WriteLine($"{Name} never wants to stop!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Name} is a hard time turning off.");
        }
    }
}