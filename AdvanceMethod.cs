//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharp
//{
    
//    #region Mai
//    class Student
//    {
      
//        public int Id { get; set; }
//        public double Grade { get; set; }
//        public Student(int _i, double _g)
//        {
//            this.Id = _i;
//            this.Grade = _g;
//        }
        
//        public override string ToString()
//        {
//            return this.Id + this.Grade.ToString();
//        }
//    }
//    #endregion
//    class SortStudent : System.Collections.Generic.IComparer<Student>
//    {
       
//        public int Compare(Student x, Student y)
//        {
//            if (x == null || y == null) throw new InvalidCastException();
//            if (x.Id > y.Id) return 1;
//            else if (x.Id < y.Id) { return -1; }
//            else return 0;
//        }

//    }
//    internal class AdvanceMethod
//        {
//            static void Main() 
//            { 
               
//               List<Student> students = new List<Student>();
//               students.Add(new Student(1, 3));
//               students.Add(new Student(-2, 3));
//               students.Add(new Student(-4, 3));
//               students.Add(new Student(-2, 3));
//                //Sort customer
//                students.Sort(new SortStudent());
//                students.Reverse();
//                foreach(Student student in students)
//                {
//                    Console.WriteLine(student);
//                }
//            // all
//            Console.WriteLine("{0} All Grade =3 ",students.All(x => x.Grade == 3));
//            Console.WriteLine("{0} All Grade >3 ", students.All(x => x.Grade > 3));
//            //Any
//            Console.WriteLine("{0} Any Id =1 ", students.Any(x => x.Id == 1));
//            Console.WriteLine("{0} Any Id =2 ", students.Any(x => x.Grade == 2));
//            //Select
//            var query = students.Select((fruit,id) => new { id,fruit});
//            foreach (var obj in query)
//            {
//                Console.WriteLine("{0}", obj);
//            }
//            //Fist and Last
//            Student svf = students.Find(x => x.Grade==3);
//            Student svl = students.FindLast(x => x.Grade==3);
//            Console.WriteLine("{0} Fist", svf);
//            Console.WriteLine("{0} Last", svl) ;
//        }
//    }
//}
