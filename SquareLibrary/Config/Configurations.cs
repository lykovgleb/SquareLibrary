namespace SquareLibrary.Config
{
    public abstract class Configurations
    {
        public Types Type { get; set; }
        public List<double> Values { get; set; }
         
        internal Configurations(Types type)
        {
            this.Type = type;
            Values = new List<double>();
        }
    }
}
