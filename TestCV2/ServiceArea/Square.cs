namespace TestCV2
{
    public class Square
    {
        double length;
        public Square(double length)
        {
            this.length = length;
        }
        public Square()
        {

        }

        public double getLength()
        {
            return length;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double tinhDienTich()
        {
            return length * length;
        }
    }
}