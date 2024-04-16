using Mvt;
using System;
namespace BasicCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP
            //Engine[] engines = new Engine[2];
            //engines[0] = new Motobike();
            //engines[1] = new Car();
            //foreach (Engine engine in engines)
            //{
            //    engine.Move();
            //}

            //Interface
            //Heo heo = new Heo();
            //heo.run();
            //heo.sound();
            //Console.WriteLine(heo.cute());

            //INTERFACE AND ABSTRACT CAN CREATE ARRAY BUT NOT CREATE OBJECT
            //Interface1[] interface1 = new Interface1[3];
            //foreach( Interface1 Interface in interface1 )
            //{
            //    Interface.run();
            //}

            //Setter and getter
            //Student class1 = new Student(1,"Mai Van Tien",2);
            //Console.WriteLine(class1.getId);
            
            //Readonly and writeonly 
            Author mvtvn78 = new Author("Mai Van Tien",20);
            // mvtvn78.name ="Hehe";
            mvtvn78.Age = 19;
            mvtvn78.Show();

            //Writeonly
            //Console.WriteLine(mvtvn78.Age);

            //Lambda
            Console.WriteLine(mvtvn78.testForEquality(2,1));
        }
    }
}
