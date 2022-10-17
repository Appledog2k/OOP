using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Phần 1: Tính số ngày thứ 7 và chủ nhật từ SD đến ED
        // Start Date
        Console.WriteLine("Nhập ngày Start Date theo định dạnh dd/MM/yyyy");
        var startDate = Console.ReadLine();
        DateTime SD = DateTime.ParseExact(startDate, "dd/MM/yyyy", null);

        // End Date
        Console.WriteLine("Nhập ngày Start Date theo định dạnh dd/MM/yyyy");
        var endDate = Console.ReadLine();
        DateTime ED = DateTime.ParseExact(endDate, "dd/MM/yyyy", null);

        // SD => ED
        TimeSpan Time = ED - SD;
        int TongSoNgay = Time.Days;
        Console.WriteLine("Tổng số ngày từ SD => ED: " + TongSoNgay);

        // Phần nguyên
        int m = TongSoNgay / 7;
        // Phần dư
        int n = TongSoNgay % 7;
        var countSaturday = 0;
        var countSunday = 0;
        if (SD.DayOfWeek.ToString() == "Monday")
        {
            if (n == 0 || n == 1 || n == 2 || n == 3 || n == 4)
            {
                countSaturday = m;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 5)
            {
                countSaturday = m + 1;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }
        if (SD.DayOfWeek.ToString() == "Tuesday")
        {
            if (n == 0 || n == 1 || n == 2 || n == 3)
            {
                countSaturday = m;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 4)
            {
                countSaturday = m + 1;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 5 || n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }
        if (SD.DayOfWeek.ToString() == "Wednesday")
        {
            if (n == 0 || n == 1 || n == 2)
            {
                countSaturday = m;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 3)
            {
                countSaturday = m + 1;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 4 || n == 5 || n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }
        if (SD.DayOfWeek.ToString() == "Thursday")
        {
            if (n == 0 || n == 1)
            {
                countSaturday = m;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 2)
            {
                countSaturday = m + 1;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 3 || n == 4 || n == 5 || n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }
        if (SD.DayOfWeek.ToString() == "Friday")
        {
            if (n == 0)
            {
                countSaturday = m;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 1)
            {
                countSaturday = m + 1;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 2 || n == 3 || n == 4 || n == 5 || n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }
        if (SD.DayOfWeek.ToString() == "Saturday")
        {
            if (n == 0)
            {
                countSaturday = m + 1;
                countSunday = m;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }
        if (SD.DayOfWeek.ToString() == "Sunday")
        {
            if (n == 0)
            {
                countSaturday = m;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
            {
                countSaturday = m;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
            if (n == 6)
            {
                countSaturday = m + 1;
                countSunday = m + 1;
                Console.WriteLine($"Count Saturday: {countSaturday}");
                Console.WriteLine($"Count Sunday: {countSunday}");
            }
        }

        //Phần 2: Tính số ngày làm việc
        // Ngày nghỉ lễ, giả sử ta có 1 ngày nghỉ 05.09.2022 cần xác định xem có thuộc SD đến ED không!
        DateTime HD = DateTime.ParseExact("05/09/2022", "dd/MM/yyyy", null);
        DateTime TimeLine = DateTime.ParseExact("01/01/1970", "dd/MM/yyyy", null);


        // số ngày tính từ timeline tới HD
        TimeSpan HDTimeLine = HD - TimeLine;
        int countHDTimeLine = HDTimeLine.Days;

        // số ngày tính từ timeline tới SD
        TimeSpan SDTimeLine = SD - TimeLine;
        int countSDTimeLine = SDTimeLine.Days;

        // số ngày tính từ timeline tới ED
        TimeSpan EDTimeLine = ED - TimeLine;
        int countEDTimeLine = EDTimeLine.Days;

        // Số ngày nghỉ lễ
        int countDayOff = 0;
        if (countSDTimeLine <= countHDTimeLine && countEDTimeLine >= countHDTimeLine &&
        HD.DayOfWeek.ToString() != "Sunday" && HD.DayOfWeek.ToString() != "Saturday")
        {
            countDayOff++;
        }
        Console.WriteLine("Số ngày nghỉ lễ: " + countDayOff);
        int countWorkingDayTotal = TongSoNgay - countDayOff - countSaturday - countSunday;
        Console.WriteLine("Count Day Off: " + countWorkingDayTotal);
    }
}