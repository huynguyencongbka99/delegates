// Đây là cách khá thú vị để có thể sử dụng một function chạy background thread
// Chúng ta sẽ dùng nó để có thể update và trả về kết quả ngay lập tức trên Main(UI) thread mà không cần khai báo trước function
// Hàm phía dưới có thể lấy ngay một biến đầu vào là x = 10, thực thi câu lệnh và trả về kết quả ngay trong một function nào đó.
int mm = 42;
int result = (int)this.Invoke(new Func<int, int>((x) =>
{
    x += mm; // Add `mm` to `x`
    return x; // Return the processed value
}), 10); // Passing `10` as the argument for `x`

MessageBox.Show($"Result: {result}");
