using System;
using System.Linq;

namespace RouletteTask
{
    public class RouletteEventArgs : EventArgs
    {
        private static readonly int[] RedNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        /// <summary>
        /// Initializes a new instance of the <see cref="RouletteEventArgs"/> class.
        /// </summary>
        /// <param name="number">The number which wins.</param>
        public RouletteEventArgs(int number)
        {
            this.Number = number;
        }

        /// <summary>
        /// Gets the number.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Gets the color.
        /// </summary>
        public Color Color
        {
            get
            {
                if (this.Number == 0)
                {
                    return Color.Green;
                }

                return RedNumbers.Contains(this.Number) ? Color.Red : Color.Black;
            }
        }
    }
}
