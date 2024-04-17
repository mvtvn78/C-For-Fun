//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mvt
//{
//    class Student
//    {
//        private int id;
//        private string name;
//        private int age;
//        public Student(int _id, string _name, int _age)
//        {
//            this.id = _id;
//            this.Name = _name;
//            this.age = _age;
//        }
//        //Automatic Properties
//        public int getId { get; set; }
//        public string Name { get => name; set => name = value; }
//        public int Age { get => age; set => age = value; }
//    }
//    class Author
//    {
//        private readonly string name;
//        private  int age;
//        public Author(string _name, int _age)
//        {
//            this.name = _name;
//            this.age = _age;
//        }
//        //Lambda
//        public Func<int, int, bool> testForEquality = (x, y) => x == y;
//        public string Name { get => name;}
//        public int Age { set => age = value; }
//        public void Show()
//        {
//            Console.WriteLine($"Your name is {name} and {age} years old");
//        }
//    }
//}
