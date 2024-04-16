//using System;
//using System.Text;
//class IO
//{
//    static void Main()
//    {
//        //Syntax : $" {variables} " : to format variables
//        //Syntax : Console.WriteLine(" {0}",12) => using argument to pass first element begin with 0 index.
//        Console.OutputEncoding = Encoding.UTF8; // using encoding UTF8 for OutPut;
//        Console.InputEncoding = Encoding.UTF8; // using encoding UTF8 for InPut (But Vietnamese Error);
//        string name;
//        Console.WriteLine("Xin chào bạn tên là gì ");
//        name = Console.ReadLine();
//        int age;
//        Console.WriteLine("Hãy cho tôi biết năm sinh của bạn");
//        age = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Tên của bạn là {name}");
//        Console.WriteLine("Tuổi bạn đang là {0}", 2024 - age);
//    }
//}