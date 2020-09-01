namespace Shapes
{
    public abstract class Shape
    {
        protected double Width;
        protected double Height;
        public abstract double CalculateSurface();
        protected Shape(double widh, double height)
        {
            this.Width = widh;
            this.Height = height;
        }
    }
}
