//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
//    class MyError : ApplicationException
//    {
//        public MyError(string _s) : base(_s) { }
//    }
//    internal class bai3
//    {
//        static void Main()
//        {
//            try
//            {
//                Console.OutputEncoding = Encoding.UTF8;
//                Console.WriteLine("Nhập số chỉ số bạn muốn truy cập vào mảng");
//                int n = int.Parse(Console.ReadLine());
//                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//                Console.WriteLine("Giá trị tại chỉ số {0}", arr[n]);

//                Console.WriteLine("Nhập số tuổi tuyển dụng lao động");
//                n = int.Parse(Console.ReadLine());
//                if (n < 18)
//                {
//                    throw new MyError("Quá trẻ");
//                }
//                if (n > 40)
//                {
//                    throw new MyError("Quá già");
//                }
//                if (n >= 18 && n <= 40)
//                {
//                    throw new MyError("Đạt yêu cầu");
//                }
//            }
//            catch (FormatException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            catch (IndexOutOfRangeException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            catch (MyError e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            Console.ReadKey(false);
//        }
//    }
//}
