using static System.Console;
namespace ConsoleApp1 {
    internal class Program {
        private static void Main(string[] args) {
            Title = "C# events - TuHocICT";
            var gasoline = new Gasoline();
            // đăng ký theo dõi sự kiện
            gasoline.PriceChanged += Stock_PriceChanged1;
            gasoline.PriceChanged += Stock_PriceChanged2;
            // tăng giá xăng
            gasoline.Price += 50;
            // lại tăng giá
            gasoline.Price += 20;
            // hủy đăng ký theo dõi sự kiện
            gasoline.PriceChanged -= Stock_PriceChanged1;
            // tăng giá tiếp
            gasoline.Price += 10;
            ReadKey();
        }
        // cách xử lý sự kiện 1
        private static void Stock_PriceChanged1(decimal oldPrice, decimal newPrice) {
            WriteLine($"Damn it! The price changed again to {newPrice}đ");
        }
        // cách xử lý sự kiện 2
        private static void Stock_PriceChanged2(decimal oldPrice, decimal newPrice) {
            WriteLine($"The price has been changed from ${oldPrice} to {newPrice}đ");
        }
    }
    // delegate đứng sau event
    internal delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    internal class Gasoline {
        private decimal _price = 11000; // giá gốc là 11.000đ
        // khai báo event dựa trên delegate
        public event PriceChangedHandler PriceChanged;
        public decimal Price {
            get => _price;
            set {
                if (_price == value) return;
                var oldPrice = _price;
                _price = value;
                // chạy sự kiện
                PriceChanged?.Invoke(oldPrice, _price);
            }
        }
    }
}