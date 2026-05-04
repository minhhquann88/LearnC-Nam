# LearnC-Nam

Repo học C# theo **một solution cha** (`LearnC-Nam.slnx`) và nhiều project con trong `src/`.

## Cách dùng

- Mở `LearnC-Nam.slnx` trong Visual Studio hoặc VS Code (C# Dev Kit).
- Chọn **startup project** là phần đang học (ví dụ `01-NenTang`), rồi F5 / `dotnet run`.
- Chạy một project cụ thể từ terminal:

```bash
dotnet run --project src/01-NenTang/01-NenTang.csproj
```

- Build cả solution:

```bash
dotnet build LearnC-Nam.slnx
```

## Cấu trúc

| Đường dẫn | Vai trò |
|-----------|---------|
| `LearnC-Nam.slnx` | Solution cha — chứa tất cả project học (folder `src/` trong Solution Explorer) |
| `src/<TênPhần>/` | Mỗi phần = một console app độc lập |
| `docs/LO_TRINH.md` | Gợi ý map thư mục ↔ nội dung |

Thêm phần mới: `dotnet new console -n 08-TenPhan -o src/08-TenPhan` rồi `dotnet sln LearnC-Nam.slnx add src/08-TenPhan/08-TenPhan.csproj` (hoặc thêm project trong IDE).
