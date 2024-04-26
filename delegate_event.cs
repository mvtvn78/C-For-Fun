//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
//    delegate int PhepToan(int _a, int _b);

//    class delegate_event
//    {
//        public static int kq = 0;
//        // delegate : con trỏ hàm trỏ đến tham chiếu
//        // syntax khai báo : <quyền truy cập > delegate <type> name_delegate (<danh sách tham số > );
//        public delegate void EventHandler(object sender=null);
//        // intial function
//        public static void Thong_bao(object sender=null)
//        {
//            Console.WriteLine("Hello world");
//        }
//        public static void Hello(object sender = null)
//        {
//            Console.WriteLine("Hello 123");
//        }
//        //delegate
//        public  int Cong(int _a ,int _b)
//        {
//            kq = _a + _b;
//            return kq;
//        }
//        public  int Tru(int _a, int _b)
//        {
//            kq = _a - _b;
//            return kq;
//        }
//        public static void Main()
//        {
//            // Singlecast
//            //EventHandler Tbs = new EventHandler(Thong_bao);
//            //Tbs();

//            //Multicast
//            //EventHandler tbs;
//            //tbs = new EventHandler(Thong_bao);
//            //tbs += new EventHandler(Hello);
//            //tbs();
//            // thong_bao ---> Hello
//            PhepToan a;
//            a = new PhepToan(delegate_event.Cong);
//            a += new PhepToan(delegate_event.Tru);
//            a(2, 3);
//            Console.WriteLine(kq);
//            Console.ReadKey(false); 
//        }
//    }
//}
