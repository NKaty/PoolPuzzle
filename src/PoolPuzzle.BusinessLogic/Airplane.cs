namespace PoolPuzzle.BusinessLogic
{
    public class Airplane
    {
        private int _speed;

        public virtual int Multiplier { get; set; } = 1;

        public virtual void SetSpeed(int speed)
        {
            _speed = speed;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}