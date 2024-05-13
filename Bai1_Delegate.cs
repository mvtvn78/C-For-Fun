//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace BasicCSharp
//{
//    class Bai1_Delegate
//    {
//        delegate int PhepToan(int _a, int _b);
//        delegate void ThongBao();
//        public int Cong(int _a, int _b)
//        {
//            return _a + _b;
//        }
//        public int Tru(int _a, int _b)
//        {
//            return _a - _b;
//        }
//        public int Chia(int _a, int _b)
//        {
//            return _a / _b;
//        }
//        public int Nhan(int _a, int _b)
//        {
//            return _a * _b;
//        }
//        static void Kaioken1 ()
//        {
//            Console.WriteLine("Kaioken1");
//        }
//        static void Kaioken2()
//        {
//            Console.WriteLine("Kaioken2");
//        }
//        public static void Main()
//        {
//            ThongBao tb = new ThongBao(Kaioken1);
//            tb = new ThongBao(Kaioken2);
//            tb();
//            int lc = 0;
//            Bai1_Delegate bai1_Delegate = new Bai1_Delegate();
//            PhepToan s = new PhepToan(bai1_Delegate.Cong);
//            lc = s(3, 3);
//            Console.WriteLine(lc);
//            //Tru 
//            s = new PhepToan(bai1_Delegate.Tru);
//            lc = s(3, 3);
//            Console.WriteLine(lc);
//            //Nhan
//            s = new PhepToan(bai1_Delegate.Nhan);
//            lc = s(3, 3);
//            Console.WriteLine(lc);
//            //CHia
//            s = new PhepToan(bai1_Delegate.Chia);
//            lc = s(3, 3);
//            Console.WriteLine(lc);
//            Console.ReadKey(false);
//        }
//    }
//}
