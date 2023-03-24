using SquareLibrary.Config;
using SquareLibrary.Сalculations;

namespace SquareLibrary
{
    public static class Square
    {
        public static double Count(Configurations configurations)
        {
            switch (configurations.Type)
            {
                case Types.Circle: 
                    return CircleCalculations.Count(configurations);
                case Types.Triangle:
                    return TriangleCalculations.Count(configurations);
                default:
                    throw new Exception("Unknown Type");
            }
        }
    }
}