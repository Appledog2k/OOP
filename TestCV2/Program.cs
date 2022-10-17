internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //! TÍNH DIỆN TÍCH HÌNH CHỮ NHẬT
        TestCV2.Rectangle rect = new TestCV2.Rectangle();
        // Yêu cầu người dùng nhập chiều dài và chiều rộng
        Console.WriteLine("Nhập vào chiều dài: ");
        rect.setLength(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Nhập vào chiều rộng: ");
        rect.setWidth(Convert.ToDouble(Console.ReadLine()));
        // Tính diện tích
        Console.WriteLine("Diện tích hình chữ nhật: " + rect.tinhDienTich());

        //! TÍNH DIỆN TÍCH HÌNH TRÒN
        TestCV2.Circle circle = new TestCV2.Circle();
        // Yêu cầu người dùng nhập bán kính
        Console.WriteLine("Nhập vào bán kính: ");
        circle.setRadius(Convert.ToDouble(Console.ReadLine()));
        // Tính diện tích
        Console.WriteLine("Diện tích hình tròn: " + circle.tinhDienTich());

        //! TÍNH DIỆN TÍCH HÌNH VUÔNG
        TestCV2.Square square = new TestCV2.Square();
        // Yêu cầu người dùng nhập bán kính
        Console.WriteLine("Nhập vào chiều dài cạnh hình vuông: ");
        square.setLength(Convert.ToDouble(Console.ReadLine()));
        // Tính diện tích
        Console.WriteLine("Diện tích hình tròn: " + square.tinhDienTich());
    }
}