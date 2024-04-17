//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
//    //class MyError : ApplicationException
//    //{
//    //    public MyError(string s): base(s) { }
//    //}
//    //class Bt1
//    //{
//    //    static void Main()
//    //    {
//    //       try 
//    //        {

//    //            int[] arr = new int[3];
//    //            for (int i = 0; i < arr.Length; i++)
//    //            {
//    //                arr[i] = int.Parse(Console.ReadLine());
//    //            }
//    //            Array.Sort(arr);
//    //            foreach (int i in arr)
//    //            {
//    //                Console.WriteLine(i);
//    //            }
//    //        } catch (Exception e) {
//    //            Console.WriteLine(e.Message);
//    //        }
//    //    }
        
//    //}
//    //class Bt2
//    //{
//    //    // ax^2 + bx +c =0
//    //    public static void Main()
//    //    {
//    //        try
//    //        {
//    //            float a = float.Parse(Console.ReadLine());
//    //            float b = float.Parse(Console.ReadLine());
//    //            float c = float.Parse(Console.ReadLine());
//    //            if(a != 0 )
//    //            {
//    //                float delta = b*b - 4 * a * c;
//    //                if(delta < 0)
//    //                {
//    //                    throw new MyError("PT VN");
//    //                }    
//    //                else if (delta == 0)
//    //                {
//    //                   Console.WriteLine("Phương trình có nghiệm kép {0}",-b/a);
//    //                }
//    //                else
//    //                {
//    //                    Console.WriteLine("Phương trình có nghiệm x1 {0}", (-b+Math.Sqrt(delta)) / 2*a) ;
//    //                    Console.WriteLine("Phương trình có nghiệm x2 {0}", (-b - Math.Sqrt(delta)) / 2 * a);
//    //                }
//    //            }
//    //            else
//    //            {
//    //                if(c == 0 && b==0) { throw new MyError("PT Vo So Nghiem"); }
//    //                if(b == 0 && c != 0) { throw new MyError("PT VN"); }
//    //                Console.WriteLine($"Phương trình có nghiệm {-c / b}");
//    //            }    
//    //        }
//    //        catch (Exception e)
//    //        {
//    //            Console.WriteLine (e.Message);
//    //        }
//    //    }
//    //}

//    //class BT3
//    //{
//    //    static void Main()
//    //    {
//    //        float point;
//    //        string name;
//    //        do
//    //        {
//    //             name = Console.ReadLine();
//    //             point = float.Parse(Console.ReadLine());
//    //        } while (point>10 || point <0 );
//    //        if(point >=8)
//    //        {
//    //            Console.WriteLine($"Giỏi");
//    //        }
//    //        else if(point>=6.5 && point <8)
//    //        {
//    //            Console.WriteLine("Khá");
//    //        }
//    //        else if ( point >=5 && point < 6.5)
//    //        {
//    //            Console.WriteLine("Trung bình");
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Yếu");
//    //        }

//    //    }
//    //}

//    //class BT4
//    //{
       
//    //    static void Main(string[] args)
//    //    {
//    //        int n = -1;
//    //        do 
//    //        {
//    //            Console.WriteLine("Nhap n");
//    //            n = int.Parse(Console.ReadLine());
//    //        } while (n < 0);
//    //        float sum = 0;
//    //        for(int i = 1; i <= n; i++)
//    //        {
//    //            sum += i;
//    //        }
//    //        Console.WriteLine("1+2+3+4+ ... +n = {0}", sum);
//    //        sum = 0;
//    //        for (int i = 1;i <= n; i++)
//    //        {
//    //            sum += 1  / float.Parse(i.ToString()); 
//    //        }
//    //        Console.WriteLine("1+1/2+1/3+1/4+ ... +1/n = {0}", sum);
//    //    }
//    //}
//}
