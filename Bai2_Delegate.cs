//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
    
//    delegate void ThongBao();
//    class Students
//    {
//        public event ThongBao OnchangeID;
//        private int _id;
//        public int Id { get => _id;
//            set
//            {
//                _id = value;
//                if(OnchangeID != null)
//                {
//                    OnchangeID();
//                }
//            }
//        }
//    }
//    internal class Bai2_Delegate
//    {
//        void Hello()
//        {
//            Console.WriteLine("Hello World");
//        }
//        static void Main() {

//            Students students = new Students();
//            students.OnchangeID += new Bai2_Delegate().Hello;
//            students.Id = 3;
//            students.Id = 3;
//        }
//    }
//}
