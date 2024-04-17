//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Mvt
//{
//    //abstract class Person
//    //{
//    //    protected string name;
//    //    protected int age;

//    //    public Person(string name, int age)
//    //    {
//    //        this.name = name;
//    //        this.age = age;
//    //    }
//    //    public abstract void show();
//    //}
//    //class Present : Person
//    //{
//    //    public Present(string name, int age) : base(name, age)
//    //    {

//    //    }

//    //    public override void show()
//    //    {
//    //        Console.WriteLine($"TONG THONG : {name} {age}");
//    //    }
//    //}
//    //class Author : Person
//    //{
//    //    public Author(string name,int age) : base(name, age) { }
//    //    public override void show()
//    //    {
//    //        Console.WriteLine($"TAC GIA : {name} {age}");
//    //    }
//    //}
//    interface IShow
//    {
//        void show();
//    }
//    class Person : IShow
//    {
//        public void show() {

//            Console.WriteLine($"CON NGUOI ");
//        }
//    }
//    class Author : IShow
//    {
//        public void show() { Console.WriteLine($"TAC GIA "); }
//    }
//}
