namespace SquareLibrary.Config
{
    public class TriangleConfigurations : Configurations
    {
        public TriangleConfigurations(double sideA, double sideB, double sideC) : base(Types.Triangle)
        {
            Values.Add(sideA);
            Values.Add(sideB);
            Values.Add(sideC);
        }
    }
}
