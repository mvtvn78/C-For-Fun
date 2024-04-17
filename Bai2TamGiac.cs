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
//    internal class TamGiac
//    {
//        private float edge_a;
//        private float edge_b;
//        private float edge_c;
//        public float EdgeA { get; set; }
//        public float EdgeB { get; set; }
//        public float EdgeC { get; set; }
//        public TamGiac()
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            this.EdgeA = 0;
//            this.EdgeB = 0;
//            this.EdgeC = 0;
//        }
//        public bool isValidEdge()
//        {
//            if (this.EdgeA < 0 || this.EdgeB < 0 || this.EdgeC < 0) { return false; }
//            return (this.EdgeA + this.EdgeB > this.EdgeC && this.EdgeA + this.EdgeC > this.EdgeB && this.EdgeB + this.EdgeC > this.EdgeA);
//        }
//        public void Input()
//        {
//            try
//            {
//                Console.WriteLine("Nhập cạnh a");
//                this.EdgeA = float.Parse(Console.ReadLine());
//                Console.WriteLine("Nhập cạnh b");
//                this.EdgeB = float.Parse(Console.ReadLine());
//                Console.WriteLine("Nhập cạnh c");
//                this.EdgeC = float.Parse(Console.ReadLine());
//                if (!isValidEdge())
//                {
//                    throw new MyError("Nhập dữ liệu cạnh không hợp lệ");
//                }
//                Console.WriteLine("Tam giác này được chấp nhận");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }

//        }
//        public float ChuVi()
//        {
//            return this.edge_a + this.edge_b + this.edge_c;
//        }
//        static void Main()
//        {
//            TamGiac[] tamGiacs = new TamGiac[3];

//            for (int i = 0; i < tamGiacs.Length; i++)
//            {
//                tamGiacs[i] = new TamGiac();
//                Console.WriteLine("Nhâp dữ liệu cho tam giác {0}", i + 1);
//                tamGiacs[i].Input();
//            }
//            Console.ReadKey(false);
//        }
//    }
//}
