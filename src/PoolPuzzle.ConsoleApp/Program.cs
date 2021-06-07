using System;
using PoolPuzzle.BusinessLogic;

namespace PoolPuzzle.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane biplane = new Airplane();
            biplane.SetSpeed(212);
            Console.WriteLine(biplane.GetSpeed());
            Jet boeing = new Jet();
            boeing.SetSpeed(422);
            Console.WriteLine(boeing.GetSpeed());
            int x = 0;
            while (x < 4)
            {
                boeing.Accelerate();
                Console.WriteLine(boeing.GetSpeed());
                if (boeing.GetSpeed() > 5000)
                {
                    biplane.SetSpeed(biplane.GetSpeed() * 2);
                }
                else
                {
                    boeing.Accelerate();
                }
                x++;
            }
            Console.WriteLine(biplane.GetSpeed());
        }
    }
}
