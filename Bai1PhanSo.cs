//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
//    class Phanso
//    {
//        private int tuso;
//        private int mauso;
//        public Phanso(Phanso s)
//        {
//            this.tuso = s.Tuso;
//            this.mauso = s.Mauso;
//        }
//        public Phanso(int _t, int _m)
//        {
//            this.tuso = _t;
//            this.mauso = _m;
//            Console.OutputEncoding = Encoding.UTF8;
//        }
//        public int Tuso { get => tuso; set => tuso = value; }
//        public int Mauso { get => mauso; set => mauso = value; }
//        public void display()
//        {
//            Console.WriteLine("PHÂN SỐ {0}/{1}", tuso, mauso);
//        }
//        public int UCLN(int a, int b)
//        {
//            a = Math.Abs(a);
//            b = Math.Abs(b);
//            if (a == 0 || b == 0)
//            {
//                return a + b;
//            }
//            while (a != b)
//            {
//                if (a > b)
//                {
//                    a -= b; // a = a - b
//                }
//                else
//                {
//                    b -= a;
//                }
//            }
//            return a;
//        }
//        public void rutGonPs(int _a, int _b)
//        {
//            this.tuso = this.tuso / UCLN(_a, _b);
//            this.mauso = this.mauso / UCLN(_a, _b);
//        }
//        public void Input()
//        {
//            Console.WriteLine("Nhập tử số ");
//            this.tuso = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhập mẫu số ");
//            this.mauso = int.Parse(Console.ReadLine());
//        }
//        public static Phanso operator +(Phanso a, Phanso b)
//        {
//            Phanso rs = new Phanso(0, 0);
//            rs.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
//            rs.mauso = a.mauso * b.mauso;
//            rs.rutGonPs(rs.tuso, rs.mauso);
//            return rs;
//        }
//        public static Phanso operator -(Phanso a, Phanso b)
//        {
//            Phanso rs = new Phanso(0, 0);
//            rs.tuso = a.tuso * b.mauso - b.tuso * a.mauso;
//            rs.mauso = a.mauso * b.mauso;
//            rs.rutGonPs(rs.tuso, rs.mauso);
//            return rs;
//        }
//        public static Phanso operator *(Phanso a, Phanso b)
//        {
//            Phanso rs = new Phanso(0, 0);
//            rs.tuso = a.tuso * b.tuso;
//            rs.mauso = a.mauso * b.mauso;
//            rs.rutGonPs(rs.tuso, rs.mauso);
//            return rs;
//        }
//        public static Phanso operator /(Phanso a, Phanso b)
//        {
//            Phanso rs = new Phanso(0, 0);
//            rs.tuso = a.tuso * b.mauso;
//            rs.mauso = a.mauso * b.tuso;
//            rs.rutGonPs(rs.tuso, rs.mauso);
//            return rs;
//        }
//        static void Main()
//        {
//            Phanso ps1 = new Phanso(0, 0);
//            Phanso ps2 = new Phanso(0, 0);
//            Console.WriteLine("Nhập phân số 1");
//            ps1.Input();
//            Console.WriteLine("Nhập phân số 2");
//            ps2.Input();
//            Console.WriteLine("phân số 1");
//            ps1.display();
//            Console.WriteLine("phân số 2");
//            ps2.display();
//            Phanso ps3 = (ps1 + ps2);
//            Console.WriteLine("phân số 3 Tổng của ps1 và ps2");
//            ps3.display();
//            ps3 = (ps1 - ps2);
//            Console.WriteLine("phân số 3 Hiệu của ps1 và ps2");
//            ps3.display();
//            ps3 = (ps1 * ps2);
//            Console.WriteLine("phân số 3 Tích của ps1 và ps2");
//            ps3.display();
//            ps3 = (ps1 / ps2);
//            Console.WriteLine("phân số 3 Thương của ps1 và ps2");
//            ps3.display();
//            Console.ReadKey(false);
//        }
//    }
//}
