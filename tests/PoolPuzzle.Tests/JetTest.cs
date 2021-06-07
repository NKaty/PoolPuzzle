using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PoolPuzzle.BusinessLogic;

namespace PoolPuzzle.Tests
{
    public class JetTest
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            var jet = new Jet();
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetSpeed()
        {
            var jet = new Jet();
            jet.SetSpeed(200);
            int speed = jet.GetSpeed();

            Assert.Equal(400, speed);
        }

        [Fact]
        public void ShouldHaveMiltiplierEquals2ByDefault()
        {
            var jet = new Jet();

            Assert.Equal(2, jet.Multiplier);
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetMultiplier()
        {
            var jet = new Jet();
            jet.Multiplier = 4;

            Assert.Equal(4, jet.Multiplier);
        }

        [Fact]
        public void ShouldBeAbleToAccelerate()
        {
            var jet = new Jet();
            jet.SetSpeed(200);

            Assert.Equal(400, jet.GetSpeed());

            jet.Accelerate();

            Assert.Equal(800, jet.GetSpeed());
        }
    }
}
