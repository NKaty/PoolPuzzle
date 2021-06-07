using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzle.BusinessLogic
{
    public class Jet : Airplane
    {
        public override int Multiplier { get; set; } = 2;

        public override void SetSpeed(int speed)
        {
            base.SetSpeed(speed * Multiplier);
        }

        public void Accelerate()
        {
            base.SetSpeed(GetSpeed() * Multiplier);
        }
    }
}
