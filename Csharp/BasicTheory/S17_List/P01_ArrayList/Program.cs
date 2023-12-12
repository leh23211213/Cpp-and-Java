using System;
using System.Collections;
using System.Collections.Generic;
namespace P01_ArrayList
{
    class Program
    {
        static void Print(ArrayList list, string label)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{label}: ");
            Console.ResetColor();
            
            if (list.Count == 0)
                Console.Write("EMPTY!");
            // duyệt danh sách và in các phần tử ra console
            foreach (object item in list)
            {
                Console.Write($"{item}\t");
            }
            // hoặc
            //for (var i = 0; i < list.Count; i++)
            //{
            //    Console.Write($"{list[i]}\t");
            //}
            Console.WriteLine();
        }
        static void CreateInitialize()
        {
            Console.WriteLine("#Khởi tạo ArrayList");
            // khởi tạo array list
            var list1 = new ArrayList();
            // khởi tạo array list và cung cấp sẵn dữ liệu ban đầu
            var list2 = new ArrayList(new object[] { "Allo", 1, 2, 3, true });
            // khởi tạo và cung cấp kích thước ban đầu (sau có thể thêm bớt thoải mái)
            var list3 = new ArrayList(5);
            Print(list1, "LIST 01");
            Print(list2, "LIST 02");
            Print(list3, "LIST 03");
            Console.WriteLine("#####");
        }
        static void Add()
        {
            Console.WriteLine("#Thêm phần tử");
            // khởi tạo array list
            var arrayList = new ArrayList();
            // thêm một số nguyên (vào cuối)
            arrayList.Add(100);
            // thêm tiếp một mảng số nguyên
            arrayList.AddRange(new[] { 1, 2 });
            // thêm một chuỗi
            arrayList.Add("Trump");
            // thêm một mảng string
            arrayList.AddRange(new[] { "Washington", "Moscow", "Beijing", "London", "Paris" });
            Print(arrayList, "");
            Console.WriteLine("#####");
        }
        static void Insert()
        {
            Console.WriteLine("#Chèn phần tử");
            var list = new ArrayList(5);
            list.Insert(0, 'A'); // lưu ý arrayList khởi tạo với 5 phần tử
            list.InsertRange(1, new[] {2, 3, 4 });
            // chèn 1 bool vào vị trí số 1
            list.Insert(1, true);
            Print(list, "");
            Console.WriteLine("#####");
        }
        static void Remove()
        {
            Console.WriteLine("#Xóa phần tử");
            var arrayList = new ArrayList(new object[] { "Allo", 1, 2, 3, true });
            // xóa phần tử có giá trị 1
            arrayList.Remove(1);
            Print(arrayList, "");
            // xóa phần tử ở vị trí số 1
            arrayList.RemoveAt(1);
            Print(arrayList, "");
            Console.WriteLine("#####");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            CreateInitialize(); Console.WriteLine();            
            Add(); Console.WriteLine();
            Insert(); Console.WriteLine();
            Remove(); Console.WriteLine();
        }
    }
}