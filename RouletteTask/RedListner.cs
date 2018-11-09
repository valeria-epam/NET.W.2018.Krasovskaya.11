using NLog;

namespace RouletteTask
{
    public class RedListner
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
            if (rouletteEventArgs.Color == Color.Red)
            {
                Log.Info($"Red wins with number {rouletteEventArgs.Number}.");
            }
        }
    }
}
