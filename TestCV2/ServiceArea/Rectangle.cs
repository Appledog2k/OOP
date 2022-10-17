namespace TestCV2
{
    public class Rectangle
    {
        double length, width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle()
        {

        }
        public double getWidth()
        {
            return width;
        }

        public double getLength()
        {
            return length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public void setLength(double length)
        {
            this.length = length;
        }
        public double tinhDienTich()
        {
            return width * length;
        }
    }
}