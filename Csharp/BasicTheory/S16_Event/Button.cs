using System;
using System.Windows.Forms;
namespace ConsoleApp3 {
    internal class Program {
        [STAThread]
        private static void Main() {
            // tạo form mới
            var form = new Form();
            // tạo nút bấm
            var button = new Button {
                Text = "Press me!",
            };
            // đăng ký xử lý sự kiện click nút bấm
            button.Click += OnButtonOnClick;
            // chèn nút bấm vào form
            form.Controls.Add(button);
            Application.EnableVisualStyles();
            // chạy ứng dụng
            Application.Run(form);
        }
        // phương thức xử lý sự kiện bấm nút.
        private static void OnButtonOnClick(object sender, EventArgs args)
        {
            MessageBox.Show("Xin chào. Đây là thông báo từ phương thức xử lý sự kiện click của nút bấm!");
        }
    }
}