namespace HomeWork_11
{
    public class Figure
    {
        public string Name;
        public int Side;
        public double Area;
        public virtual double CalculateArea()
        {
            return Area;
        }
    }
}
