namespace TestCV2
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle()
        {

        }

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double tinhDienTich()
        {
            return radius * radius * Math.PI;
        }
    }
}