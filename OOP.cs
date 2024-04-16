using System;
using System.Text;
namespace Mvt { 
// Inherit
// class Engine
//{

//    protected string name;
//    protected int age;
//    public Engine() { 
//        Console.OutputEncoding = Encoding.UTF8;
//    }
//    ~Engine() { }
//    public void move() {
//        Console.WriteLine("Mai Văn Tiền");
//   }
//}
//class Car : Engine
//{
//   public Car() {
//        base.move();
//   }
//   ~Car() { }
//   public void Hello() { Console.WriteLine("Kaioken nè! "); }
//   static void Main()
//    {
//        Car a = new Car();
//        a.move();
//    }
//}

//Abstract method and class
//Note using abstract method you have to have abstract class

 class Engine
{
    protected string name;
    protected int age;
    public Engine() { 
        Console.OutputEncoding = Encoding.UTF8;
    }
    public virtual void Move() { }
}
class Car : Engine
{
    public Car()
    {
        this.name = "SUV Huyndai";
        this.age = 0;
    }
    public override void Move()
    {
        Console.WriteLine($"hùn hùn hon hòn hón hon hòn da da");
    }
}
class Motobike : Engine
{
    public Motobike() {
            this.name = "Yamaha R15";
            this.age = 0;
        }
    public override void Move() { 
        Console.WriteLine($"Motobike");
    }
}
}