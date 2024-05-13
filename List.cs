//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
//    internal class List
//    {
//        public   static void Duyet ( List<string> list) 
//        {
//            Console.WriteLine("Duyệt ");
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        public static void Main()
//        {
//            List<string> list = new List<string>() { "Mvt","Kaioken"};
//            Duyet(list);
//            list.Clear();
//            Duyet(list);
//            list.Add("Hello");
//            list.Add("Kaioken");
//            Duyet (list);
//            list.Remove("Hel");
//            list.RemoveAt(0);
//            Duyet(list);
//            Console.WriteLine(list.All(x => x.Contains("k")));
//        }
//    }
//}
