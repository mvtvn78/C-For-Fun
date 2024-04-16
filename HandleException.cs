using System;
using System.Text;
using HandleException;
class Mvt
{
    static void Main(string[] args)
    {
        //// In case. If you try to divide number for 0.Error will be throw and catch clause will catch and log error message

        Console.OutputEncoding = Encoding.UTF8;
        //try {
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine(a/b);
        //} 
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Lỗi {ex.Message}" );
        //}
        // You can catch many error

        //try {
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine(a/b);
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //Custome TryCatch
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(b==0)
            {
                throw new MvtException("Á À Bắt được con chó này bugs");
            }   
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}