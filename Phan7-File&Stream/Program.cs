//namespace Phan7_File_Stream
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //var path = "C:\\";
//            //var dir = new DirectoryInfo(path);
//            //var dicrectories = dir.GetDirectories();

//            //foreach (var item in dicrectories)
//            //{
//            //    Console.WriteLine($"{item.LastWriteTime.ToString("MM/dd/yyyy")} {item.LastWriteTime.ToString("HH:mm")} <DIR> {item.Name}");
//            //}

//            //Console.WriteLine();
//            //var files = dir.GetFiles();
//            //foreach (var item in files)
//            //{
//            //    Console.WriteLine($"{item.LastWriteTime.ToString("MM/dd/yyyy")} {item.LastWriteTime.ToString("HH:mm")} <DIR> {item.Name}");

//            //}

//            //var source = @"C:\test\testfile.cs";
//            //var dest = @"C:\test\testfile-copy.cs";

//            //var buffer = new byte[1024];

//            //// File.OpenRead() để mở file ở chế độ chỉ đọc, File.OpenWrite() để mở file ở chế độ ghi (nếu file đã tồn tại sẽ bị ghi đè)
//            //// dùng using để tự động đóng stream sau khi sử dụng xong, tránh rò rỉ tài nguyên
//            //using var instream = File.OpenRead(source);
//            //using var outstream = File.OpenWrite(dest);
//            //int n = instream.Read(buffer, 0, buffer.Length);
//            //while (n > 0)
//            //{
//            //    Console.WriteLine(n.ToString());
//            //    outstream.Write(buffer, 0, n);
//            //    n = instream.Read(buffer, 0, buffer.Length);
//            //}
//            //}

//            //Drive


//            // Path
//            // 1. Nối đường dẫn an toàn 
//            string fullPath = Path.Combine("Data", "Images", "avatar.png");

//            // 2. Lấy tên file có cả đuôi (VD: "avatar.png")
//            string fileName = Path.GetFileName(fullPath);

//            // 3. Lấy đuôi file (VD: ".png") - Rất hay dùng để validate file upload
//            string extension = Path.GetExtension(fullPath);

//            // 4. Lấy tên file không có đuôi (VD: "avatar")
//            string nameOnly = Path.GetFileNameWithoutExtension(fullPath);

//            // 5. Lấy đường dẫn thư mục chứa file (VD: "Data/Images")
//            string directoryPath = Path.GetDirectoryName(fullPath);


//            //Directory
//            // 1. Kiểm tra thư mục có tồn tại không
//            bool isExists = Directory.Exists("C:\\MyFolder");

//            // 2. Tạo thư mục mới (Tạo luôn cả các thư mục cha nếu chưa có)
//            Directory.CreateDirectory("C:\\MyFolder\\SubFolder\\Logs");

//            // 3. Lấy danh sách đường dẫn các file trong thư mục
//            // Dùng SearchOption.AllDirectories nếu muốn quét cả các thư mục con bên trong
//            string[] files = Directory.GetFiles("C:\\MyFolder", "*.txt", SearchOption.TopDirectoryOnly);

//            // 4. Xóa thư mục (Tham số true để xóa ép buộc mọi thứ bên trong)
//            Directory.Delete("C:\\MyFolder", true);

//            //File

//        }
//    }

