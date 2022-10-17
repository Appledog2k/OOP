namespace TestCV2
{
    public class Circle
    {
        double radius;
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
        public double tinhDienTich()
        {
            return radius * radius * Math.PI;
        }
    }
}