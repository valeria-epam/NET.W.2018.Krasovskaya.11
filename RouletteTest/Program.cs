using System;
using RouletteTask;

namespace RouletteTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var roulette = new Roulette();

            var black = new BlackListner();
            var red = new RedListner();
            var even = new EvenListner();
            var odd = new OddListner();
            var number = new NumberListner(0);

            black.Register(roulette);
            red.Register(roulette);
            even.Register(roulette);
            odd.Register(roulette);
            number.Register(roulette);

            for (int i = 0; i < 100; i++)
            {
                roulette.Spin();
            }

            Console.ReadKey();
        }
    }
}