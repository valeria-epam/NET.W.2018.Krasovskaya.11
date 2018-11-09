using System;
using System.Diagnostics.CodeAnalysis;

namespace RouletteTask
{
    public class Roulette
    {
        private readonly Random _random = new Random();

        /// <summary>
        /// Occurs when the roulette has spinned.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Spelling is correct.")]
        public event EventHandler<RouletteEventArgs> SpinCompleted;

        /// <summary>
        /// Spins the roulette.
        /// </summary>
        public void Spin()
        {
            int value = _random.Next(0, 37);
            OnSpinComleted(new RouletteEventArgs(value));
        }

        /// <summary>
        /// Raises the <see cref="E:SpinCompleted" /> event.
        /// </summary>
        /// <param name="e">The <see cref="RouletteEventArgs"/> instance containing the event data.</param>
        protected virtual void OnSpinComleted(RouletteEventArgs e) => SpinCompleted?.Invoke(this, e);
    }
}