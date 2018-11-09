using NLog;

namespace RouletteTask
{
    public class NumberListner
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        private readonly int _number;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberListner"/> class.
        /// </summary>
        /// <param name="number">The number.</param>
        public NumberListner(int number)
        {
            _number = number;
        }

        /// <summary>
        /// Registers the specified roulette.
        /// </summary>
        /// <param name="roulette">The roulette.</param>
        public void Register(Roulette roulette)
        {
            roulette.SpinCompleted += RouletteOnSpinCompleted;
        }

        /// <summary>
        /// Unregisters the specified roulette.
        /// </summary>
        /// <param name="roulette">The roulette.</param>
        public void Unregister(Roulette roulette)
        {
            roulette.SpinCompleted -= RouletteOnSpinCompleted;
        }

        private void RouletteOnSpinCompleted(object sender, RouletteEventArgs rouletteEventArgs)
        {
            if (rouletteEventArgs.Number == _number)
            {
                Log.Info($"Number wins with number {rouletteEventArgs.Number} and color {rouletteEventArgs.Color}.");
            }
        }
    }
}
