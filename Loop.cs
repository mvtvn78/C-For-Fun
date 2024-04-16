//using System;
//using System.Text;
//class Mvt
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        // For loop
//        for (int i = 1;i<=3000;i++)
//        {
//            Console.WriteLine($"Anh yêu em {i} lần");
//        }
//        // While
//        int j = 1;
//        while(j<=3000)
//        {
//            Console.WriteLine($"Nhớ em {j} lần");
//            j += 1;
//        }
//        // Do - While
//        do
//        {
//           Console.WriteLine($"Anh sẽ block em {j}");
//            j -= 1;
//        }
//        while (j >= 0);
//        //Foreach use for iterable
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
//        foreach(int item in arr)
//        {
//            Console.WriteLine($"Phần tử : {item}");
//        }
//        Console.ReadKey(false);
//    }
//}