namespace TestCV2
{
    public class Square : Shape
    {
        private double length;
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
        public override double tinhDienTich()
        {
            return length * length;
        }
    }
}