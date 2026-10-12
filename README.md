# THÔNG TIN SINH VIÊN
- **Họ và tên:** Nguyễn Gia Bảo Tường
- **Mã số sinh viên:** 31251020414
- **Lớp học phần:** DS0001

---

# HƯỚNG DẪN BIÊN DỊCH VÀ CHẠY CHƯƠNG TRÌNH
1. Mở thư mục bài tập (Bai1, Bai2 hoặc Bai3) bằng Visual Studio hoặc Visual Studio Code.
2. Đảm bảo máy tính đã cài đặt .NET SDK.
3. Nhấn nút **Start (F5)** trong Visual Studio hoặc mở Terminal gõ lệnh `dotnet run` để chạy chương trình.
4. Nhập dữ liệu theo các dòng thông báo trên màn hình (Console).

---

# MÔ TẢ GIẢI PHÁP & ĐỘ PHỨC TẠP
## Bài 1: Thao tác mảng 1 chiều, chuỗi và ma trận
- **Giải pháp:** Sử dụng các vòng lặp `for` cơ bản để duyệt qua các phần tử của mảng/chuỗi. Không sử dụng các hàm thư viện có sẵn (như `.Length`, `.Sort()`) để rèn luyện tư duy thuật toán gốc.
- **Độ phức tạp:** Thời gian O(n) cho các thao tác duyệt 1 vòng lặp (như tìm max/min, tính tổng). Bộ nhớ O(n) khi tạo mảng mới hoặc $\Theta(1)$ khi thao tác trực tiếp.

## Bài 2: Tìm hai giá trị lớn nhất phân biệt
- **Giải pháp:** Khởi tạo 2 biến `max1` và `max2`. Chỉ dùng 1 vòng lặp duy nhất để duyệt mảng. So sánh từng phần tử để cập nhật `max1` và đẩy giá trị cũ xuống `max2`.
- **Độ phức tạp:** Thời gian O(n) (chỉ duyệt mảng 1 lần). Bộ nhớ $\Theta(1)$ (chỉ dùng 2 biến int?, không tạo thêm mảng phụ).

## Bài 3: Đoạn con liên tiếp có tổng lớn nhất
- **Giải pháp:** 
  - *Phiên bản A:* Dùng 2 vòng lặp lồng nhau để thử mọi trường hợp bắt đầu và kết thúc của đoạn con.
  - *Phiên bản B:* Dùng thuật toán Kadane, duyệt mảng 1 lần, vứt bỏ các đoạn con có tổng âm và liên tục cập nhật kỷ lục.
- **Độ phức tạp:** 
  - Phiên bản A: Thời gian O(n^2), Bộ nhớ O(1).
  - Phiên bản B: Thời gian O(n), Bộ nhớ O(1).

---

# CÁC TEST CASE ĐÃ SỬ DỤNG
- **Bài 2:** Mảng thông thường `3 7 2 9 5`, Mảng có phần tử trùng `8 8 8 3`, Mảng toàn số âm `-9 -2 -5`, Mảng không có số thứ hai `4 4 4 4`.
- **Bài 3:** Mảng hỗn hợp `-2 1 -3 4 -1 2 1 -5 4`, Mảng toàn số dương `1 2 3`, Mảng toàn số âm `-8 -3 -6 -2 -5 -4`.

---

# CÔNG CỤ AI ĐÃ SỬ DỤNG
- **Tên công cụ:** Gemini
- **Mục đích:** Hỗ trợ giải quyết các lỗi , gợi ý và hỗ trợ làm bài 3 cấu trúc thuật toán Kadane và hỗ trợ viết readme.
