using System;
using Xunit;
using PoolPuzzle.BusinessLogic;

namespace PoolPuzzle.Tests
{
    public class AirplaneTest
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            var airplane = new Airplane();
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetSpeed()
        {
            var airplane = new Airplane();
            airplane.SetSpeed(200);
            int speed = airplane.GetSpeed();

            Assert.Equal(200, speed);
        }

        [Fact]
        public void ShouldHaveMiltiplierEquals1ByDefault()
        {
            var airplane = new Airplane();

            Assert.Equal(1, airplane.Multiplier);
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetMultiplier()
        {
            var airplane = new Airplane();
            airplane.Multiplier = 2;

            Assert.Equal(2, airplane.Multiplier);
        }
    }
}
