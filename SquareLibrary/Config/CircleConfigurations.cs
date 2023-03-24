namespace SquareLibrary.Config
{
    public class CircleConfigurations : Configurations
    {
        public CircleConfigurations(double radius) : base(Types.Circle)
        {
            Values.Add(radius);
        }
    }
}
