using System.Text;

namespace Phan2_KieuDuLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String
            string s2 = @"Hello, World! \n\t\r";
            string s1 = $"Hello, World! \n\t\r {DateTime.Now}";


            // StringBuilder: Dùng khi thao tác nhiều chuỗi
            StringBuilder sb = new StringBuilder();
            sb.Append(s2);
            sb.Append(s1);
            string s = sb.ToString();
            Console.WriteLine(s);

            // Dynamic: Dùng khi không biết kiểu dữ liệu tại thời điểm biên dịch code (Chưa chạy)
            //          Dùng khi làm việc với COM, Reflection, hoặc khi cần linh hoạt về kiểu dữ liệu
            dynamic d = 10; // d là int
            Console.WriteLine(d);

            // Var: Dùng khi trình biên dịch có thể suy luận được kiểu dữ liệu từ giá trị khởi tạo
            var v = 10; // v là int
            Console.WriteLine(v);

            // Nullable
            int? a = null;

            // 
            Console.WriteLine("abc".ToUpper());



        }
    }
}
