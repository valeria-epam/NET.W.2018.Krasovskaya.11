using NLog;

namespace RouletteTask
{
    public class OddListner
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

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
            if (rouletteEventArgs.Number % 2 != 0 && rouletteEventArgs.Number != 0)
            {
                Log.Info($"Odd wins with number {rouletteEventArgs.Number} and color {rouletteEventArgs.Color}.");
            }
        }
    }
}
