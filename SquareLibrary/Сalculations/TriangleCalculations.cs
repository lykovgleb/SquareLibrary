using SquareLibrary.Config;

namespace SquareLibrary.Сalculations
{
    internal static class TriangleCalculations
    {
        internal static double Count(Configurations config)
        {
            config.Values.Sort();
            var a = config.Values[0];
            var b = config.Values[1];
            var c = config.Values[2];
            // Определение прямоугольного треугольника
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
                // Половина произведения катетов
                return a * b / 2d;
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
                //Подсчет по формуле Герона
                var p = (a + b + c) / 2d;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

    }

}
