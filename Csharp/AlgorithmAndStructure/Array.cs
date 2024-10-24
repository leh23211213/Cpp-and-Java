using System.Globalization;

namespace AlgorithmAndStructure
{
    public class Array
    {
        public static void Months()
        {
            Console.Title = "basic array";
            string[] months = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;
            }
            foreach (var element in months)
            {
                System.Console.WriteLine($"{element}");
            }
        }
        /// <summary>
        /// 0,4 dùng để tạo khoảng cách
        /// </summary>
        public static void _2dArray()
        {

            Console.Title = "Multiplication table";
            // khai báo và khởi tạo mảng hai chiều chứa bảng cửu chương
            var multiplications = new int[10, 10];
            // gán giá trị cho các phần tử của bảng cửu chương
            for (int r = 0; r < multiplications.GetLength(0); r++)
            {
                for (int c = 0; c < multiplications.GetLength(1); c++)
                {
                    multiplications[r, c] = (r + 1) * (c + 1);
                }
            }
            // in ra màn hình
            for (int c = 0; c <= multiplications.GetLength(1); c++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (c == 0) Console.Write("{0, 4}", "");
                else
                    Console.Write("{0, 4}", c);
            }
            Console.WriteLine();
            for (int r = 0; r < multiplications.GetLength(0); r++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0, 4}", r + 1);
                Console.ResetColor();
                for (int c = 0; c < multiplications.GetLength(1); c++)
                {
                    Console.Write("{0, 4}", multiplications[r, c]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// jagged array
        /// </summary>
        /// 
        public static void jaggedArray()
        {
            {
                int[][] numbers = new int[5][];
                numbers[0] = new int[] { 1, 2, 3 };
                numbers[2] = new int[] { 1, 2, 3, 4, 5 };
                numbers[4] = new int[] { 1, 2 };

                // Xuất mảng răng cưa ra màn hình
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != null)
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            Console.Write(numbers[i][j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}