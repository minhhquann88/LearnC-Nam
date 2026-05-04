namespace Phan6_TryCatch
{
    internal class Program
    {
        // Lưu ý: Tránh lạm dụng try-catch, chỉ nên sử dụng khi thực sự cần thiết để xử lý lỗi có thể xảy ra trong quá trình thực thi chương trình.
        // Việc sử dụng quá nhiều try-catch có thể tốn tài nguyên, làm giảm hiệu suất của chương trình, và làm cho mã trở nên khó đọc và bảo trì.
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("Nhap mot so nguyen n = ");
                    int n = int.Parse(Console.ReadLine());
                    int x = 10 / n;
                    Console.WriteLine(x);

                    throw new Exception("Loi tu tao ra"); // Tạo một lỗi tùy ý để minh họa
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Loi dinh dang: ");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Loi chia cho 0: ");
                    throw new Exception("Loi tu tao ra"); // Tạo một lỗi tùy ý để minh họa
                    //throw; // Tiếp tục ném lỗi lên cấp trên mà không tạo lỗi mới

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi khac: ");
                }
                finally
                {
                    Console.WriteLine("Ket thuc chuong trinh");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
