namespace Phan5_PhuongThuc
{
    // Nạp chồng: cùng tên phương thức nhưng dsach tham số khác nhau(số lượng, kiểu dữ liệu, thứ tự)
    // Viết theo cú pháp rút gọn, Sử dụng toán tử =>

    // Truyền tham số : Truyền tham số theo giá trị (mặc định)
    //                  Truyền tham số theo tham chiếu (sử dụng từ khóa ref)
    //                  Truyền tham số ra ngoài (sử dụng từ khóa out)

    // out: int.TryParse("123", out int result) => Nó vừa trả về true/false (xem có ép kiểu thành công không), vừa đẩy giá trị số thực sự ra biến result

    // params: Cho phép truyền một số lượng tham số không xác định vào một phương thức, sử dụng từ khóa params.
    //          Tham số này phải là mảng và phải là tham số cuối cùng trong danh sách tham số của phương thức.
    //          Ví dụ: public void PrintNumbers(params int[] numbers) { ... }

    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int ChiaLayThuongVaDu(int a, int b, out int soDu)
        {
            soDu = a % b;      // Bắt buộc phải gán giá trị cho soDu
            return a / b;      // Trả về thương số
        }
        public static int TinhTong(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

            int thuongSo = ChiaLayThuongVaDu(a, b, out int du);
            Console.WriteLine($"10 chia 3 được {thuongSo}, dư {du}");
            int tong2 = TinhTong(5, 10, 15, 20, 1, 2, 4, 67, 87, 34, 34);
            Console.WriteLine(tong2);
        }

    }
}
