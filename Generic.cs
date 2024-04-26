//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace BasicCSharp
//{
//    public class Generic<T>
//    {
//        public void add(T input)
//        {
//            Console.WriteLine(input.GetType().ToString());
//        }
//    }
//    class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public Student() { Id = 0; Name = string.Empty; }
//    }
//    class Method
//    {
//        Method() { }
//        //Generic Method
//        static void Add<T> (T t1, T t2)
//        {
//        }
//    }
//    // Interface Generic
//    interface IClass<T> { 
    
//        T add ();
//        T move();
    
//    }
//     class A
//    {
//        static void Main()
//        {
//            //// Object play role generic data
//            //int[] arr = { 1, 2, 3, 4, 5, 6, };
//            //Object obj1 = arr;

//            //foreach (int i in (Array) obj1)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //Template 
//            //int
//            Generic<int> a = new Generic<int>();
//            a.add(2);
//            // float
//            Generic<float> b = new Generic<float>();
//            b.add((float)3.2);
//            // String
//            Generic<string> c = new Generic<string>();
//            c.add("Author : mvtvn78");
//            //Array
//            Generic<Array> d = new Generic<Array>();
//            d.add(new Array[2]);
//            // object
//            Generic<Student> e = new Generic<Student>();
//            e.add(new Student());
//        }
//    }
//}
