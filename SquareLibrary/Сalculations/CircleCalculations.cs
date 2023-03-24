using SquareLibrary.Config;

namespace SquareLibrary.Сalculations
{
    internal static class CircleCalculations
    {
        internal static double Count(Configurations config)
        {
            var radius = config.Values[0];

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
