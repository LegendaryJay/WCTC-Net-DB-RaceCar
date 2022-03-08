using System;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Everyone : Driver
    {
        public Everyone(RaceCar car) : base(car)
        {
            Name = "Everyone";
            SkillLevel = 2;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}